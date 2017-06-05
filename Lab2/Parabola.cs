using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Parabola : Function
    {
        private double x;
        private double a;
        private double b;
        private double c;
        private double y;

        public Parabola() { }

        public Parabola(double a, double b, double c)
        {
            setVlast(a, b, c);
        }

        public override void enter()
        {
            double a, b, c;
            Console.WriteLine("Введите a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            c = Convert.ToInt32(Console.ReadLine());
            setVlast(a, b, c);

        }

        public override void setVlast(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }

        public void obchisl()
        {
            y = (a * (x * x) + b * x + c);
        }

        public override void setX(double x)
        {
            this.x = x;
        }

        public override string ToString()
        {
            return "Parabola: a= " + a + ", b=" + b + ", c=" + c;
        }

        public override void print()
        {
            Console.WriteLine(ToString());

        }

        public override string res()
        {
            obchisl();
            return "y=" + y;
        }

        public static Parabola operator +(Parabola first, double sec)
        {
            Parabola res = new Parabola(first.a + sec, first.b + sec, first.c + sec);
            return res;
        }

        public static Parabola operator -(Parabola first, double sec)
        {
            Parabola res = new Parabola(first.a - sec, first.b - sec, first.c - sec);
            return res;
        }

        public static Parabola operator *(Parabola first, double sec)
        {
            Parabola res = new Parabola(first.a * sec, first.b * sec, first.c * sec);
            return res;
        }

        public static Parabola operator /(Parabola first, double sec)
        {
            Parabola res = new Parabola(first.a / sec, first.b / sec, first.c / sec);
            return res;
        }

        public static bool operator ==(Parabola first, Parabola sec)
        {
            if (first.a == sec.a && first.b == sec.b && first.c==sec.c)
                return true;
            return false;
        }

        public static bool operator !=(Parabola first, Parabola second)
        {
            if (first.a != second.a || first.b != second.b || first.c != second.c)
                return true;
            return false;
        }

        public override bool Equals(object obj)
        {
            Parabola el = obj as Parabola;
            if ((object)el == null)
            {
                return false;
            }
            if (this.a == el.a && this.b == el.b && this.c == el.c)
                return true;
            return false;
           
        }

        public bool Equals(Parabola el)
        {
            // Return true if the fields match:
            return base.Equals((Parabola)el) && a == el.a && b == el.b && c == el.c;
        }

        public override int GetHashCode()
        {
            return a.GetHashCode() ^ b.GetHashCode()^c.GetHashCode();
        }


    }
}
