using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Series
    {
        public List<Function> functions = new List<Function>();

        public delegate void methodcont();
        public event methodcont two;

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

        public void printing()
        {
            for (int i = 0; i < functions.Count; i++)
            {
                Console.WriteLine(functions[i].ToString() );
            }
        }

        public bool equal(Function el)
        {
                for (int i = 0; i < functions.Count; i++)
                {
                    if (i == 1) two();

                    if (functions[i].Equals(el) == true)
                        {
                    Console.WriteLine(functions[i].GetHashCode() + " код равен " + el.GetHashCode());
                    return true;
                        }                 
                }
                return false;
        }

        public void plus(double x)
        {
            for (int i = 0; i < functions.Count; i++)
            {
                Console.WriteLine(functions[i].ToString() + " + "+x+" = "+functions[i].sum(x));
            }
        }

        public void minus(double x)
        {
            for (int i = 0; i < functions.Count; i++)
            {
                Console.WriteLine(functions[i].ToString() + " + " + x + " = " + functions[i].minus(x));
            }
        }

        public void mult(double x)
        {
            for (int i = 0; i < functions.Count; i++)
            {
                Console.WriteLine(functions[i].ToString() + " + " + x + " = " + functions[i].mult(x));
            }
        }

        public void div(double x)
        {
            for (int i = 0; i < functions.Count; i++)
            {
                Console.WriteLine(functions[i].ToString() + " + " + x + " = " + functions[i].div(x));
            }
        }

    }
}
