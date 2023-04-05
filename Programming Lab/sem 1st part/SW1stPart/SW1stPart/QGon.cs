using System;

namespace SW1stPart
{
    public class QGon : NGon
    {
        public QGon(Point2D[] p) : base(p)
        {
            base.n = p.Length;
            base.p = p;
        }

        public new double square()
        {
            //по координатам
            return Math.Abs((p[0].x[0] - p[1].x[0])*(p[0].x[1] + p[1].x[1]) + 
                            (p[1].x[0] - p[2].x[0])*(p[1].x[1] + p[2].x[1]) +
                            (p[2].x[0] - p[3].x[0])*(p[2].x[1] + p[3].x[1]) +
                            (p[3].x[0] - p[0].x[0])*(p[3].x[1] + p[0].x[1]))/2;
        }
    }
}