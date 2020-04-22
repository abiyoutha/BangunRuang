using System;
using System.Collections.Generic;
using System.Text;

namespace BangunRuang
{
    class Segiempat
    {
        private float s, luas;

        public float sisi
        {
            get { return s; }
            set
            {
                s = value;
            }
        }

        public float luas_segiempat()
        {
            luas = s * s;
            return luas;
        }

    }
}