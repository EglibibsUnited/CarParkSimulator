using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Ticket
    {
        private bool paid = false;

        void SetPaid(bool paid)
        {
            this.paid = paid;
        }

        bool IsPaid()
        {
            return paid;
        }
    }
}
