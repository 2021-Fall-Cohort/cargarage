using System;

namespace CarGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wecome to Car Garage!");
            // this is just me trying things out in a sort of sandbox
            Car myCar = new Car();
            myCar.SetMake("Ford");
            myCar.SetModel("Contour");
            myCar.Speed = 1;
            myCar.AutoBrakeActive = true;
            myCar.Brake();
            Console.WriteLine(myCar.Speed);
            

        }
    }
}
