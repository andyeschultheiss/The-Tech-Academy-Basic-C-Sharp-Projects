using System;
using System.Collections.Generic;

namespace Const_and_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Andy Schultheiss";
            var carList = new List<string>() { "Mitsubishi Delica", "Acura RSX", "Chevrolet Bolt", "Subaru Forester" };

            carSpecs mitsubishiDelica = new carSpecs(carList[0], true, 4);
            carSpecs acuraRSX = new carSpecs(carList[1], true, 4);
            carSpecs chevyBolt = new carSpecs(carList[2], false);
            carSpecs subaruForester = new carSpecs(carList[3], true, 4);

            Console.WriteLine("The {0} is a gas-powered vehicle: {1} ", chevyBolt.carName, chevyBolt.isGasPowered.ToString());

            Console.WriteLine("Therefore, it has {0} cylinders", chevyBolt.numberOfCylinders.ToString());

            Console.Read();

        }

        public class carSpecs
        {
            public carSpecs(string name, bool gasPowered) : this(name, gasPowered, 0)
            {
            }
            public carSpecs(string name, bool gasPowered, int numberCylinders)
            {
                carName = name;
                isGasPowered = gasPowered;
                numberOfCylinders = numberCylinders;
            }
            public string carName { get; set; }
            public int numberOfCylinders { get; set; }
            public bool isGasPowered { get; set; }

        }
    }
}
