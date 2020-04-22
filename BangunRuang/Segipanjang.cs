using System;
using System.Collections.Generic;
using System.Text;

namespace BangunRuang
{
    class Segipanjang
    {
        private float p, l, luas;

        public float panjang
        {
            get { return p; }
            set
            {
                p = value;
            }
        }

        public float lebar
        {
            get { return l; }
            set
            {
                l = value;
            }
        }

        public float luas_segipanjang()
        {
            luas = p * l;
            return luas;
        }
    }
}