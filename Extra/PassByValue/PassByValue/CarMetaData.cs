using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValue
{
    public class CarMetaData
    {
        public int Year { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Displacement { get; set; }
        public int Cylinders { get; set; }
        public int City { get; set; }
        public int Highway { get; set; }
        public int Combined { get; set; }

        public CarMetaData(int year, string manufacturer, string name, double displacement, int cylinders, int city, int highway, int combined)
        {
            Year = year;
            Manufacturer = manufacturer;
            Name = name;
            Displacement = displacement;
            Cylinders = cylinders;
            City = city;
            Highway = highway;
            Combined = combined;
        }

        public CarMetaData()
        {
            Year = 2015;
            Manufacturer = "Ferrari";
            Name = "Enzo";
            Displacement = 60.0;
            Cylinders = 6;
            City = 5;
            Highway = 99;
            Combined = 2;
        }

        public override string ToString()
        {
            return $"\nCar info: \n\t Year:{Year} \n\t Manufacturer:{Manufacturer} \n\t Name:{Name} \n\t Displacement:{Displacement} \n\t Cylinders:{Cylinders} \n\t City:{City} \n\t Highway:{Highway} \n\t Combined:{Combined}";
        }
    }
}
