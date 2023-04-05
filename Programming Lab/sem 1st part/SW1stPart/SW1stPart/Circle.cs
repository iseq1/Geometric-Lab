using System;
using System.Text.RegularExpressions;

namespace SW1stPart
{
    public class Circle// : IMoveable
    {
        private Point2D p;
        private double r;

        public Circle(Point2D p, double r)
        {
            if (r > 0) 
            {
                this.p = p;
                this.r = r;
            }
            else
            {
                throw new Exception("Радиус более нуля!");
            }
        }

        public Point2D getP()
        {
            return p;
        }

        public void setP(Point2D p)
        {
            this.p = p;
        }

        public double getR()
        {
            return r;
        }

        public void setR(double r)
        {
            this.r = r;
        }

        public double square()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public double length()
        {
            return Math.PI * 2 * r;
        }

        public Circle shift(Point2D a)
        {
            return new Circle(new Point2D(p.add(a).x),r);
        }

        public Circle rot(double phi)
        {
            return new Circle(new Point2D(p.rot(phi).x), r);
        }

        public Circle symAxis(int i)
        {
            return new Circle(new Point2D(p.symAxis(i).x), r);
        }

        public bool cross(IShape i)
        {
            if (i is Circle)
            {
                // чето надо сделать тут и в самом интерфейсе
                return true;
            }
            else
            {
                throw new ArgumentException("Неверный тип объекта");
            } 
        }
        
        public String toString()
        {
            return string.Format("Circle: (center=[{0}], radius={1})", string.Join("; ", p.x), string.Join("; ", r));
        } 
        
    }
}