using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Parkings
    {
        List<Auto> autos;
        int parkingNumber = 0;
        public void Add(Auto auto)
        {
            if(auto == null)
            {
                autos = new List<Auto>();
            }
            autos.Add(auto);
        }

        public void Remove(Auto auto)
        {
            if(autos == null)
            {
                Console.WriteLine("Автомобиль выехал с парковки");
            }
            autos.Remove(auto);
        }
        
        public int ParkingNumber
        {
            get { return parkingNumber; } 
            set
            {
                if(value > 0 && value < 1000) parkingNumber = value;
            }
        }

        public void ShowParking()
        {
            foreach(Auto auto in autos)
            {
                auto.ShowAuto();
            }
        }
    }
}
