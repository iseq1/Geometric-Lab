using System;

namespace SW1stPart
{
    public class Rectangle : QGon
    {
        public Rectangle(Point2D[] p) : base(p)
        {
            if (p[0].x[0] == p[1].x[0] &&
                p[1].x[1] == p[2].x[1] &&
                p[2].x[0] == p[3].x[0] &&
                p[3].x[1] == p[0].x[1])
            {
                base.n = p.Length;
                base.p = p;
            }
            else
            {
                throw new AggregateException("Неверно заданная фигура.");
            }
        }

        public new double square()
        {
            return new Segment(p[0], p[1]).length() * new Segment(p[1], p[2]).length();
        }
    }
}