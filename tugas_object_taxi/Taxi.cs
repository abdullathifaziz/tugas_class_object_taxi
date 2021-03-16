using System;
namespace tugas_class_object_taxi
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public Boolean OnDuty { get; set; }
        public int NumPassanger { get; set; }

        // method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("OnDuty : {0}", OnDuty);
            Console.WriteLine("Number Of Passanger : {0}\n", NumPassanger);
        }

        public void PickUpPassanger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }

        public void DropOfPassanger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang\n", DriverName);
        }

    }
}
