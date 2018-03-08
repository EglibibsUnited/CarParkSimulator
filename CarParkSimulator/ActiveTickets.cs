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
            this.activeTickets = new List<Ticket>();
        }

        public void AddTicket(Ticket ticket)
        {
            this.activeTickets.Add(ticket);
        }

        public void RemoveTicket(Ticket ticket)
        {
            this.activeTickets.Remove(ticket);
        }

        public List<Ticket> GetTickets()
        {
            return this.activeTickets;
        }
    }
}
