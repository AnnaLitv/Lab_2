using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Hiperbola:Function
    {
        private double x;
        private double a;
        private double b;
        private double[] y = new double[2];

        public Hiperbola() { }

        public Hiperbola(double a, double b)
        {
            setVlast(a, b, 0);
        }

        public override void enter()
        {
            double x, a, b;
            base.enter();
            Console.WriteLine("Введите х: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToInt32(Console.ReadLine());
            setVlast(a, b, 0);

        }
        public override void setVlast(double a, double b, double c)
        {
            this.a = a;
            this.b = b;

        }
        public override void setX(double x)
        {
            this.x = x;
        }
        public void obchisl()
        {
            y[0] = Math.Sqrt((1 - ((x * x) / (a * a))) * (-(b * b)));
            y[1] = -Math.Sqrt((1 - ((x * x) / (a * a))) * (-(b * b)));
        }
        public override string ToString()
        {
            return "Hiperbola: a= " + a + ", b=" + b;
        }

        public override void print()
        {
            Console.WriteLine(ToString());

        }
        public override string res()
        {
            obchisl();
            return "y1="+y[0]+", y2="+y[1];
        }
    }
}
