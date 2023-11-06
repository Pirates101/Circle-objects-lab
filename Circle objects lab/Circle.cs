using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_objects_lab
{
    public class Circle
    {
        

        public Circle(double radius)
        {
            Radius = radius;
        }
        private double Radius { get; set; }
        public double Diameter => 2 * Radius;

        public double Circumference => 2 * Radius * System.Math.PI;

        public double Area => System.Math.PI * (Radius * Radius);

        public void Grow()
        {
            Radius = Radius * 2;
        }

        public double GetRadius() 
        {
            return Radius; 
        }

    }
}
