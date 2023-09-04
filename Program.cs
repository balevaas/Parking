using System.Collections.Generic;
using System.Xml.Linq;

namespace Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string driver, brand, model, color;
            int number_auto;
            List<Auto> autos = new List<Auto>();

            Console.Write("Введите количество автомобилей: ");
            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine($"Автомобиль {i + 1}:");
                Console.Write("ФИО водителя: ");
                driver = Console.ReadLine();
                Console.Write("Марка автомобиля: ");
                brand = Console.ReadLine();
                Console.Write("Модель автомобиля: ");
                model = Console.ReadLine();
                Console.Write("Цвет автомобиля: ");
                color = Console.ReadLine();
                Console.Write("Номер автомобиля: ");
                number_auto = int.Parse(Console.ReadLine());
                Auto auto = new Auto(driver, brand, model, color, number_auto);
                autos.Add(auto);
            }

            foreach(var item in autos)
            {
                item.ShowAuto();
            }
        }
    }
}