using System;
using System.Collections.Generic;
using System.Text;

namespace Homework9 
{ 
    public enum ManufacturerName 
    {
    Toyota, Honda, Fiat, Ford, VW, GM        
    }

    class Vehicle : Person
    {
        public string Name
        {  get;  set; }
        public int Cylinder
        { get; set; }
        public Person Owner
        { get; set; }
    // Constructors
        public Vehicle(Person _owner) : base(_owner)
        {
            Name = Enum.GetName(typeof(ManufacturerName));
            Cylinder = 4;
        }
        public Vehicle(string _name, int _cylinder, Person _owner) : base(_owner)
        {
            Name = _name;
            Cylinder = _cylinder;
        }
        public override string ToString()
        {
            String vehicleStr = "Vehicle" + base.ToString() +
            String.Format("Manufacturer : {0}, Cylinders: {1}" , Name, Cylinder);
            return vehicleStr;
        }

    }
}
