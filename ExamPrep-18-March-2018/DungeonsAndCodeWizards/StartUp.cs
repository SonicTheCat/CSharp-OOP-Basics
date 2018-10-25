using System;
using System.Linq;

namespace DungeonsAndCodeWizards
{
    public class StartUp
    {
        public static void Main()
        {
            DungeonMaster game = new DungeonMaster();

            while (true)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    GameStats(game);
                    GameOver();
                }

                var commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var command = commands[0];
                var tokens = commands.Skip(1).ToArray();

                try
                {
                    switch (command)
                    {
                        case "JoinParty":
                            Print(game.JoinParty(tokens));
                            break;
                        case "AddItemToPool":
                            Print(game.AddItemToPool(tokens));
                            break;
                        case "PickUpItem":
                            Print(game.PickUpItem(tokens));
                            break;
                        case "UseItem":
                            Print(game.UseItem(tokens));
                            break;
                        case "UseItemOn":
                            Print(game.UseItemOn(tokens));
                            break;
                        case "GiveCharacterItem":
                            Print(game.GiveCharacterItem(tokens));
                            break;
                        case "GetStats":
                            Print(game.GetStats());
                            break;
                        case "Attack":
                            Print(game.Attack(tokens));
                            break;
                        case "Heal":
                            Print(game.Heal(tokens));
                            break;
                        case "EndTurn":
                            Print(game.EndTurn());
                            break;
                        case "IsGameOver":
                            {
                                if (game.IsGameOver())
                                {
                                    GameStats(game);
                                    GameOver(); 
                                }
                            }
                            break;
                    }
                }
                catch (ArgumentException e)
                {
                    Print($"Parameter Error: {e.Message}");
                }
                catch (InvalidOperationException e)
                {
                    Print($"Invalid Operation: {e.Message}");
                }
            }
        }

        static void GameOver()
        {
            Environment.Exit(0);
        }

        static void GameStats(DungeonMaster game)
        {
            Print("Final stats:");
            Print(game.GetStats());
        }

        static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}