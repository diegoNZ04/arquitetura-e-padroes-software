namespace solid.DIP.Bad;

public class EmailService
{
    public void Send()
    {
        Console.WriteLine("SEND");
    }
}

public class UserService(EmailService service)
{
    public void Register()
    {
        service.Send();
    }
}
