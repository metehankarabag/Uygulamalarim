using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BosOtopark
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingLotCollection pCollection = new ParkingLotCollection();
            while (true)
            {
                Console.WriteLine("Do you want to add a parking lot? -y or -n");
                string yesOrNo = Console.ReadLine();
                if (yesOrNo == "y")
                {
                    Console.WriteLine("Enter Parking lot name:");
                    string parkingLotName = Console.ReadLine();
                    Console.WriteLine("Ender Parking lot capacity:");
                    int parkingLotCapacity = Convert.ToInt32(Console.ReadLine());
                    pCollection.ParkingLots.Add(new ParkingLot(parkingLotName, parkingLotCapacity));
                }
                else if (yesOrNo == "n" && pCollection.ParkingLots.Count == 0)
                {
                    Console.WriteLine("Ther is no parking lots");
                    continue;
                }

                Console.WriteLine("Do you want to park? -y or -n");
                yesOrNo = Console.ReadLine();
                if (yesOrNo == "y")
                {
                    string question = "Which parking lot do you want to park? - ";
                    foreach (ParkingLot item in pCollection.ParkingLots)
                    {
                        question += item.ParkingLotName + " - ";
                    }
                    Console.WriteLine(question);
                    string parkingLot = Console.ReadLine();
                    ParkingLot p = pCollection[parkingLot];
                    if (p != null)
                    {
                        Araba a = new Araba();
                        p.InsertCarToTheParkingLot(ref a);
                    }
                    else
                        Console.WriteLine("Ther is no parking lot with name = {0} ", parkingLot);

                }
            }
        }
    }
}
