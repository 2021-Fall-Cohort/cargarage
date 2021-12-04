using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public string Make;
        public string Model;
        public int Speed { get; set; }
        public int FuelLevel { get; set; }
        public bool AutoBrakeActive { get; set; }

        public void SetMake(String make)
        {
            this.Make = make;
            Console.WriteLine("Make set to: " + this.Make);
        }
        public void SetModel(String model)
        {
            this.Model = model;
            Console.WriteLine("Model set to: " + this.Model);
        }
        public int GetSpeed()
        {
            return this.Speed;
        }
        public bool IsSpeeding()
        {
            return this.Speed > 70;
        }
        public void Accelerate()
        {
            
           
        if (this.Make == "Ferrari")
            {
            if (this.Speed + 20 <= 100)
                {
                this.Speed += 20;
                } 
            }
        else
            {
            if (this.Speed + 10 <= 100)
                {
                this.Speed += 10;
                } 
            
            }
             
        }
        public void Brake()
        {
            if (!AutoBrakeActive)
            {
                if (this.Speed - 7 < 0)
                {
                    this.Speed = 0;
                }
                else
                {
                    this.Speed -= 7;
                }
            }
            else
            {
                this.Speed = Convert.ToInt32(Math.Round(Convert.ToDouble(this.Speed) * .5));
                    
            }
        }
    }
}
