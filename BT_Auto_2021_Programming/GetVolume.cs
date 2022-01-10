using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    public class GetVolume
    {

        public double GetVolumec(double l)
        {
            double GetVolumes = l * l * l;
            return GetVolumes;
        }
        public double GetVolumec(int r)
        {
            double GetVolumes = (4 / 3.0) * Math.PI * r * r * r;
            return GetVolumes;
        }
        public double GetVolumec(double h, double l) // Aria bazei l*l
        {
            double GetVolumes = (1 / 3.0) * l * l * h;
            return GetVolumes;
        }

        public double GetVolumec(double h, int r)
        {
            double GetVolumes = Math.PI * Math.Pow(r, 2) * h;
            return GetVolumes;
        }

        public double GetVolumec(float r, double R)
        {
            double GetVolumes = 2 * Math.PI * Math.PI * Math.Pow(r,2) * R;
            return GetVolumes;
        }

        //public static void GetVolume(string []args)

       // {
           // GetVolume a = new GetVolume();
        //Console.WriteLine("Cube Volume=" + a.GetVolumec(10.0));
            //Console.WriteLine("Sphere Volume=" + a.GetVolumec(9));
           // Console.WriteLine("Pyramid Volume=" + a.GetVolumec(6.0,5));
            //Console.WriteLine("Cylinder Volume=" + a.GetVolumec(9.0,4));
           // Console.WriteLine("Torus Volume=" + a.GetVolumec(5.0,8));


        }
}

 
