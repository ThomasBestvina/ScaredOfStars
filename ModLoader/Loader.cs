using MoonSharp.Interpreter;

namespace ModLoader;

public class Loader
{
    private Script script;

    public Loader()
    {
        script = new Script();
    }
        
    public void RegisterType<T>()
    {
        UserData.RegisterType(typeof(T));
    }

    public void RegisterObject<T>(string name, T instance)
    {
        script.Globals[name] = instance;
    }

    public void Run(string lua)
    {
        this.script.DoString(lua);
    }
}