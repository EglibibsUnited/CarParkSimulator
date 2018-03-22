using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarParkSimulator
{
    public partial class SimulatorInterface : Form
    {
        // Attributes ///        
        private TicketMachine ticketMachine;
        private ActiveTickets activeTickets;
        private TicketValidator ticketValidator;
        private Barrier entryBarrier;
        private Barrier exitBarrier;
        private FullSign fullSign;
        private CarPark carPark;
        private EntrySensor entrySensor;
        private ExitSensor exitSensor;
        /////////////////


        // Constructor //
        public SimulatorInterface()
        {
            InitializeComponent();
        }
        /////////////////


        // Operations ///
        private void ResetSystem(object sender, EventArgs e)
        {
            // STUDENTS:
            ///// Class contructors are not defined so there will be errors
            ///// This code is correct for the basic version though
            activeTickets = new ActiveTickets();
            ticketMachine = new TicketMachine(activeTickets);
            ticketValidator = new TicketValidator(activeTickets);
            entryBarrier = new Barrier(); // Done //
            exitBarrier = new Barrier(); // Done //
            fullSign = new FullSign(); // Done //
            carPark = new CarPark(ticketMachine, ticketValidator, fullSign, entryBarrier, exitBarrier);
            entrySensor = new EntrySensor(carPark);
            exitSensor = new ExitSensor(carPark);

            ticketMachine.AssignCarPark(carPark);
            ticketValidator.AssignCarPark(carPark);

            /////////////////////////////////////////

            btnCarArrivesAtEntrance.Visible = true;
            btnDriverPressesForTicket.Visible = false;
            btnCarEntersCarPark.Visible = false;
            btnCarArrivesAtExit.Visible = false;
            btnDriverEntersTicket.Visible = false;
            btnCarExitsCarPark.Visible = false;

            UpdateDisplay();
        }

        private void CarArrivesAtEntrance(object sender, EventArgs e)
        {
            btnCarArrivesAtEntrance.Visible = false;
            btnDriverPressesForTicket.Visible = true;
            entrySensor.CarDetected();

            UpdateDisplay();
        }

        private void DriverPressesForTicket(object sender, EventArgs e)
        {
            ticketMachine.PrintTicket();
            UpdateDisplay();
        }

        private void CarEntersCarPark(object sender, EventArgs e)
        {

            UpdateDisplay();
        }

        private void CarArrivesAtExit(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void DriverEntersTicket(object sender, EventArgs e)
        {

            UpdateDisplay();

        }

        private void CarExitsCarPark(object sender, EventArgs e)
        {

            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            lblTicketMachine.Text = ticketMachine.GetMessage();
            lblTicketValidator.Text = ticketMachine.GetMessage();
            lblEntrySensor.Text = entrySensor.IsCarOnSensor().ToString();
            lblEntryBarrier.Text = entryBarrier.IsLifted().ToString();
            lblExitSensor.Text = exitSensor.IsCarOnSensor().ToString();
            lblExitBarrier.Text = exitBarrier.IsLifted().ToString();
            lblFullSign.Text = fullSign.IsLit().ToString();
            lblSpaces.Text = carPark.GetCurrentSpaces().ToString();
        }

        private void SimulatorInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
