using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engine
{
    private DraftManager draftManager;

    public Engine()
    {
        this.draftManager = new DraftManager();
    }

    public void Run()
    {
        var commandArgs = Console.ReadLine().Split();
        var sb = new StringBuilder();

        while (commandArgs[0] != "Shutdown")
        {
            try
            {
                var command = commandArgs[0];
                var arguments = new List<string>();
                arguments = commandArgs.Skip(1).ToList();

                switch (command)
                {
                    case "RegisterHarvester":sb.AppendLine(draftManager.RegisterHarvester(arguments)); break;
                    case "RegisterProvider": sb.AppendLine(draftManager.RegisterProvider(arguments)); break;
                    case "Day": sb.AppendLine(draftManager.Day()); break;
                    case "Mode": sb.AppendLine(draftManager.Mode(arguments)); break;
                    case "Check": sb.AppendLine(draftManager.Check(arguments)); break;
                    default: break;
                }
            }
            catch (Exception ex)
            {
                sb.AppendLine(ex.Message);
            }

            commandArgs = Console.ReadLine().Split();
        }
        Console.WriteLine(sb.ToString().TrimEnd());
        Console.WriteLine(draftManager.ShutDown());
    }
}

