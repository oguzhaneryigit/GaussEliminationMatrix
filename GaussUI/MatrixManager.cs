using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaussUI
{
    class MatrixManager
    {
        Matrix _matrix;
        public MatrixManager(Matrix matrix)
        {
            _matrix = matrix;
        }
        public List<double> GaussCalculator()
        {
            // int boyut = 3;
            //double[,] matris2 = new double[boyut, boyut];
            // double[] katsayılar_i0 = new double[boyut];

            double A, B, C;
            double factor_0_0 = _matrix.matris[0, 0];
            double factor_1_0 = _matrix.matris[1, 0];
            double factor_2_0 = _matrix.matris[2, 0];

            for (int i = 0; i < 3 + 1; i++)
            {
                _matrix.matris[0, i] = _matrix.matris[0, i] / factor_0_0;
            }
            // [0,0]. eleman 1 oldu
            for (int i = 0; i < 3 + 1; i++)
            {
                _matrix.matris[1, i] = _matrix.matris[1, i] - factor_1_0 * _matrix.matris[0, i];
            }
            for (int i = 0; i < 3 + 1; i++)
            {
                _matrix.matris[2, i] = _matrix.matris[2, i] - factor_2_0 * _matrix.matris[0, i];
            }
            /*
              1     x     y
              0     z     t
              0     a     b
            */
            double factor_1_1 = _matrix.matris[1, 1];
            double factor_2_1 = _matrix.matris[2, 1];

            for (int i = 0; i < 4; i++)
            {
                _matrix.matris[1, i] = _matrix.matris[1, i] / factor_1_1;
            }
            /*
              1     x     y
              0     1     f
              0     a     b
            */
            for (int i = 0; i < 4; i++)
            {
                _matrix.matris[2, i] = _matrix.matris[2, i] - _matrix.matris[1, i] * factor_2_1;
            }
            /*
             1     x     y
             0     1     f
             0     0     r
           */
            C = _matrix.matris[2, 3] / _matrix.matris[2, 2];
            B = _matrix.matris[1, 3] - _matrix.matris[1, 2] * C;
            A = _matrix.matris[0, 3] - _matrix.matris[0, 1] * B - _matrix.matris[0, 2] * C;

            Console.WriteLine("A= " + A + "\nB= " + B + "\nC= " + C);

            return new List<double> { A, B, C };

        }
    }
}
