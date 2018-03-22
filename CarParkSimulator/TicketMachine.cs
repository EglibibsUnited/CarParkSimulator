using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketMachine
    {
        //Attributes
        private string message;
        private CarPark carPark;
        private ActiveTickets activeTickets;

        //Constructor
        public TicketMachine(ActiveTickets activeTickets)
        {
            this.activeTickets = activeTickets;
        }

        //Functions
        public void AssignCarPark(CarPark carPark)
        {
            this.carPark = carPark;
        }

        public void CarArrived()
        {
            this.message = "Please press to get a ticket";
        }

        public void PrintTicket()
        {
            activeTickets.AddTicket();
            carPark.TicketDispensed();
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
