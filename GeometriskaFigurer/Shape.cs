using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    public abstract class Shape
    {
        private double _length;  //Privata variablar som kan hålla decimaltal
        private double _width;
        

        public abstract double Area
        {
            get;
        }
        public double Length //Här kollas att längden är >0
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


        public double Width //här kollas så att bredden är >0
        {
            get
            {
                return _width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _width = value;
            }
        }
        protected Shape (double length, double width) //Efter att både bredd o längd har kollats och fått värden anges dom till konstruktorns parametrar.
        {
            _length = length;
            _width = width;
        }

        public override string ToString() //Retunerar en sträng med värdet, separerar och fixar med raderna också.
        {
            return string.Format("\nLängd    :{0, 14:} \nBredd    :{1, 14:} \nOmkretsen:{2, 14:.0} \nArean    :{3, 14:.0}", Length, Width, Perimeter, Area);
        }
    }
    enum ShapeType
    {
        Rectangle, Elipse
    }
}
