namespace AribilgiWebProject.Exception
{
    public class ExceptionRepeatedUser: System.Exception
    {
        public override string Message => "Kullanıcı Adı daha önceden kullanıldı";
    }
}
