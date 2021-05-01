using System;

namespace GaussElimination
{
    class Program
    {
        /*static void Main(string[] args)
        {
            NewMethod();
        }*/
        public double[,] matris;
        public Program(double a00,double a01,double a02,
                       double a10,double a11,double a12,
                       double a20,double a21,double a22,
                       double b0,double b1,double b2)
        {
            matris = new double[,] {
                { a00,a01,a02 ,b0 },
                { a10,a11,a12 ,b1 },
                { a20,a21,a22 ,b2 }
            };
        }
        public static void NewMethod()
        {
            // int boyut = 3;
            //double[,] matris2 = new double[boyut, boyut];
            // double[] katsayılar_i0 = new double[boyut];
             
            double A, B, C;
            double factor_0_0 = matris[0, 0];
            double factor_1_0 = matris[1, 0];
            double factor_2_0 = matris[2, 0];

            for (int i = 0; i < 3 + 1; i++)
            {
                matris[0, i] = matris[0, i] / factor_0_0;
            }
            // [0,0]. eleman 1 oldu
            for (int i = 0; i < 3 + 1; i++)
            {
                matris[1, i] = matris[1, i] - factor_1_0 * matris[0, i];
            }
            for (int i = 0; i < 3 + 1; i++)
            {
                matris[2, i] = matris[2, i] - factor_2_0 * matris[0, i];
            }
            /*
              1     x     y
              0     z     t
              0     a     b
            */
            double factor_1_1 = matris[1, 1];
            double factor_2_1 = matris[2, 1];

            for (int i = 0; i < 4; i++)
            {
                matris[1, i] = matris[1, i] / factor_1_1;
            }
            /*
              1     x     y
              0     1     f
              0     a     b
            */
            for (int i = 0; i < 4; i++)
            {
                matris[2, i] = matris[2, i] - matris[1, i] * factor_2_1;
            }
            /*
             1     x     y
             0     1     f
             0     0     r
           */
            C = matris[2, 3] / matris[2, 2];
            B = matris[1, 3] - matris[1, 2] * C;
            A = matris[0, 3] - matris[0, 1] * B - matris[0, 2] * C;

            Console.WriteLine("A= " + A + "\nB= " + B + "\nC= " + C);

        }
    }
}
