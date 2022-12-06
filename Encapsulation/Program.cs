namespace Encapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {


            Driver d1 = new Driver("WEST1234", "Simon West", 36, "123 Street");
            Car c1 = new Car("REG123", "Red", "VW", "V1", d1);

            Console.WriteLine(c1);
        }
    }

}