using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    public class TheVolumeOfAGeometricFigure
    {
        public double volume;
        public TheVolumeOfAGeometricFigure(string[] args)

        {
            double volume(double l)
            {
                double vol = l * l * l;
                return vol;
            }


             void PrintVolumeOfACube()
            {
                Console.WriteLine("Cube Volume=" + volume(6));
            }
        }
    }

}
