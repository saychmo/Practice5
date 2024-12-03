using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Dishwasher : Appliance
    {

        private int numberOfPrograms;


        public int NumberOfPrograms
        {
            get
            {
                return numberOfPrograms;
            }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException();
                numberOfPrograms = value;
            }
        }
        public Dishwasher(string brand = "", string model = "", string color = "", int numberOfPrograms = 2)
        {
            Brand = brand;
            Model = model;
            Color = color;
            NumberOfPrograms = numberOfPrograms;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($", Количество программ: {NumberOfPrograms}");
        }
        public override string ToString()
        {
            return base.ToString()+$", количесво программ: {NumberOfPrograms}";
        }
    }
}
