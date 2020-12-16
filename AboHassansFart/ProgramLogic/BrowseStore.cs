using AboHassansFart.ParkingLot;
using System;
using System.Collections.Generic;
using System.Text;

namespace AboHassansFart.ProgramLogic
{
    class BrowseStore
    {
        //Skapa upp variabler för summa pengar som finns i butiken
        //Vid varje köp addera summan till potten
        //Ta bort den köpta bilen från listan
        //Skapa en metod som tilllåter AboHassan att införskaffa nya bilar
        //Skapa en statisk klass som beräknar värdet av ett fordon detta värdet baseras på year & milage

        List<Vehicle> listOfVehicles = new List<Vehicle>();

        public void Run()
        {
            AddMockData();
            WelcomeScreen();

        }


        private void WelcomeScreen()
        {

            Console.WriteLine("Welcome to AboHassans Garage, everthing was \"legally\" accuired");

            while (true)
            {
                Console.WriteLine("What do you want to do");
                Console.WriteLine("1. Inspect the lot");
                Console.WriteLine("2. Inspect the cars");
                Console.WriteLine("3. Inspect the bikes");
                Console.WriteLine("4. Make a purchase");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InspectLot();
                        break;
                    case 2:
                        InspectCars();
                        break;
                    case 3:
                        InspectBikes();
                        break;
                    case 4:
                        MakePurchase();
                        break;

                }
            }

        }

        private void MakePurchase()
        {

            Console.WriteLine("I recommend you to buy the vehicle without trying since i offer only Top quality");
            Console.WriteLine("However the goverment told me i must offer test run");
            Console.WriteLine("Chose product to examine: ");

            for (int i = 0; i < listOfVehicles.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listOfVehicles[i]} {listOfVehicles[i].Type}");
            }

            int choice = Convert.ToInt32(Console.ReadLine());

            Vehicle chosenVehicle = listOfVehicles[choice - 1];

            DemoVehicle(chosenVehicle);

        }

        private void DemoVehicle(Vehicle chosenVehicle)
        {
            bool keepPlaying = true;

            while (keepPlaying)
            {

                chosenVehicle.InspectVehicle();
                Console.WriteLine("Nice car right? What do you want to do?");
                Console.WriteLine("1. Take it for a ride");
                Console.WriteLine("2. Buy car");
                Console.WriteLine("Leave the shop");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        chosenVehicle.TestVehicle();
                        break;
                    case 2:
                        MakePurchase();
                        break;
                    case 3:
                        Console.WriteLine("Byebye");
                        keepPlaying = false;
                        break;
                }

            }

        }

        private void InspectBikes()
        {
            foreach (Vehicle bike in listOfVehicles)
            {
                if (bike is Bike)
                {
                    Console.WriteLine(bike);
                }
            }
        }

        private void InspectCars()
        {
            foreach (Vehicle car in listOfVehicles)
            {
                if (car is Car)
                {
                    Console.WriteLine(car);
                }
            }
        }

        private void InspectLot()
        {
            foreach (Vehicle veh in listOfVehicles)
            {
                Console.WriteLine(veh);
            }
        }

        private void AddMockData()
        {


            listOfVehicles.Add(new Car("Tesla", "ModelS", "Red", 500000, 0, "electric", 2020, 2));
            listOfVehicles.Add(new Car("BMW", "M5", "Blå", 300000, 1000, "Bensin", 2014, 4));
            listOfVehicles.Add(new Car("Volvo", "v40", "DesertBeige", 200000, 7000, "Bensin", 2015, 4));
            listOfVehicles.Add(new Bike("Cresent", "ComfortRider v 10", "Green", 3999, 21, false));
            listOfVehicles.Add(new Bike("EcoRide", "ElectricRider", "Blue", 250000, 21, true));
            listOfVehicles.Add(new Bike("Cresent", "ComfortRider v 8", "Green", 1000, 21, false));


        }
    }
}
