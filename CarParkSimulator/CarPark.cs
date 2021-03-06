﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class CarPark
    {
        private int currentSpaces;
        private int maxSpace = 5;
        private TicketMachine ticketMachine;
        private TicketValidator ticketValidator;
        private FullSign fullSign;
        private Barrier entryBarrier, exitBarrier;

        public CarPark(TicketMachine ticketMachine, TicketValidator ticketValidator, FullSign fullSign, Barrier entryBarrier, Barrier exitBarrier)
        {
            currentSpaces = maxSpace;
            this.ticketMachine = ticketMachine;
            this.ticketValidator = ticketValidator;
            this.fullSign = fullSign;
            this.entryBarrier = entryBarrier;
            this.exitBarrier = exitBarrier;
        }

        public void CarArrivedAtEntrance()
        {
            ticketMachine.CarArrived();
        }

        public void TicketDispensed()
        {
            entryBarrier.Raise();
        }

        public void CarEnteredCarPark()
        {
            this.currentSpaces--;
            entryBarrier.Lower();
            ticketMachine.ClearMessage();
            if (IsFull())
            {
                fullSign.SetLit(true);
            }
        }

        public bool IsEmpty()
        {
            return this.currentSpaces == this.maxSpace;
        }

        public bool IsFull()
        {
            return this.currentSpaces == 0;
        }

        public bool HasSpace()
        {
            return this.currentSpaces > 0;
        }

        public int GetCurrentSpaces()
        {
            return this.currentSpaces;
        }
    }
}
