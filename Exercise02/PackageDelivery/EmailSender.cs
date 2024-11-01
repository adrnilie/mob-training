namespace PackageDelivery;

public interface EmailSender
{
    void Send(string email, string subject, string message);
}

public class ConsoleEmailSender(string sender, Uri smtpUrl) : EmailSender
{
    public void Send(string email, string subject, string message)
    {
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine($"Sending message to server: {smtpUrl}");
        Console.WriteLine($"From: {sender}");
        Console.WriteLine($"To: {email}");
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Message: {message}");
        Console.WriteLine("----------------------------------------------------------");
    }
}