namespace Encapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {

            Driver d1 = new Driver("WEST1234", "Simon West", 36, "123 Street");
            Car c1 = new Car("REG123", "Red", "VW", "V1", d1);
            Motorbike m1 = new Motorbike("MOT123", "Purple", "Suzaki", "S1", d1);


            Driver d2 = new Driver("SAM1234", "Sam West", 63, "321 Street");
            Car c2 = new Car("REG321", "Blue", "VW", "V2", d2);
            Motorbike m2 = new Motorbike("MOT321", "Purple", "Suzaki", "S2", d2);
                                                            //Y, M, D, H, m, S
            Booking b1 = new Booking(c1, "MOT", new DateTime(2022,12,14,12,0,0));
                                                                //--15/12/200 09:00--
            Booking b2 = new Booking(m2, "Repair", new DateTime(2022, 12, 15, 9, 0, 0));

            Garage g1 = new Garage("ABC Repair and MOT", "1234 Lux Street");

            g1.Bookings.Add(b1);    
            g1.Bookings.Add(b2);

            foreach (Booking booking in g1.Bookings)
            {
                Console.WriteLine(booking);
                Console.WriteLine("---------------");
                Console.WriteLine("---------------");
            }

        }
    }


}