namespace OOP.polymorfizm;

public class FileLogger : BaseLogger
{
    public override void Log()
    {
        Console.WriteLine("Dosyaya loglandı");
    }

    public override void Error(string message)
    {
        base.Error(message);
    }


}
