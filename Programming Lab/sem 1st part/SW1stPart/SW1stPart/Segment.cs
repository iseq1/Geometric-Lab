using System;
using System.IO;

namespace SW1stPart
{
    public class Segment : OpenFigure
    {
        private Point2D start;
        private Point2D finish;

        public Segment(Point2D s, Point2D f)
        {
            start = s;
            finish = f;
        }

        public Point2D getStart()
        {
            return start;
        }

        public void setStart(Point2D a)
        {
            this.start = a;
        }

        public Point2D getFinish()
        {
            return finish;
        }

        public void setFinish(Point2D a)
        {
            this.finish = a;
        }

        public double length()
        {
            // ((x_2 - x_1)^2 + (y_2 - y_1)^2)^(1/2)
            return Math.Sqrt(Math.Pow(finish.x[0] - start.x[0], 2) + Math.Pow(finish.x[1] - start.x[1], 2));
        }
        
        public Segment shift(Point2D a)
        {
            return new Segment(new Point2D(start.add(a).x), new Point2D(finish.add(a).x));
        }
        
        public Segment rot(double phi)
        {
            return new Segment(start.rot(phi), finish.rot(phi));
        }
        
        public Segment symAxis(int i)
        {
            return new Segment(new Point2D(start.symAxis(i).x), new Point2D(finish.symAxis(i).x));
        }
        
        public bool cross(IShape i)
        {
            if (i is Segment)
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
            return string.Format("Segment: (start=[{0}], finish=[{1}])", string.Join("; ", start.x), string.Join("; ", finish.x));
        }
        
        
    }
}