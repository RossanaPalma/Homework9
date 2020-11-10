using System;
using System.Collections.Generic;
using System.Text;

namespace Homework9
{
    class Truck : Vehicle
    {
        public double LoadCapacityTons
        {
            get;
            set;
        }
        public int TowingCapacityPounds
        {
            get;
            set;
        }
        // Constructor
        public Truck(string _name, int _cylinder, Person _owner), double _loadCapacityTons, int _towingCapacityPounds) : base(_name, _cylinder, _owner)
            {
            LoadCapacityTons = _loadCapacityTons; TowingCapacityPounds = _towingCapacityPounds;
            }
        public override string ToString()
            {
            String truckStr = "Truck" + base.ToString() + String.Format("Load Capacity : {0}  Towing Capacity: {1}", LoadCapacityTons, TowingCapacityPounds);
            return truckStr;
            }
        }
}
