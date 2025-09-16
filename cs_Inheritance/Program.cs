namespace cs_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Brand = "Ferrari";
            car1.Speed = 100;
            car1.Wheels = 6;
            car1.GoForward();

            Car car2 = new Car();
            car2.Brand = "Lambo";
            car2.Speed = 200;
            car2.Wheels = 4;
            car2.GoForward();

            Bicycle bicycle1 = new Bicycle();
            bicycle1.Brand = "Crescent";
            bicycle1.HasBell = true;

            Snowboard snowboard1 = new Snowboard();
            snowboard1.Brand = "Tony Hawk on snow";

            List<Vehicle> ProductCatalog = new List<Vehicle>();
            ProductCatalog.Add(car1);
            ProductCatalog.Add(car2);
            ProductCatalog.Add(snowboard1);
            ProductCatalog.Add(bicycle1);

            Console.WriteLine("Welcome to ammo Ali's vehicle shop, we have everything!");

            foreach (Vehicle v in ProductCatalog)
            {
                Console.WriteLine(v.GetInfo());
            }


        }
    }

    class Vehicle //Usually is abstract class 
    {
        public int Speed = 0;
        public string Brand;

        public virtual string GetInfo()
        {
            return "A Vehicle of the brand: " + Brand;
        }

        public void GoForward()
        {
            Console.WriteLine("The Vehicle is moving forward...");
        }
    }

    class Car : Vehicle
    {
        public int Wheels = 4;

        public override string GetInfo()
        {
            return $"The car: {Brand} has {Wheels} wheels, wow such amazing...";
        }
    }

    class Bicycle : Vehicle
    {
        public bool HasBell;

        public override string GetInfo()
        {
            return "The bike was stegring and also has bell " + HasBell;
        }
    }

    class Snowboard : Vehicle
    {
        public override string GetInfo()
        {
            return "The snowboard wooshes down the mountain";
        }
    }
}
