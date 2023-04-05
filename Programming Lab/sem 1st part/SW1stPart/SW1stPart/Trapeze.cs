using System;
using System.Runtime.InteropServices;

namespace SW1stPart
{
    public class Trapeze : QGon
    {
        public Trapeze(Point2D[] p) : base(p)
        {
            if (p[0].x[1] == p[3].x[1] &&
                p[1].x[1] == p[2].x[1])
            {
                base.n = p.Length;
                base.p = p;
            }
            else
            {
                throw new ArgumentException("неверно заданная фигура");
            }
        }
        

        public new double square()
        {
            //работает только если (p[0]; p[1]) и (p[2]; p[3]) = боковые линии
            double[] forH = {p[1].x[0], p[0].x[1] };
            double h = Math.Sqrt(Math.Pow(new Segment(p[0],p[1]).length(),2) - Math.Pow(new Segment(p[0], new Point2D(forH)).length(),2));
            return ((new Segment(p[1], p[2]).length() + new Segment(p[0], p[3]).length())*h)/2;
        }
    }
}