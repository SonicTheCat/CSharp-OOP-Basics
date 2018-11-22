using AnimalCentre.Factories;
using AnimalCentre.Models.Hotels;
using AnimalCentre.Models.Procedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalCentre
{
    public class AnimalCentre
    {
        private AnimalFactory factory;
        private Chip chip;
        private DentalCare care;
        private Fitness fitness;
        private NailTrim trim;
        private Play play;
        private Vaccinate vac;

        private Hotel hotel;
        private List<Procedure> procedures;
        private Dictionary<string, List<string>> allAddoptedAnimals;

        public AnimalCentre()
        {
            this.hotel = new Hotel();
            this.factory = new AnimalFactory();
            this.chip = new Chip();
            this.care = new DentalCare();
            this.fitness = new Fitness();
            this.trim = new NailTrim();
            this.play = new Play();
            this.vac = new Vaccinate();

            this.procedures = new List<Procedure>()
            {
              chip,care,fitness,trim,play,vac
            };

            this.allAddoptedAnimals = new Dictionary<string, List<string>>();
        }

        public string RegisterAnimal(string type, string name, int energy, int happiness, int procedureTime)
        {
            var animal = this.factory.CreateAnimal(type, name, energy, happiness, procedureTime);
            this.hotel.Accommodate(animal);

            return $"Animal {name} registered successfully";
        }

        public string Chip(string name, int procedureTime)
        {
            DoesAnimalExistInHotel(name);
            var animal = this.hotel.Animals[name];
            chip.DoService(animal, procedureTime);

            return $"{name} had chip procedure";
        }

        public string Vaccinate(string name, int procedureTime)
        {
            DoesAnimalExistInHotel(name);
            var animal = this.hotel.Animals[name];
            vac.DoService(animal, procedureTime);

            return $"{name} had vaccination procedure";
        }

        public string Fitness(string name, int procedureTime)
        {
            DoesAnimalExistInHotel(name);
            var animal = this.hotel.Animals[name];
            fitness.DoService(animal, procedureTime);

            return $"{name} had fitness procedure";
        }

        public string Play(string name, int procedureTime)
        {
            DoesAnimalExistInHotel(name);
            var animal = this.hotel.Animals[name];
            play.DoService(animal, procedureTime);

            return $"{name} was playing for {procedureTime} hours";
        }

        public string DentalCare(string name, int procedureTime)
        {
            DoesAnimalExistInHotel(name);
            var animal = this.hotel.Animals[name];
            care.DoService(animal, procedureTime);

            return $"{name} had dental care procedure";
        }

        public string NailTrim(string name, int procedureTime)
        {
            DoesAnimalExistInHotel(name);
            var animal = this.hotel.Animals[name];
            trim.DoService(animal, procedureTime);

            return $"{name} had nail trim procedure";
        }

        public string Adopt(string animalName, string owner)
        {
            DoesAnimalExistInHotel(animalName);

            var animal = this.hotel.Animals[animalName];
            this.hotel.Adopt(animalName, owner);

            if (!this.allAddoptedAnimals.ContainsKey(owner))
            {
                this.allAddoptedAnimals.Add(owner, new List<string>());
            }
            this.allAddoptedAnimals[owner].Add(animalName);

            if (animal.IsChipped)
            {
                return $"{owner} adopted animal with chip";
            }
            else
            {
                return $"{owner} adopted animal without chip";
            }
        }

        public string History(string type)
        {
            var procedure = this.procedures.FirstOrDefault(p => p.GetType().Name == type);
            return procedure.History();
        }

        private void DoesAnimalExistInHotel(string name)
        {
            if (!this.hotel.Animals.ContainsKey(name))
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }
        }

        public string ReturnAllAddoptedAnimals()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var kvp in this.allAddoptedAnimals.OrderBy(x => x.Key))
            {
                sb.AppendLine("--Owner: " + kvp.Key);
                var insideList = kvp.Value;
                sb.AppendLine($"- Adopted animals: {string.Join(" ", insideList)}");
            }

            return sb.ToString().Trim();
        }
    }
}