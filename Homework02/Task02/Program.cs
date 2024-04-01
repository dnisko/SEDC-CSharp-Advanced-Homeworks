using Task02.Models;

namespace Task02
{
    internal class Program
    {
        #region Task02

        /*
            Create a class Vehicle that has one method DisplayInfo().
            Create classes Car, MotorBike, Boat, Airplane that will inherit from Vehicle and will implement the respective method.
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

        }
    }
}
