using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritance
{
public class rec : Shape, Cost
    {
        public rec(int a, int b) : base(a, b) { }

        public int getarea()
        { return height * width; }

        public int getcost(int a)
        { return a * 30; }
    }
}
