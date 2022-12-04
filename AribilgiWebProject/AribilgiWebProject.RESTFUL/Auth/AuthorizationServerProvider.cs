using AribilgiWebProject.BLL.Classes;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AribilgiWebProject.RESTFUL.Auth
{
    public class AuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        private UserRepository userRepository;
        public AuthorizationServerProvider()
        {
            userRepository = new UserRepository();
        }

        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
            return Task.CompletedTask;
        }

        public override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            var result = userRepository.Login(context.UserName, context.Password);
            if (result.IsSuccess && result.ResponseModel != null)
            {
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim("UserName", result.ResponseModel.UserName));
                identity.AddClaim(new Claim("UserId", result.ResponseModel.ID.ToString()));
                identity.AddClaim(new Claim("Role", result.ResponseModel.Rol.ToString()));

                context.Validated(identity);
            }
            else
            {
                context.SetError("Oturum Hatası", "Kullanıcı adı ve şifre hatalıdır");
            }

            return Task.CompletedTask;
        }
    }
}