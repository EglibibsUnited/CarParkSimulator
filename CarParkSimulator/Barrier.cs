using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Barrier
    {
        private bool lifted;

        public void Lower()
        {
            this.lifted = false;
        }

        public void Raise()
        {
            this.lifted = true;
        }

        public bool IsLifted()
        {
            return this.lifted;
        }
    }
}