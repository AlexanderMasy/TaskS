using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryForTasks.ForTask3.Planes
{
    public class CargoPlane : Plane
    {
        private int cargoWeight;
        public CargoPlane(string model, int cruisingSpeed, string price, int maximumRange,int cargoWeight)
        : base(model, cruisingSpeed, price, maximumRange)
        {
            this.CargoWeight = cargoWeight;
        }
        public int CargoWeight
        {
            private set
            {
                if (value > 0)
                {
                    cargoWeight = value;
                }
            }
            get
            {
                return cargoWeight;
            }
        }
    }
}
