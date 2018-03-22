using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketValidator
    {
        private string message;
        private CarPark carPark;
        private ActiveTickets activeTickets;

        public TicketValidator(ActiveTickets activeTickets)
        {
            this.activeTickets = activeTickets;
        }

        public void AssignCarPark(CarPark carPark)
        {
            this.carPark = carPark;
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
