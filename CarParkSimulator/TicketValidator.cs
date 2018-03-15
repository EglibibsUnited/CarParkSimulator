using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketValidator
    {
        private string message;

        private void CarArrived()
        {
            this.message = "Welcome, please enter your ticket.";
        }

        public void ClearMessage()
        {
            this.message = "";
        }

        public string GetMessage()
        {
            return this.message;
        }
    }
}
