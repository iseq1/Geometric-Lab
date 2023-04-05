using System;


namespace SW1stPart
{
    public class Point2D : Point
    {
       
        public Point2D() : base(dim:2)
        {
            x = new double[dim];
        }
 
        public Point2D(double[] x) : base(dim:2) 
        {
            if (dim <= 0) {
                throw new ArgumentException("Размерность пространтсва должна быть более нуля.");
            }
            if (x.Length != dim) {
                throw new ArgumentException("Количество координат не соответствует размерности.");
            }
            this.x = x;
        }

        public static Point2D rot(Point2D p, double phi)
        {
            return p.rot(phi);
        }

        public Point2D rot(double phi)
        {
            double sinPhi = Math.Sin(phi);
            double cosPhi = Math.Cos(phi);
            double newX = Math.Round(x[0] * cosPhi - x[1] * sinPhi, 2);
            double newY = Math.Round(x[0] * sinPhi + x[1] * cosPhi, 2);
            double[] mas = {newX, newY}; 
            return new Point2D(mas);
        }
    }
}