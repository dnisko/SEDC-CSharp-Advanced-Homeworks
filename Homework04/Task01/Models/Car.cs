using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Models
{
    public class Car
    {
        public string Model { get; set; }
        public double MilesPerGallon { get; set; }
        public int Cylinders { get; set; }
        public double HorsePower { get; set; }
        public double Weight { get; set; }

        /// <summary>
        /// Acceleration time to 100kmph
        /// </summary>
        public double AccelerationTime { get; set; }
        public string Origin { get; set; }

        public string GetInfo()
        {
            //Model = "Chevrolet Chevelle Malibu", MilesPerGallon = 18, AccelerationTime = 12, Cylinders = 8,
            //HorsePower = 130, Origin = "US", Weight = 3504
            string result = $"Model: {Model}, Miles per Gallon: {MilesPerGallon}, " +
                            $"Acceleration time: {AccelerationTime}, No. of cylinders: {Cylinders}, " +
                            $"Horse power: {HorsePower}, Origin: {Origin}, Weight: {Weight}";

            return result;
        }
    }
}
