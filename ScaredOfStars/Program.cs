

using System;
using ModLoader;

public class Program
{
    public static void Main()
    {
        Loader md = new Loader();
        md.RegisterType<Logger>();
        Logger logger = new Logger("Mod Log");
        md.RegisterObject<Logger>("logger",logger);
        string luaScript = @"
            -- Use the C# object methods
            logger:Info('Application started')
            
            -- Use object methods in Lua logic
            local items = {'apple', 'banana', 'cherry'}
            
            for i, item in ipairs(items) do
                logger:Info('Processing item: ' .. item)
            end
            
            -- Change logger configuration from Lua
            logger:SetPrefix('UPDATED')
            logger:Info('Logger prefix changed from Lua!')
            
            -- Error handling
            if math.random() > 0.5 then
                logger:Error('Random error occurred!')
            else
                logger:Info('Everything is fine!')
            end
        ";

        try
        {
            md.Run(luaScript);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        
        
        using var game = new ScaredOfStars.Game1();
        game.Run();
    }
}