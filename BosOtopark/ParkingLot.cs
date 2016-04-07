using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BosOtopark
{
    public class ParkingLot
    {
        private List<Araba> car = new List<Araba>();
        private int parkingLotSize;
        private string parkingLotName;
        
        public int ParkingLotSize
        {
            get { return parkingLotSize; }
            set { parkingLotSize = value; }
        }
        public string ParkingLotName
        {
            get { return parkingLotName; }
            set { parkingLotName = value; }
        }
        
        public ParkingLot()
        {
            car.Capacity = parkingLotSize;
        }
        public ParkingLot(string PlName, int PlSize)
        {
            ParkingLotName = PlName;
            ParkingLotSize = PlSize;
            car.Capacity = parkingLotSize;
        }
        public void InsertCarToTheParkingLot(ref Araba a)
        {
            if (car.Capacity > car.Count && a != null)
            {
                car.Add(a);
                Console.WriteLine("there is/are {0} empty place(s)", car.Capacity - car.Count);
                a = null;
            }
            else
            {
                Console.WriteLine("The parking lot is full");
            }
        }
    }
    public class ParkingLotCollection
    {
        List<ParkingLot> parkingLots = new List<ParkingLot>();

        public List<ParkingLot> ParkingLots
        {
            get { return parkingLots; }
            set { parkingLots = value; }
        }

        public ParkingLot this[string _parkingLotName]
        {
            get
            {
                if (parkingLots.Count != 0)
                {
                    return parkingLots.Find(x => x.ParkingLotName == _parkingLotName);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
