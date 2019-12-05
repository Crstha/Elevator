using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Speech;
//using System.Speech.Synthesis;
using System.Windows.Forms;

namespace WoodenElevatorProject
{
    public partial class Form1 : Form
    {
        //variables
        int yLiftUp = -2;
        int yLiftDown = 263;
        int xLeftDoorClose = -24;
        int xLeftDoorOpen = -105;
        int xRightDoorClose = 83;
        int xRightDoorOpen = 159;
        int increment = 0;

        bool liftGoUp = false;
        bool liftGoDown = false;

        bool arrivedAtGf = false;
        bool arrivedAt1f = false;

        //objects
        DatabaseConnection dc = new DatabaseConnection();
        //SpeechSynthesizer reader = new SpeechSynthesizer();


        public Form1()
        {
            InitializeComponent();
        }


        private void TimerFirstFloorDoorOpen_Tick(object sender, EventArgs e)  //timer to open the door of first floor
        {
            if (picUprLeftDoor.Left >= xLeftDoorOpen && picUprRightDoor.Left <= xRightDoorOpen)
            {
                Door d_o_u = new Door();
                d_o_u.DoorOpenUp(picUprLeftDoor, picUprRightDoor);

            }
            else
            {
                TimerAutodoorClose.Enabled = true;
                TimerFirstFloorDoorOpen.Enabled = false;
            }
        }

        private void TimerFirstFloorDoorClose_Tick(object sender, EventArgs e)  // timer to close the door of first floor
        {
            if (picUprLeftDoor.Left <= xLeftDoorClose && picUprRightDoor.Left >= xRightDoorClose)
            {
                Door d_c_u = new Door();
                d_c_u.DoorCloseUp(picUprLeftDoor, picUprRightDoor);
            }
            else
            {
                increment = 0;
                TimerAutodoorClose.Enabled = false;
                TimerFirstFloorDoorClose.Enabled = false;


                if (liftGoDown == true)
                {
                    picMainDisplay.Image = global::WoodenElevatorProject.Properties.Resources.down;
                    pic1display.Image = global::WoodenElevatorProject.Properties.Resources.down;
                    picGdisplay.Image = global::WoodenElevatorProject.Properties.Resources.down;
                    TimerLiftDown.Enabled = true;
                    liftGoDown = false;
                    // reader.Speak("Going down");

                }
            }
        }

        private void TimerLiftDown_Tick(object sender, EventArgs e)   //timer to move lift down
        {
            if (pnlLift.Top <= yLiftDown)
            {
                Lift l_u = new Lift();
                l_u.LiftDown(pnlLift);
            }
            else
            {
                TimerLiftDown.Enabled = false;

                //LoadData(); // shows database record in GUI
                btnUp.Enabled = true;
                btn1.Enabled = true;
                btnOpen.Enabled = true;
                btnClose.Enabled = true;
                btnDown.BackColor = Color.White;
                btnG.BackColor = Color.White;
                GFloorDoorOpen();
                arrivedAtGf = true;


                picMainDisplay.Image = global::WoodenElevatorProject.Properties.Resources.G;
                pic1display.Image = global::WoodenElevatorProject.Properties.Resources.G;
                picGdisplay.Image = global::WoodenElevatorProject.Properties.Resources.G;

            }


        }

        private void TimerLiftUp_Tick(object sender, EventArgs e)   //timer to move lift up
        {
            if (pnlLift.Top >= yLiftUp)
            {
                Lift l_u = new Lift();
                l_u.LiftUp(pnlLift);

            }
            else
            {
                TimerLiftUp.Enabled = false;

                btnDown.Enabled = true;
                btnG.Enabled = true;
                btnClose.Enabled = true;
                btnOpen.Enabled = true;
                btnUp.BackColor = Color.White;
                btn1.BackColor = Color.White;



                picMainDisplay.Image = global::WoodenElevatorProject.Properties.Resources._1;
                pic1display.Image = global::WoodenElevatorProject.Properties.Resources._1;
                picGdisplay.Image = global::WoodenElevatorProject.Properties.Resources._1;



                FirstFloorDoorOpen();
                arrivedAt1f = true;
            }
        }

        private void TimerGFloorDoorOpen_Tick(object sender, EventArgs e)  //timer to open the ground floor door
        {
            if (picLwrLeftDoor.Left >= xLeftDoorOpen && picLwrRightDoor.Left <= xRightDoorOpen)
            {
                Door d_o_d = new Door();
                d_o_d.DoorOpenDown(picLwrLeftDoor, picLwrRightDoor);
            }
            else
            {
                TimerAutodoorClose.Enabled = true;
                TimerGFloorDoorOpen.Enabled = false;
            }
        }

        private void TimerGFloorDoorClose_Tick(object sender, EventArgs e)  //timer to close the ground floor door
        {
            if (picLwrLeftDoor.Left <= xLeftDoorClose && picLwrRightDoor.Left >= xRightDoorClose)
            {
                Door d_c_d = new Door();
                d_c_d.DoorCloseDown(picLwrLeftDoor, picLwrRightDoor);
            }
            else
            {
                increment = 0;
                TimerAutodoorClose.Enabled = false;
                TimerGFloorDoorClose.Enabled = true;


                if (liftGoUp == true)
                {
                    picMainDisplay.Image = global::WoodenElevatorProject.Properties.Resources.up;
                    pic1display.Image = global::WoodenElevatorProject.Properties.Resources.up;
                    picGdisplay.Image = global::WoodenElevatorProject.Properties.Resources.up;

                    //reader.Speak(" Going up");

                    TimerLiftUp.Enabled = true;
                    liftGoUp = false;
                }
            }
        }

        private void GFloorDoorClose()  //method to close ground floor door
        {
            //reader.Speak("Ground floor, doors closing");
            TimerGFloorDoorClose.Enabled = true;
            TimerGFloorDoorOpen.Enabled = false;
            string logaction = "Ground Floor Door Closing";
            dc.InsertQuery(logaction); //database record
        }
        private void GFloorDoorOpen()  //method to open ground floor door
        {
            //reader.Speak("Ground floor, doors opening");
            TimerGFloorDoorClose.Enabled = false;
            TimerGFloorDoorOpen.Enabled = true;
            string logaction = "Ground Floor Door Opening";
            dc.InsertQuery(logaction); //database record
        }

        private void FirstFloorDoorClose()  //method to close first floor door
        {
            TimerFirstFloorDoorClose.Enabled = true;
            TimerFirstFloorDoorOpen.Enabled = false;
            string logaction = "First Floor Door Closing";
            dc.InsertQuery(logaction); //database record
        }

        private void FirstFloorDoorOpen()  //method to open first floor door
        {

            TimerFirstFloorDoorClose.Enabled = false;
            TimerFirstFloorDoorOpen.Enabled = true;
            string logaction = "First floor door opening";
            dc.InsertQuery(logaction); //database record
        }

        private void LiftGoingUp()  //method to move lift up
        {
            liftGoUp = true;
            GFloorDoorClose();
            btnG.Enabled = false;
            btnDown.Enabled = false;
            btnClose.Enabled = false;
            btnOpen.Enabled = false;
            arrivedAtGf = false;
            string logaction = "Lift Going Up";
            dc.InsertQuery(logaction); //database record

        }

        private void LiftGoingDown()  // method to move lift down
        {
            liftGoDown = true;
            FirstFloorDoorClose();
            btn1.Enabled = false;
            btnUp.Enabled = false;
            btnClose.Enabled = false;
            btnOpen.Enabled = false;
            arrivedAt1f = false;
            string logaction = "Lift Going Down";
            dc.InsertQuery(logaction); //database record

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            if (arrivedAt1f == true)
            {
                FirstFloorDoorOpen();
                string logaction = "First floor door opening";
                dc.InsertQuery(logaction); //database record
            }
            else if (arrivedAtGf == true)
            {
                GFloorDoorOpen();
                string logaction = "Ground floor door opening";
                dc.InsertQuery(logaction); //database record
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (arrivedAtGf == true)
            {
                GFloorDoorClose();
                string logaction = "Ground floor door closing";
                dc.InsertQuery(logaction); //database record
            }
            else if (arrivedAt1f == true)
            {
                FirstFloorDoorClose();
                string logaction = "First floor door closing";
                dc.InsertQuery(logaction); //database record
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            btn1.BackColor = Color.Red;
            LiftGoingUp();
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            btnG.BackColor = Color.Red;
            LiftGoingDown();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            btnAlarm.BackColor = Color.Red;
            TimerFirstFloorDoorOpen.Enabled = true;
            TimerGFloorDoorOpen.Enabled = true;
            TimerLiftDown.Enabled = false;
            TimerLiftUp.Enabled = false;
            TimerGFloorDoorClose.Enabled = false;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            LiftGoingUp();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            LiftGoingDown();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            GridViewDatabase.DataSource = null;  //clears the data grid
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = dc.DisplayQuery();
            GridViewDatabase.DataSource = ds.Tables[0].DefaultView;
        }

        private void TimerAutodoorClose_Tick(object sender, EventArgs e)
        {
            increment++;
            if (increment >= 300 && arrivedAtGf == true)
            {
                TimerGFloorDoorClose.Enabled = true;
            }
            else if (increment >= 300 && arrivedAt1f == true)
            {
                TimerFirstFloorDoorClose.Enabled = true;
            }
            else
            {
                TimerGFloorDoorClose.Enabled =false;
                TimerFirstFloorDoorClose.Enabled =false;

            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            dc.Save();
        }
    }
}

