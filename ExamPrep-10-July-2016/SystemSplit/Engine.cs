using System;

public class Engine
{
    TheSystem system;

    public Engine(TheSystem system)
    {
        this.system = system;
    }

    public void Run()
    {
        while (true)
        {
            var tokens = Console.ReadLine().Split(new char[] { ',', ' ', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            var command = tokens[0];

            try
            {
                switch (command)
                {
                    case "RegisterPowerHardware":
                    case "RegisterHeavyHardware":
                        {
                            this.system.RegisterHardware(tokens);
                        }
                        break;
                    case "RegisterLightSoftware":
                    case "RegisterExpressSoftware":
                        {
                            this.system.RegisterSoftware(tokens);
                        }
                        break;
                    case "ReleaseSoftwareComponent":
                        {
                            this.system.ReleaseSoftwareComponent(tokens);
                        }
                        break;
                    case "Analyze":
                        {
                            this.Print(this.system.Analyze());
                        }
                        break;
                    case "System":
                        {
                            this.Print(this.system.SystemSplit());
                            Environment.Exit(0);
                        }
                        break;
                    case "Dump":
                        {
                            var hardwareName = tokens[1];
                            this.system.Dumper.Dump(hardwareName);
                        }
                        break;
                    case "Restore":
                        {
                            var hardwareName = tokens[1];
                            this.system.Dumper.Restore(hardwareName);
                        }
                        break;
                    case "Destroy":
                        {
                            var hardwareName = tokens[1];
                            this.system.Dumper.Destroy(hardwareName);
                        }
                        break;
                    case "DumpAnalyze":
                        {
                            Print(this.system.Dumper.DumpAnalyze());
                        }
                        break;
                }
            }
            catch { }
        }
    }

    private void Print(string result)
    {
        Console.WriteLine(result);
    }
}