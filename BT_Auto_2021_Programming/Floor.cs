using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    public class Floor 
    {
            List<Room> rooms = new List<Room>();

        public Floor(List<Room> rooms) => this.rooms = rooms;

        public Floor()
        {
        }

        internal List<Room> Rooms { get => rooms; set => rooms = value; }
    }
}
