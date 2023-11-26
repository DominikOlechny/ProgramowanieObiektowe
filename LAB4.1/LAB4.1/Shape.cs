﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4._1
{
    internal class Shape
    {
        public double X { get; set; }
        public double Y { get; set; }  
        public double Height { get; set; }
        public double Width { get; set; }
        public virtual void Draw() { }

        public Shape(double x, double y, double height, double width)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }
    }
}
