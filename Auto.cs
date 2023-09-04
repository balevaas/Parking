using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Auto
    {
        private string Driver;
        private string Brand;
        private string Model;
        private string Color;
        private int Number_auto;

        public Auto(string driver, string brand, string model, string color, int number_auto)
        {
            Driver = driver;
            Brand = brand;
            Model = model;
            Color = color;
            Number_auto = number_auto;
        }

        public void ShowAuto()
        {
            Console.WriteLine();
            Console.Write($"Автомобиль {Brand} {Model}, цвет: {Color}, c номером: {Number_auto}. ");
            Console.WriteLine($"Водитель автомобиля: {Driver}");
        }
    }
}
