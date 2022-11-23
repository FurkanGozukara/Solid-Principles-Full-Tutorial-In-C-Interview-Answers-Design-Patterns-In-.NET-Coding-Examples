using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_design_principles
{
    internal class ProperLiskovPrinciple
    {
        public abstract class AbstractClassWithBodyHavingMethod
        {
            public virtual string GetColor()
            {
                return "White";
            }
        }

        public abstract class Fruit
        {
            public abstract string GetColor();
        }
        public class Apple : Fruit
        {
            public override string GetColor()
            {
                return "Red";
            }
        }
        public class Orange : Fruit
        {
            public override string GetColor()
            {
                return "Orange";
            }
        }
    }
}
