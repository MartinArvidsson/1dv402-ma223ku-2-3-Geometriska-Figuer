using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    public class Rectangle : Shape
    {
       public override double Area //Anger en Area för en rektangel
        {
           get
            {
                return Width * Length;
            }
        }
        public override double Perimeter // Anger en Omkrets för en rektangel
       {
            get
           {
               return Width * 2 + Length * 2;
           }
       }

        public Rectangle(double length, double width)
            : base(length, Width) { }
    }
}
