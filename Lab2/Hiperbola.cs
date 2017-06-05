using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Hiperbola : Function
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
            return "y1=" + y[0] + ", y2=" + y[1];
        }

        public static Hiperbola operator +(Hiperbola first, double sec)
        {
            Hiperbola res = new Hiperbola(first.a + sec, first.b + sec);
            return res;
        }

        public static Hiperbola operator -(Hiperbola first, double sec)
        {
            Hiperbola res = new Hiperbola(first.a - sec, first.b - sec);
            return res;
        }

        public static Hiperbola operator *(Hiperbola first, double sec)
        {
            Hiperbola res = new Hiperbola(first.a * sec, first.b * sec);
            return res;
        }

        public static Hiperbola operator /(Hiperbola first, double sec)
        {
            Hiperbola res = new Hiperbola(first.a / sec, first.b / sec);
            return res;
        }

        public static bool operator == (Hiperbola first, Hiperbola sec)
        {
            if (first.a==sec.a && first.b==sec.b)
                return true;
            return false;
        }

        public static bool operator !=(Hiperbola first, Hiperbola second)
        {
            if (first.a != second.a || first.b != second.b)
                return true;
            return false;
        }

        public override bool Equals(object obj)
        {
            Hiperbola el = obj as Hiperbola;
            if ((object)el == null)
            {
                return false;
            }
            if (this.a == el.a && this.b == el.b)
                return true;
            return false;
        }

        public bool Equals(Hiperbola el)
        {
            // Return true if the fields match:
            return base.Equals((Hiperbola)el) && a == el.a && b == el.b;
        }

        public override int GetHashCode()
        {
            return a.GetHashCode() ^ b.GetHashCode();
        }

        public override string sum(double x)
        {
            Hiperbola hi = new Hiperbola(this.a, this.b);
            Hiperbola hip = new Hiperbola();
            hip = hi + x; 
            return "Hiperbola: a= "+hip.a+", b= "+hip.b;
        }



    }
}
