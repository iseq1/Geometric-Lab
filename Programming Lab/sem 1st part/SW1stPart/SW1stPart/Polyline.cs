using System;

namespace SW1stPart
{
    public class Polyline : OpenFigure//, IPolyPoint
    {
        private int n;
        private Point2D[] p;

        public Polyline(Point2D[] p)
        {
            this.n = p.Length;
            this.p = p;
        }

        public int getN()
        {
            return n;
        }

        public Point2D[] getP()
        {
            return p;
        }

        public Point2D getP(int i)
        {
            if ((i >= 0) && (i < p.Length)){
                return p[i];
            }
            else
            {
                throw new ArgumentException("Индекс за пределами массива.");
            }
        }

        public void setP(Point2D[] p)
        {
            this.p = p;
        }

        public void setP(Point2D[] p, int i)
        {
            if ((i >= 0) && (i < this.p.Length))
            {
                this.p[i] = p[i];
            }
            else
            {
                throw new ArgumentException("Индекс за пределами массива.");
            }
        }

        public double length()
        {
            if (p.Length < 2)
            {
                return 0;
            }
            else
            {
                double length = 0;
                for (int i = 0; i < p.Length - 1; i++)
                {
                    Segment pl = new Segment(p[i], p[i + 1]);
                    length += pl.length();
                }
                return length;
            }
        }

        public Polyline shift(Point2D a)
        {
            //тут 2 способа: либо по точкам сдвигать(Point!=Point2D maybe error), либо по отрезкам(нужно запоминать лишь start)
            Point2D[] plshift = new Point2D[getN()];
            for (int i = 0; i < p.Length; i++)
            {
                plshift[i] = new Point2D(p[i].add(a).x);
            }
            return new Polyline(plshift);
        }

        public Polyline rot(double phi)
        {
            Point2D[] plshift = new Point2D[getN()];
            for (int i = 0; i < p.Length; i++)
            {
                plshift[i] = new Point2D(p[i].rot(phi).x);
            }
            return new Polyline(plshift);
        }

        public Polyline symAxis(int i)
        {
            Point2D[] newp = new Point2D[getN()];
            for (int j = 0; j < getN(); j++)
            {
                newp[j] = new Point2D(p[j].symAxis(i).x);
            }
            return new Polyline(newp);
        }

        public bool cross(IShape i)
        {
            if (i is Polyline)
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
            string str = "Polyline: (";
            for (int i = 0; i < getN(); i++)
            {
                str += string.Format("point({0})=[{1}], ", string.Join(",", i+1), string.Join("; ", p[i].x));
            }
            str = str.Substring(0, str.Length - 2);
            str = str.Insert(str.Length, ")");
            return str;
        }

    }
}