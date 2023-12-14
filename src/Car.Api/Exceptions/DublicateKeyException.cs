namespace Car.Api.Exceptions
{
    public class DublicateKeyException:Exception
    {
        public DublicateKeyException() : base("Key cannot be dublicate")
        { }
    }
}
