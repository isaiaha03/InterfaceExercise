using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public string Manufacturer { get; set; }
        public bool HasSunRoof { get; set; }
        public string Model { get; set; }
    }
}
