namespace Car.Api.Exceptions
{
    public class NotFoundCarException:Exception
    {
        public NotFoundCarException() : base("Databaseda yo'q")
        { }
    }
}
