using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class WashingMachine : Appliance
    {
        private int capacity;


        public WashingMachine(string brand = "", string model = "", string color = "", int capacity = 10)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Capacity = capacity;
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException();

                capacity = value;
            }
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($", Емкость: {capacity} кг");
        }
        public override string ToString()
        {
            return base.ToString() + $", емкость: {Capacity}";
        }

    }
}
