namespace OOP.polymorfizm;

public class DatabaseLogger : BaseLogger
{
    public override void Log()
    {
        Console.WriteLine("Veritabanına loglandı");
        
    }

    public override void Debug(string message)
    {
        base.Debug("Logging Debug");
    }

}
