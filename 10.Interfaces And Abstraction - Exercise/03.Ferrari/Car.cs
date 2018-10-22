namespace Ferrari
{
    abstract public class Car : ICar
    {
        public string Model { get; }

        public string Driver { get; set; }

        public Car(string model, string driver)
        {
            this.Model = model;
            this.Driver = driver;
        }

        public string PushBrakes()
        {
            return "Brakes!";
        }

        public string PushGas()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{PushBrakes()}/{PushGas()}/{this.Driver}";
        }
    }
}