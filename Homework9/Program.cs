using System;

namespace Homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            Person name1 = new Person("Paul");
            Console.WriteLine("First person  : " + name1.ToString());
            Person name2 = new Person("Joe");
            Console.WriteLine("Second person : " + name2.ToString());
            Person name3 = new Person("Jack");
            Console.WriteLine("Third person  : " + name3.ToString());
        }
        // Equals Method
        
        Console.WriteLine("name1 = name2 ? " + name1.Equals(name2));
        Console.WriteLine("name2 = name3 ? " + name2.Equals(name3));
        
        // Vehicle
        Vehicle vehicle1 = new Vehicle(name1);
        Console.WriteLine("Vehicle 1 : " + vehicle1.ToString());
        Vehicle vehicle2 = new Vehicle(name2);
        Console.WriteLine("Vehicle 2 : " + vehicle2.ToString());

        // Truck 
        Truck truck1 = new Truck(Enum.GetName(typeof(ManufacturerName));
        Console.WriteLine("Person name1 : " + truck1.ToString());

            }
     }


