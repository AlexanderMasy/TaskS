using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryForTasks.ForTask3
{
    public class FlyingObject
    {
        private int cruisingSpeed;
        private string model;
        private string price;
        public FlyingObject(string model, int cruisingSpeed, string price)
        {
            this.Model = model;
            this.CruisingSpeed = cruisingSpeed;
            this.Price = price;
        }

        public string Model
        {
            private set
            {
                if (value is String)
                model = value;
            }
            get
            {
                return model;
            }
        }
        public int CruisingSpeed
        {
            protected set
            {
                if(value > 0)
                {
                    cruisingSpeed = value;
                }
            }
            get
            {
                return cruisingSpeed;
            }
        }
        public string Price
        {
            protected set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }
        public string Report()
        {
            return this.Model + this.Price;
        }
    }
}
