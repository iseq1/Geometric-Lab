using System;

namespace SW1stPart
{
    public class TGon : NGon
    {
        public TGon(Point2D[] p) : base(p)
        {
            base.n = p.Length;
            base.p = p;
        }
        
        public new double square()
        {
            double semiPerimeter = new NGon(p).length()/2;
            return Math.Sqrt(semiPerimeter*
                             (semiPerimeter - (new Segment(p[0], p[1]).length()))*
                             (semiPerimeter - (new Segment(p[1], p[2]).length()))*
                             (semiPerimeter - (new Segment(p[2], p[0]).length())));
        }
    }
}