using Task02.Models;

namespace Task02
{
    internal class Program
    {
        #region Task02

        /*
            From the previous homework get the implementation and do not change the implementation of the classes. Now we need to add couple methods

           Car class should have Drive() method;
           MotorBike should have Wheelie() method;
           Boat should have Sail() method;
           Airplane should have Fly() method;

        */

        #endregion
        static void Main(string[] args)
        {
            Vehicle car = new Car();
            Vehicle motorBike = new MotorBike();
            Vehicle boat = new Boat();
            Vehicle plane = new Airplane();

            Console.WriteLine(car.DisplayInfo());
            Console.WriteLine(motorBike.DisplayInfo());
            Console.WriteLine(boat.DisplayInfo());
            Console.WriteLine(plane.DisplayInfo());

            Console.WriteLine();

            Console.WriteLine(VehicleHelper<Vehicle>.Drive(car));
            Console.WriteLine(VehicleHelper<Vehicle>.Wheelie(motorBike));
            Console.WriteLine(VehicleHelper<Vehicle>.Sail(boat));
            Console.WriteLine(VehicleHelper<Vehicle>.Fly(plane));
        }
    }
}
