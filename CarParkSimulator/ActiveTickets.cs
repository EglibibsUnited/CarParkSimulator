using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ActiveTickets
    {
        private List<Ticket> activeTickets;

        public ActiveTickets()
        {
            activeTickets = new List<Ticket>();
        }

        public void AddTicket(Ticket ticket)
        {
            activeTickets.Add(ticket);
        }

        public void RemoveTicket(Ticket ticket)
        {
            activeTickets.Remove(ticket);
        }


    }
}
