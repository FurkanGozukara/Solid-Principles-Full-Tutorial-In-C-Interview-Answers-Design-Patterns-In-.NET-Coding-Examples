using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_design_principles
{
    internal class LiskovViolation
    {
        public class Apple
        {
            public virtual string GetColor()
            {
                return "Red";
            }
        }
        public class Orange : Apple
        {
            public override string GetColor()
            {
                return "Orange";
            }
        }
    }
}
