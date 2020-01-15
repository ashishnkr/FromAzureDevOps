using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace PassByValue
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new CarMetaData();
            var newCar = TransformCar(myCar);              // Reference Types are passing value of reference to the object in Memory
                                                           // Reference Types holds the reference (address) of the object in Memory
            var number = 5;
            var newNumber = TransformNumber(number);            // Value Types are passing the value of value type

            Console.WriteLine(myCar.ToString());                // Lamborghini will be printed
            Console.WriteLine(newCar.ToString());               // Lamborghini will be printed
            Console.WriteLine($"Old Number : {number}");        // Original Number will be printed
            Console.WriteLine($"New Number : {newNumber}");     // New Number will be printed
            Console.ReadKey();
        }

        private static int TransformNumber(int numberParsed)
        {
            var newNum = numberParsed;
            newNum += newNum;
            return newNum;
        }

        private static CarMetaData TransformCar(CarMetaData myCarParsed)
        {
            myCarParsed.Year = 1995;
            myCarParsed.Manufacturer = "Lamborghini";
            myCarParsed.Name = "Gallardo";
            myCarParsed.Displacement = 80.0;
            myCarParsed.Cylinders = 8;

            return myCarParsed;
        }
    }
}
