using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NN_Final
{

    public class Input
    {
        public List<LF_Pair> inputs;
        public Input()
        {
            inputs = new List<LF_Pair>();
        }
        public void Add(int Class,double X,double Y)
        {
            LF_Pair p = new LF_Pair(Class, X, Y);
            inputs.Add(p);
        }
        public void Clear()
        {
            inputs.Clear();
        }
    }
    public class LF_Pair
    {
        public int Class;
        public double X, Y;
        public LF_Pair(int Class,double X,double Y)
        {
            this.Class = Class;
            this.X = X;
            this.Y = Y;
        }
    }
}
