using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    public class Room 
    { 
        public enum RoomType

        { 
        MeetingRoom,
        Kitchen,
        WorkingSpace,
        DepositSpace
    }
        public enum RoomAccessories
        {
            AerConditioner,
            TV
        }

    
        private double areea;
        string[] type;
        readonly string[] accesories;
        int capacity;
        int numberOfBeds;
        bool hasbalcony;

        public Room(double areea, string[] type, string[] accesories, int capacity, int numberOfBeds, bool hasbalcony)
        {
            this.areea = areea;
            this.type = type;
            this.accesories = accesories;
            this.capacity = capacity;
            this.numberOfBeds = numberOfBeds;
            this.hasbalcony = hasbalcony;
        }

        public Room(double areea, string type, string accessories, int capacity, int numberOfBeds, bool hasbalcony)
        {
            Areea = areea;
            Type = type;
            SetAccessories(accessories);
            Capacity = capacity;
            NumberOfBeds = numberOfBeds;
            HasBalcony = hasbalcony;
        }


      
        public double Areea { get=>areea; set=>areea=value; }
       public string Type { get ; set ; }

        private string accessories;

        public string GetAccessories()
        {
            return accessories;
        }

        public void SetAccessories(string value)
        {
            accessories = value;
        }

        public int Capacity { get; set; }
        public int NumberOfBeds { get; set; }
        public bool HasBalcony { get; set; }
        

        public string[] Types => new string[] { "MeetingRoom", "Kitchen", "WorkingSpace", "DepositSpace" };
        public string[] Accessories => new string[] { "Aer Conditioner", "TV" };

        public double Area { get; internal set; }

        public Room()
        {
            }

    }
}
