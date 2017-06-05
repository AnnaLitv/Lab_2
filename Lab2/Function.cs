using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    abstract class Function
    {
        public virtual void enter()
        {

        }

        public virtual void print()
        {

        }

        public virtual void setVlast(double a, double b, double c)
        {

        }

        public virtual void setX(double x)
        {

        }

        public virtual string res()
        {
            return null;
        }

        public virtual bool Equals()
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public virtual string sum(double x)
        {
            return null;
        }

        public virtual string minus(double x)
        {
            return null;
        }

        public virtual string mult(double x)
        {
            return null;
        }

        public virtual string div(double x)
        {
            return null;
        }
    }
}
