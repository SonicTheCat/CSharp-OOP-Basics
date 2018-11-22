using System;

namespace AnimalCentre
{
    public class StartUp
    {
        public static void Main()
        {
            AnimalCentre animalCentre = new AnimalCentre();

            while (true)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = input[0];

                if (command == "End")
                {
                    Print(animalCentre.ReturnAllAddoptedAnimals());
                    return;
                }

                try
                {
                    switch (command)
                    {
                        case "RegisterAnimal":
                            {
                                var type = input[1];
                                var name = input[2];
                                var energy = int.Parse(input[3]);
                                var happiness = int.Parse(input[4]);
                                var procedureTime = int.Parse(input[5]);

                                var result = animalCentre.RegisterAnimal(type, name, energy, happiness, procedureTime);
                                Print(result);

                            }
                            break;
                        case "Chip":
                            {
                                var name = input[1];
                                var procedureTime = int.Parse(input[2]);

                                var result = animalCentre.Chip(name, procedureTime);
                                Print(result);
                            }
                            break;
                        case "Vaccinate":
                            {
                                var name = input[1];
                                var procedureTime = int.Parse(input[2]);

                                var result = animalCentre.Vaccinate(name, procedureTime);
                                Print(result);
                            }
                            break;
                        case "Fitness":
                            {
                                var name = input[1];
                                var procedureTime = int.Parse(input[2]);

                                var result = animalCentre.Fitness(name, procedureTime);
                                Print(result);
                            }
                            break;
                        case "Play":
                            {
                                var name = input[1];
                                var procedureTime = int.Parse(input[2]);

                                var result = animalCentre.Play(name, procedureTime);
                                Print(result);
                            }
                            break;
                        case "DentalCare":
                            {
                                var name = input[1];
                                var procedureTime = int.Parse(input[2]);

                                var result = animalCentre.DentalCare(name, procedureTime);
                                Print(result);
                            }
                            break;
                        case "NailTrim":
                            {
                                var name = input[1];
                                var procedureTime = int.Parse(input[2]);

                                var result = animalCentre.NailTrim(name, procedureTime);
                                Print(result);
                            }
                            break;
                        case "Adopt":
                            {
                                var name = input[1];
                                var owner = input[2];

                                var result = animalCentre.Adopt(name, owner);
                                Print(result);
                            }
                            break;
                        case "History":
                            {
                                var procedureType = input[1];
                                var result = animalCentre.History(procedureType);
                                Print(result);
                            }
                            break;
                    }
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("InvalidOperationException: " + e.Message);
                }
                catch (ArgumentException ee)
                {
                    Console.WriteLine("ArgumentException: " + ee.Message);
                }
            }
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}