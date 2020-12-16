using System;
using System.Collections.Generic;
using System.Text;

namespace AboHassansFart.ParkingLot
{
    class Vehicle
    {
        //Fält överst i klassen
        private string color;
        private string brand;
        private string type;
        private int price;
        private int ammountOfTires;

        public virtual void TestVehicle()
        {
            Console.WriteLine("Testing...");
        }

        public virtual void InspectVehicle()
        {
            Console.WriteLine($"Brand: {this.brand} Type: {this.type} Color: {this.color} Price: {this.price}");
        }


        public virtual void Honk()
        {
            Console.WriteLine("Toot toot");
        }

        public override string ToString()
        {
            return $"{this.Color} {this.Brand}";
        }






        //Gettters och setters i botten
        public string Color { get => color; set => color = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Type { get => type; set => type = value; }
        public int Price { get => price; set => price = value; }
        public int AmmountOfTires { get => ammountOfTires; set => ammountOfTires = value; }
    }
}
