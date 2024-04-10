using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE: Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //DONE: In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //DONE: In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //DONE: In each of your Car, Truck, and SUV classes

            /*DONE: Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //DONE: Now, create objects of your 3 classes and give their members values.
            Car myCar = new Car
            {
                NumberOfWheels = 4,
                Manufacturer = "Toyota",
                Logo = "Toyota Logo",
                Headquarters = "Japan",
                HasSunRoof = true,
                Model = "Corolla",
                HasTrunk = true,
                IsCoupe = false,
            };

            Truck myTruck = new Truck
            {
                NumberOfWheels = 6,
                Manufacturer = "Ford",
                Logo = "Ford Logo",
                Headquarters = "USA",
                HasSunRoof = true,
                Model = "F-150",
                HasTruckBed = true,
                HasSpareTire = true,
            };

            SUV mySUV = new SUV
            {
                NumberOfWheels = 4,
                Manufacturer = "Honda",
                Logo = "Honda Logo",
                Headquarters = "Japan",
                HasSunRoof = true,
                Model = "Pilot",
                NumberOfSeats = 8,
                HasSlidingDoors = false,
            };
            //Creatively display and organize their values
            Console.WriteLine($"Car:");
            Console.WriteLine($"Manufacturer: {myCar.Manufacturer}, Model: {myCar.Model}");
            Console.WriteLine($"Logo: {myCar.Logo}, Company Headquarters: {myCar.Headquarters}");
            Console.WriteLine($"Is a Coupe: {myCar.IsCoupe}, Number of Wheels: {myCar.NumberOfWheels}");
            Console.WriteLine($"Has a Trunk: {myCar.HasTrunk}, Has a Sun Roof: {myCar.HasSunRoof}");
            Console.WriteLine();

            Console.WriteLine($"Truck:");
            Console.WriteLine($"Manufacturer: {myTruck.Manufacturer}, Model: {myTruck.Model}");
            Console.WriteLine($"Logo: {myTruck.Logo}, Company Headquarters: {myTruck.Headquarters}");
            Console.WriteLine($"Has a Truck Bed: {myTruck.HasTruckBed}, Number of Wheels: {myTruck.NumberOfWheels}");
            Console.WriteLine($"Has a Spare Tire: {myTruck.HasSpareTire}, Has a Sun Roof: {myTruck.HasSunRoof}");
            Console.WriteLine();

            Console.WriteLine($"SUV:");
            Console.WriteLine($"Manufacturer: {mySUV.Manufacturer}, Model: {mySUV.Model}");
            Console.WriteLine($"Logo: {mySUV.Logo}, Company Headquarters: {mySUV.Headquarters}");
            Console.WriteLine($"Number of Seats: {mySUV.NumberOfSeats}, Number of Wheels: {mySUV.NumberOfWheels}");
            Console.WriteLine($"Has Sliding Doors: {mySUV.HasSlidingDoors}, Has a Sun Roof: {mySUV.HasSunRoof}");
            Console.WriteLine();

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
