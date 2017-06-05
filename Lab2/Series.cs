﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Series
    {
        public List<Function> functions = new List<Function>();

        public void add(Function el)
        {
            if (el == null) return;
            functions.Add(el);
        }

        public void print(double x)
        {
            for (int i = 0; i < functions.Count; i++)
            {
                functions[i].setX(x);
                Console.WriteLine(functions[i].ToString() + "  Результат: " + functions[i].res());
            }
        }

        public bool equal(Function el)
        {
                for (int i = 0; i < functions.Count; i++)
                {
                if (functions[i].Equals(el) == true)
                {
                    return true;
                }
                    
                }
                return false;
        }
    }
}
