using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string Manufacturer { get; set; }
        public bool HasSunRoof { get; set; }
        public string Model { get; set; }

        public string Logo { get; set; }
        public string Headquarters { get; set; }

        public bool HasTrunk { get; set; }
        public bool IsCoupe { get; set; }
    }
}
