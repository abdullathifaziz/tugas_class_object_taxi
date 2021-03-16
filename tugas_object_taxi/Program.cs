using System;

namespace tugas_class_object_taxi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // objek taxi
            Taxi taxi = new Taxi();

            // set nilai properties
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassanger = 10;

            // pemanggilan methode
            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOfPassanger();

            Console.Read();
        }
    }
}
