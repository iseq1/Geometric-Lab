using System;
using System.Collections.Generic;

namespace SW1stPart
{
    internal class Program
    {
        /*
        Общие замечания:
        1. Нужно переопределить toString для всех классов, в которых указан, чтобы 
            выводил все внутренние параметры.
        2. В конструкторах необходимо выполнить проверку на корректность 
            входных данных (Количество координат совпадает с указанной 
            размерностью, в прямоугольнике смежные стороны под прямым углом, 
            …) через соответствующие исключения(Exception).
        3. В схемах, представленных ниже подчёркнуты статические функции (static).
        4. Для каждого внутреннего параметра должен быть реализован get-метод.
        5. Для каждого внутреннего параметра, кроме количества точек и 
            размерности пространства, должен быть реализован set-метод.
        6. Если внутренний параметр массив, то get/set-методы должны быть 
            реализованы в двух вариантах:
            a. Работа с цельным массивом.
            b. Работа с элементом по номеру.
                
        */
        public static void Main(string[] args)
        {
            //надо подумать как get с массиввами правильно сделать.
            double[] x = {2, 2};
            double[] x1 = {2, 6};
            double[] x2 = {6, 6};
            double[] x3 = {6, 2};
            double[] x4 = {-7, 7};
            double[] x5 = {-7, -2};
            double[] x6 = {0, -2};

            Point2D pt = new Point2D(x);
            Point2D pt1 = new Point2D(x1);
            Point2D pt2 = new Point2D(x2);
            Point2D pt3 = new Point2D(x3);
            Point2D pt4 = new Point2D(x4);
            Point2D pt5 = new Point2D(x5);
            Point2D pt6 = new Point2D(x6);

            Segment s = new Segment(pt, pt1);
            
            Console.WriteLine(s.shift(pt1).toString());

            
            Point2D[] pline = { pt, pt1, pt2, pt3 };
            Polyline pl = new Polyline(pline);

            Circle cr = new Circle(pt,5);
            
            Console.WriteLine(cr.shift(pt1).toString());

            QGon ng = new QGon(pline);
            Rectangle rec = new Rectangle(pline);

            Console.WriteLine(rec.toString());

            Console.WriteLine(ng.square()); 
            
            // 

            List<IShape> list = new List<IShape>();
            


        }
    }
}