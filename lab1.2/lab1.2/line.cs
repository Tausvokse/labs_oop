using System;

namespace lab1._1_1
{
    public class Line
    {
        public struct Point
        {
            public double x;
            public double y;
        };

        public struct Linia
        {
            public Point start;
            public Point end;
        };

        public float xA;
        public float yA;
        public float xB;
        public float yB;
        public int dia;
        public char choice;
        public bool oper4;

        public float dovzhina()
        {
            return (float)Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
        }

        public float kyt()
        {
            float vert = yB - yA;
            float hor = xB - xA;
            return (float)Math.Round(Math.Atan2(vert, hor) * (180 / Math.PI), 2);
        }

        public static void Initial(Linia[] N)
        {
            for (int i = 0; i < 5; i++)
            {
                N[i].start.x = i;
                N[i].start.y = i;
                N[i].end.x = i + 1;
                N[i].end.y = i + 1;
            }
        }
        public static void Mirror(Linia[] N) {
            for (int i = 0; i < 5; i++)
            {
                N[10 - i] = N[i];
            }
        }
    } 
}