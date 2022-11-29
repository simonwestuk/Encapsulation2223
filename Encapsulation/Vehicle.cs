namespace Encapsulation
{
    internal class Vehicle
    {
        public string Registration { get; set; } //Auto-gen Properties
        public string Colour { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NoOfWheels { get; set; }
        public Vehicle(string registration, string colour, string make, string model, int noOfWheels)
        {
            Registration = registration;
            Colour = colour;
            Make = make;
            Model = model;
            NoOfWheels = noOfWheels;
        }
    }
}
