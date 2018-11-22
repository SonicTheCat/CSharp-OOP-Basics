using AnimalCentre.Models.Animals;
using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Hotels
{
    public class Hotel : IHotel
    {
        private const int Capacity = 10;

        private Dictionary<string, IAnimal> animals; 

        public Hotel()
        {
            this.animals = new Dictionary<string, IAnimal>(Capacity);
        }

        public IReadOnlyDictionary<string, IAnimal> Animals => this.animals; 

        public void Accommodate(IAnimal animal)
        {
            if (this.animals.Count >= Capacity)
            {
                throw new InvalidOperationException("Not enough capacity");
            }
            else if (this.animals.ContainsKey(animal.Name))
            {
                throw new ArgumentException($"Animal {animal.Name} already exist");
            }
            else
            {
                this.animals.Add(animal.Name, animal); 
            }
        }

        public void Adopt(string animalName, string owner)
        {
            if (!this.animals.ContainsKey(animalName))
            {
                throw new ArgumentException($"Animal {animalName} does not exist");
            }
            else
            {
                this.animals[animalName].ChangeOwner(owner);
                this.animals[animalName].IsAdopt = true;

                this.animals.Remove(animalName); 
            }
        }
    }
}