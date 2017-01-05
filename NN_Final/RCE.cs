using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NN_Final
{
    /// <summary></summary>
    public class RCE
    {
        public Input X;
        public List<double> lamda_j;
        public List<InternalNode> W;
        const int TestNum = 100;
        const double INIT_RADIUS = 700.0/2.0;

        public string log="";
        public RCE(Input input)
        {
            X = input;
            W = new List<InternalNode>();
            lamda_j = new List<double>();
        }

        public void Compute()
        {
            W.Clear();
            lamda_j.Clear();

            lamda_j.Add(INIT_RADIUS);
            InternalNode init_w = new InternalNode(X.inputs[0].Class, X.inputs[0].X, X.inputs[0].Y);
            W.Add(init_w);

            for (int k = 0; k < TestNum; ++k)
            {
                for( int i=0; i <X.inputs.Count;++i )
                {
                    LF_Pair pair = X.inputs[i];
                    for(int j=0; j<W.Count;++j)
                    {
                        double Sj = ComputeSj(i, j);
                        int output = 1;
                        int desire = 1;
                        
                        if (Sj < lamda_j[j])
                        {
                            if (W[j].Class == 0)
                                W[j].Class = pair.Class;
                            output = 1;
                        }
                        else
                            output = 0;

                        //desire =(W[j].Class == pair.Class)? 1 : 0;
                        
                        //雖然在圈外,必須新增一個圈圈給他
                        if (output == 0 && W[j].Class != pair.Class )
                        {
                            desire = 1;
                            //log += String.Format("pos:({0},{1}) r:{2:0.00}\n", (int)W[j].w[0], (int)W[j].w[1], lamda_j[j]);
                        }
                        //顏色相同
                        else if (W[j].Class == pair.Class)
                        {
                            desire = 1;
                        }
                        else
                            desire = 0;

                        if (output - desire == 1)
                        {
                            lamda_j[j] = Sj - 1;
                        }
                        if(output - desire == -1)
                            if (NotInsideCircle(pair.X,pair.Y))
                            {
                                InternalNode w = new InternalNode(pair.Class, pair.X, pair.Y);                                
                                W.Add(w);
                                lamda_j.Add(INIT_RADIUS);
                            }
                       // log += String.Format("pos:({0},{1}) r:{2:0.00}\n", (int)W[j].w[0], (int)W[j].w[1], lamda_j[j]);
                    }
                }
            }
            
        }

        private bool NotInsideCircle(double input_X,double input_Y)
        {
            for(int j =0 ;j<W.Count;j++)
            {
                double X = W[j].w[0]; double Y = W[j].w[1];
                double r = lamda_j[j];

                double len = Math.Sqrt ((X-input_X)*(X-input_X) +
                                       (Y-input_Y)*(Y-input_Y));

                if( len<=r)
                    return false;
            }
            return true;
        }

        private double ComputeSj(int i,int j)
        {
            return Math.Sqrt( (Math.Pow((W[j].w[0] - X.inputs[i].X), 2.0) + 
                               Math.Pow((W[j].w[1] - X.inputs[i].Y), 2.0)) );
        }
    }

    public class InternalNode
    {
        public List<double> w;
        public int Class;
        const int Size = 700;
        public InternalNode(int Class,double x,double y)
        {
            w = new List<double>();
            this.Class = Class;
            
            w.Add(x);
            w.Add(y);
        }
    }
}
