using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    public abstract class Shape
    {
        private double _length;
        private double _Width;

        public abstract double Area
        {
            get;
        }
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _length = value;
            }
        }
        public abstract double Perimeter
        {
            get;
        }


        public double Width
        {
            get
            {
                return _Width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _Width = value;
            }
        }
        protected Shape (double length, double width)
        {
            _length = length;
            _Width = width;
        }

        public override string ToString()
        {
            return string.Format("\nLängd :{0, 14:} \nBredd :{1, 14:} \nOmkretsen:{2, 14:.0} \nArean :{3, 14:.0}", Length, Width, Perimeter, Area);
        }
    }
    enum ShapeType
    {
        Rectangle, Elipse
    }
}
