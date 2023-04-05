using System;

namespace SW1stPart
{
    public abstract class OpenFigure 
    {
        public double square()
        {
            return 0;
        }

        public double length()
        {
            throw new NotImplementedException();
        }

        public bool cross(IShape i)
        {
            throw new NotImplementedException();
        }

        public IMoveable shift(Point2D a)
        {
            throw new NotImplementedException();
        }

        public IMoveable rot(double phi)
        {
            throw new NotImplementedException();
        }

        public IMoveable symAxis(int i)
        {
            throw new NotImplementedException();
        }
    }
}