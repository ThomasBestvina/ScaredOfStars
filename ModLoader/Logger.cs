using MoonSharp.Interpreter;

namespace ModLoader;

[MoonSharpUserData]
public class Logger
{
    private string prefix;

    public Logger(string prefix)
    {
        this.prefix = prefix;
    }

    public void Info(string message)
    {
        Console.WriteLine($"[{prefix} INFO]: {message}");
    }

    public void Warning(string message)
    {
        Console.WriteLine($"[{prefix} WARN]: {message}");
    }
    
    public void Error(string message)
    {
        Console.WriteLine($"[{prefix} ERROR]: {message}");
    }

    public void SetPrefix(string newPrefix)
    {
        this.prefix = newPrefix;
    }
}