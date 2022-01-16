using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    public abstract class AbstractBuilding : IBuilding
    {
        public abstract void ComputingArea();
        public abstract void GetNumberOfFloors();
        public abstract void GetNumberOfRooms();
        public abstract void PrintBuilding();
        public abstract void TotalCapacity();
                
    }
}
