using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{

    public class Building : AbstractBuilding


    {
        double area;
        int totalNumberOfFloors;
        int totalNumberOfRooms;
        int totalCapacity;
        const int MAX_CAPACITY = 300;

        public Building(double area, int totalNumberOfFloors, int totalNumberOfRooms, int totalCapacity)
        {
            this.area = area;
            this.totalNumberOfFloors = totalNumberOfFloors;
            this.totalNumberOfRooms = totalNumberOfRooms;
            this.totalCapacity = totalCapacity;
        }

       
        List<Floor> floors = new List<Floor>();



        public override void ComputingArea()
        {
            double area = 0;
            foreach (Floor f in floors)
            {
                foreach (Room r in f.Rooms)
                {
                    area += r.Area;
                }
            }
        }

        public override void GetNumberOfFloors()
        {
            //return " Total number of floors" + floors.Count;
        }

        public override void GetNumberOfRooms()
        {
            int totalNumberOfRooms = 0;
            foreach (Floor f in floors)
            {
                totalNumberOfRooms *= totalNumberOfFloors;
            }
        }

        public override void TotalCapacity()
        {
            int capacity = 0;
            foreach (Floor f in floors)
            {
                for (int i = 0; i < f.Rooms.Count; i++)
                {
                    Room r = f.Rooms[i];
                    capacity += r.Capacity;
                }
                if (capacity > MAX_CAPACITY)
                {
                    Console.WriteLine("The maximum capacity of the building is exceeded ");
                }
            }
        }

        public void PrintBuilding(Building building)
        {

            building.GetNumberOfRooms();
            building.ComputingArea();
            building.TotalCapacity();
            building.GetNumberOfFloors();

        }

        public override void PrintBuilding()
        {
            Console.WriteLine("In this building we have {0} rooms,whith total area {1},total capacity {2},floor count {3} ", totalNumberOfRooms,area, totalCapacity, totalNumberOfFloors);
        }

        public Building(double area, int totalNumberOfFloors, int totalNumberOfRooms, int totalCapacity, List<Floor> floors) : this(area, totalNumberOfFloors, totalNumberOfRooms, totalCapacity)
        {
            this.floors = floors;
        }
            }
}
    
       