using System;

namespace SW1stPart
{
    public class NGon //: IShape, IPolyPoint
    {
        protected internal int n;
        protected internal Point2D[] p;

        public NGon(Point2D[] p)
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

        public double square()
        {
            double square = 0;
            for (int i = 0; i < getN(); i++)
            {
                if (i<getN()-1)
                {
                    square += (p[i + 1].x[0] - p[i].x[0]) * (p[i].x[1] + p[i+1].x[1]);
                }
                else
                {
                    square += (p[0].x[0] - p[i].x[0]) * (p[i].x[1] + p[0].x[1]);
                }
            }
            return square / 2;
        }

        public double length()
        {
            double len = new Polyline(p).length();
            len += new Segment(p[getN() - 1], p[0]).length();
            return len;
        }

        public NGon shift(Point2D a)
        {
            return new NGon(new Polyline(p).shift(a).getP());
        }

        public NGon rot(double phi)
        {
            return new NGon(new Polyline(p).rot(phi).getP());
        }

        public NGon symAxis(int i)
        {
            return new NGon(new Polyline(p).symAxis(i).getP());
        }

        public bool cross(IShape i)
        {
            if (i is NGon)
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
            string str = "NGon: (";
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