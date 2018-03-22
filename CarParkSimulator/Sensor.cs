using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Sensor
    {
        protected bool carOnSensor;
        protected CarPark carPark;

        public Sensor(CarPark carPark)
        {
            this.carPark = carPark;
        }

        public void CarDetected()
        {
            carPark.CarArrivedAtEntrance();
            this.carOnSensor = true;
        }

        public void CarLeftSensor()
        {
            this.carOnSensor = false;
        }

        public bool IsCarOnSensor()
        {
            return this.carOnSensor;
        }
    }
}
