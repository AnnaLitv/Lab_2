﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Ellipse : Function
    {
        private double x;
        private double a;
        private double b;
        private int key = 2;
        private double[] y = new double[2];


        public Ellipse()
        {
        }

        public Ellipse(double a, double b)
        {
            setVlast(a, b, 0);
        }

        public override void enter()
        {
            double x, a, b;
            Console.WriteLine("Введите х: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            setVlast(a, b, 0);

        }

        public override void setVlast(double a, double b, double c)
        {
            this.a = a;
            this.b = b;

        }

        public void obchisl()
        {
            y[0] = Math.Sqrt((1 - ((x * x) / (a * a))) * (b * b));
            y[1] = -Math.Sqrt((1 - ((x * x) / (a * a))) * (b * b));
        }

        public override string ToString()
        {
            return "Ellipse: a= " + a + ", b=" + b;
        }

        public override void print()
        {
            Console.WriteLine(ToString());

        }

        public override void setX(double x)
        {
            this.x = x;
        }

        public override string res()
        {
            obchisl();
            return "y1=" + y[0] + ", y2=" + y[1];
        }

        public override bool Equals(object obj)
        {
            Ellipse el = obj as Ellipse;
            if ((object)el == null)
            {
                return false;
            }
            // Return true if the fields match:
            return base.Equals(obj) && a == el.a && b == el.b;
        }

        public bool Equals(Ellipse el)
        {
            // Return true if the fields match:
            return base.Equals((Ellipse)el) && a == el.a && b == el.b;
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