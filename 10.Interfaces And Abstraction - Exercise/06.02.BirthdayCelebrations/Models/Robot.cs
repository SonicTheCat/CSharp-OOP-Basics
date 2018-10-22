using BirthdayCelebrations.Interfaces;

namespace BirthdayCelebrations.Models
{
    class Robot : IIdentifiable
    {
        public string Id { get; }
        public string Model { get; }

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
    }
}
