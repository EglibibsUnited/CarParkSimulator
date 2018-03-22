using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Sensor
    {
        protected bool carOnSensor;

        public Sensor()
        {

        }

        public void CarDetected()
        {
            this.carOnSensor = true;
        }

        public void CarLeftSensor()
        {
            this.carOnSensor = false;
        }

        protected internal bool IsCarOnSensor()
        {
            return this.carOnSensor;
        }
    }
}
