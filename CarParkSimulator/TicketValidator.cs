using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketValidator
    {
        private string message;

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
