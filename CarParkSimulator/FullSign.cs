using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class FullSign
    {
        private bool lit;

        public bool IsLit()
        {
            return this.lit;
        }
        public void SetLit(bool value)
        {
            this.lit = value;
        }
    }
}
