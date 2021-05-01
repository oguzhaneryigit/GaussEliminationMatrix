using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaussUI
{
    class Matrix
    {
        public double[,] matris { get; set; }
        public Matrix(double a00, double a01, double a02,
                       double a10, double a11, double a12,
                       double a20, double a21, double a22,
                       double b0, double b1, double b2)
        {
            matris = new double[,] {
                { a00,a01,a02 ,b0 },
                { a10,a11,a12 ,b1 },
                { a20,a21,a22 ,b2 }
            };
        }
        
        }
    }
