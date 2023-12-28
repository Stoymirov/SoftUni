using System;

namespace SoftUniParking;


    public class StartUp
    {
        public static void Main(string[] args)
        {
            var car = new Car("Skoda", "Fabia", 65, "CC1856BG");
            var car2 = new Car("Audi", "A3", 110, "EB8787MN");

            Console.WriteLine(car.ToString());
            // Make: Skoda
            // Model: Fabia
            // HorsePower: 65
            // RegistrationNumber: CC1856BG

            var Parking = new Parking(5);
            Console.WriteLine(Parking.AddCar(car));
            // Successfully added new car Skoda CC1856BG

            Console.WriteLine(Parking.AddCar(car));
            // Car with that registration number, already exists!

            Console.WriteLine(Parking.AddCar(car2));
            // Successfully added new car Audi EB8787MN

            Console.WriteLine(Parking.GetCar("EB8787MN").ToString());
            // Make: Audi
            // Model: A3
            // HorsePower: 110
            // RegistrationNumber: EB8787MN

            Console.WriteLine(Parking.RemoveCar("EB8787MN"));
            // Successfullyremoved EB8787MN

            Console.WriteLine(Parking.Count);
            // 1

    }
}
