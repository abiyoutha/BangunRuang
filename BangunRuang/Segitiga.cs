using System;
using System.Collections.Generic;
using System.Text;

namespace BangunRuang
{
    class Segitiga
    {
        private float a, t, luas;

        public float alas
        {
            get { return a; }
            set
            {
                a = value;
            }
        }

        public float tinggi
        {
            get { return t; }
            set
            {
                t = value;
            }
        }

        public float luas_segitiga()
        {
            luas = (a * t) / 2;
            return luas;
        }
    }
}