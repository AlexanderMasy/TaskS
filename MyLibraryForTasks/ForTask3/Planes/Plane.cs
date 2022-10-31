using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryForTasks.ForTask3
{
    public class Plane : FlyingObject
    {
        private int maximumRange; //Максимальная дальность полета
        public Plane(string model, int cruisingSpeed, string price, int maximumRange) 
        : base(model, cruisingSpeed, price)
        {
            this.MaximumRange = maximumRange;
        }
        public int MaximumRange
        {
            private set
            {
                if (value > 0)
                    maximumRange = value;
            }
            get { return maximumRange; }
        }
    }
}
