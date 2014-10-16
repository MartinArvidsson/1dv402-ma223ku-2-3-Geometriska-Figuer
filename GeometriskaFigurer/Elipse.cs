using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    public class Elipse :  Shape
    {
        public override double Area //ska ange en area för en elipse.
        {
            get
            {
                return Math.PI * (Length / 2) * (Width / 2);
            }
        }

        public override double Perimeter // Ska ange en omkrets för en elipse.
        {
            get
            {
                return Math.PI * Math.Sqrt(2 * (Length / 2) * (Length / 2) + 2 * (Width / 2) * (Width / 2));
            }
        }
        // Genom basklassen ger dom nya värderna för längd o höjd
        public Elipse(double length, double width)
            : base(length, width) { }
    }
}
