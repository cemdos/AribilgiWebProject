namespace AribilgiWebProject.Exception
{
    public class ExceptionUserNamePassword:System.Exception
    {
        public override string Message => "Kullanıcı adı yada şifre yanlış";
    }
}
