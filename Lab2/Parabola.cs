﻿using System;
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
        private int key = 3;

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

        public override bool Equals(object obj)
        {
            Parabola el = obj as Parabola;
            if ((object)el == null)
            {
                return false;
            }
            // Return true if the fields match:
            return base.Equals(obj) && a == el.a && b == el.b && c == el.c;
        }

        public bool Equals(Parabola el)
        {
            // Return true if the fields match:
            return base.Equals((Parabola)el) && a == el.a && b == el.b && c == el.c;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override int getKey(int key)
        {
            return key;
        }
    }
}