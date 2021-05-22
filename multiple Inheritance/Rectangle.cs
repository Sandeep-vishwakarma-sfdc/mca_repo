using System;
using System.Collections.Generic;
using System.Text;

namespace multiple_Inheritance
{
    public class Rectangle:Shape,Cost
    {
        public Rectangle(int a,int b):base(a,b)
        {  
        }
        public int getArea()
        {
            return height * width;
        }
        public int getCost(int a)
        {
            return a * 30;
        }
    }
}
