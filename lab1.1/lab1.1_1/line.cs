using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._1_1
{
    class Line
    {
        private float xA, yA, xB, yB;

        public Line(float xa, float ya, float xb, float yb)
        {
            this.xA = xa;
            this.yA = ya;
            this.xB = xb;
            this.yB = yb;
        }

        public float dovzhina()
        {
             return (float)Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
        }

        public float kyt()
        {
            float vert = yB - yA;
            float hor = xB - xA;
            return (float)Math.Round(Math.Atan2(vert, hor)*(180/Math.PI), 2);
        }
    }
}
