using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class BuildingExe
    {
       
        public static void Main(string[] args)
        {
            {
                Building bld = new Building(20.0,5,5,305);
                try
                {
                    bld.ComputingArea();
                    bld.GetNumberOfFloors();
                    bld.GetNumberOfRooms();
                    bld.TotalCapacity();
                    bld.PrintBuilding();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There is an exception!!!",ex.Message );
                }
               
                }
            }

        }
    }


