﻿using System;


namespace BT_Auto_2021_Programming

{
    class Circle : Shape
    {
        double radius;
        //const double PI = 3.1415;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle()
        {
            this.radius = 0;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public void PrintCircle()
        {
            Console.WriteLine("Circle with radius {0} has the area {1}", radius, GetArea());
        }

        public override void Draw()
        {
            Console.WriteLine("We are drawing a circle with radius {0}", radius);

        }

        public override string ToString()
        {
            return "This is a circle with radius " + radius;
        }
    }
}