using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp2
{
    public class Appliance
    {
        private string brand;
        private string model;
        private string color;

        public string Brand { get; set; }
        public string Model { get { return model; } set { model = value; } }

        public string Color { get { return color; } set { color = value; } }

        public Appliance(string brand = "", string model = "", string color = "")
        {
            Brand = brand;
            Model = model;
            Color = color;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Марка: {brand}, Модель: {model}, Цвет: {color}");
        }
        public override string ToString()
        {
            return $"Марка: {Brand}, модель: {Model}, цвет: {Color}";
        }
    }
}
