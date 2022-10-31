using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryForTasks.ForTask3.Planes
{
    public class PassengerPlane : Plane
    {
        private int numberOfPassengerSeats;
        private int luggageWeight;
        public PassengerPlane(string model, int cruisingSpeed, string price, int maximumRange, int numberOfPassengerSeats, int luggageWeight)
        : base(model, cruisingSpeed, price, maximumRange)
        {
            this.NumberOfPassengerSeats = numberOfPassengerSeats;
            this.LuggageWeight = luggageWeight;
        }
        public int NumberOfPassengerSeats
        {
            private set
            {
                if (value > 0)
                {
                    numberOfPassengerSeats = value;
                }
            }
            get
            {
                return numberOfPassengerSeats;
            }
        }
        public int LuggageWeight
        {
            private set
            {
                if (value > 0)
                {
                    luggageWeight = value;
                }
            }
            get
            {
                return luggageWeight;
            }
        }
    }
}
