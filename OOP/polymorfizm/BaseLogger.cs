using Microsoft.Extensions.Logging;

namespace OOP.polymorfizm;

public abstract class BaseLogger
{
    public abstract void Log();



    protected ILogger<BaseLogger> _logger;
    public virtual void Error(string message) => _logger.LogError(message);
    public virtual void Info(string message) => _logger.LogInformation(message);
    public virtual void Debug(string message) => _logger.LogDebug(message);
}










