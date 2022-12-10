using AribilgiWebProject.RESTFUL.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web.Http;

namespace AribilgiWebProject.RESTFUL.Controllers
{
    [Authorize]
    public class AccountController : ApiController
    {
        [AllowAnonymous]
        [HttpGet]
        [Route("Account/Login/{UserName}/{Password}")]
        public async Task<Token> Login(string UserName, string Password)
        {
            string baseAddress = "http://localhost:50406/";
            using (var client = new HttpClient())
            {
                var form = new Dictionary<string, string>
               {
                   {"grant_type", "password"},
                   {"UserName", UserName},
                   {"Password", Password},
               };
                var tokenResponseAsync = await client.PostAsync($"{baseAddress}/token", new FormUrlEncodedContent(form));
                var token = tokenResponseAsync.Content.ReadAsAsync<Token>(new[] { new JsonMediaTypeFormatter() }).Result;
                return token;
            }
        }
    }
}
