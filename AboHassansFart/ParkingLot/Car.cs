using System;
using System.Collections.Generic;
using System.Text;

namespace AboHassansFart.ParkingLot
{
    class Car : Vehicle
    {

        private int milage;
        private string motorType;
        private int year;
        private int doors;


        public Car(string brand, string type, string color, int price, int milage, string motortype, int year, int doors)
        {
            this.Brand = brand;
            this.Type = type;
            this.Color = color;
            this.Price = price;
            this.milage = milage;
            this.motorType = motortype;
            this.year = year;
            this.doors = doors;
        }

        public override void TestVehicle()
        {
            Drive();
        }

        public void Drive()
        {
            Console.WriteLine("You take the Vehicle for a ride");
            milage += 10;
        }

        public override void Honk()
        {
            Console.WriteLine("TOooooTO TOTOOTOTOto");
        }

        public override void InspectVehicle()
        {
            Console.WriteLine($"Brand: {this.Brand} Type: {this.Type} Color: {this.Color} Price: {this.Price} Milage: {this.Milage} MotorType: {this.MotorType} Year: {this.Year} Doors: {this.doors}");

        }

        public int Milage { get => milage; set => milage = value; }
        public string MotorType { get => motorType; set => motorType = value; }
        public int Year { get => year; set => year = value; }
        public int Doors { get => doors; set => doors = value; }
    }
}
