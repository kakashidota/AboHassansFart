using System;
using System.Collections.Generic;
using System.Text;

namespace AboHassansFart.ParkingLot
{
    class Bike : Vehicle
    {



        private int gears;
        private bool electric;

        public Bike(string brand, string type, string color, int price, int gears, bool electric)
        {
            this.Brand = brand;
            this.Type = type;
            this.Color = color;
            this.Price = price;
            this.Gears = gears;
            this.Electric = electric;
        }

        public override void TestVehicle()
        {
            GoForARide();
        }

        public void GoForARide()
        {
            Console.WriteLine("You go for a ride");
            Honk();
        }

        public int Gears { get => gears; set => gears = value; }
        public bool Electric { get => electric; set => electric = value; }
    }
}
