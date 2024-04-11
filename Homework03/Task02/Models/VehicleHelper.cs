namespace Task02.Models
{
    /*
           From the previous homework get the implementation and do not change the implementation of the classes. Now we need to add couple methods

          Car class should have Drive() method;
          MotorBike should have Wheelie() method;
          Boat should have Sail() method;
          Airplane should have Fly() method;

       */
    //whole class to be of type T, so I could use T in all methods and define the type in Program.cs, when using
    internal class VehicleHelper<T> where T : Vehicle
    {
        public static string Drive(T car)
        {
            if (car.GetType() == typeof(Car))
            {
                return "Driving";
            }

            return "";
        }
        public static string Wheelie(T motorBike)
        {
            if (motorBike.GetType() == typeof(MotorBike))
            {
                return "Driving on one wheel";
            }

            return "";
        }
        public static string Sail(T boat)
        {
            if (boat.GetType() == typeof(Boat))
            {
                return "Saling";
            }

            return "";
        }
        public static string Fly(T airplane)
        {
            return airplane.GetType() == typeof(Airplane) ? "Flying" : "";
        }
    }
}
