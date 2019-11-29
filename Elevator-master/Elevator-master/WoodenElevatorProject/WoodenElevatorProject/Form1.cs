using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace WoodenElevatorProject
{
    public partial class Form1 : Form
    {
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

        SpeechSynthesizer reader = new SpeechSynthesizer();
        DatabaseCommand dc = new DatabaseCommand();

        public Form1()
        {
            InitializeComponent();
        }


        private void TimerFirstFloorDoorOpen_Tick(object sender, EventArgs e)
        {
            if (picUprLeftDoor.Left >= xLeftDoorOpen && picUprRightDoor.Left <= xRightDoorOpen)
            {
                Door d_o_u = new Door();
                d_o_u.DoorOpenUp(picUprLeftDoor, picUprRightDoor);
            }
            else
            {
                dc.insertdata("First Floor Door Opening"); //database record
                TimerFirstFloorDoorOpen.Enabled = false;
            }
        }

        private void TimerFirstFloorDoorClose_Tick(object sender, EventArgs e)
        {
            if (picUprLeftDoor.Left <= xLeftDoorClose && picUprRightDoor.Left >= xRightDoorClose)
            {
                Door d_c_u = new Door();
                d_c_u.DoorCloseUp(picUprLeftDoor, picUprRightDoor);
            }
            else
            {
                TimerFirstFloorDoorClose.Enabled = false;
                dc.insertdata("First Floor Door Closing"); //data inserted in database
                LoadData(); // shows databse reccord in GUI

                if (liftGoDown == true)
                {

                    picMainDisplay.Image = global::WoodenElevatorProject.Properties.Resources.down;
                    pic1display.Image = global::WoodenElevatorProject.Properties.Resources.down;
                    picGdisplay.Image = global::WoodenElevatorProject.Properties.Resources.down;
                    TimerLiftDown.Enabled = true;
                    liftGoDown = false;
                    reader.Speak("Going down");
                    
                }
            }
        }

        private void TimerLiftDown_Tick(object sender, EventArgs e)
        {
            if (pnlLift.Top <= yLiftDown)
            {
                Lift l_u = new Lift();
                l_u.LiftDown(pnlLift);
            }
            else
            {
                TimerLiftDown.Enabled = false;
                btnUp.Enabled = true;
                btn1.Enabled = true;
                btnOpen.Enabled = true;
                btnClose.Enabled = true;
                btnDown.BackColor = Color.White;
                btnG.BackColor = Color.White;
                GFloorDoorOpen();
                arrivedAtGf = true;
                dc.insertdata("Lift going down"); // data inserted in databse
                LoadData(); // shows database record in GUI



                picMainDisplay.Image = global::WoodenElevatorProject.Properties.Resources.G;
                pic1display.Image = global::WoodenElevatorProject.Properties.Resources.G;
                picGdisplay.Image = global::WoodenElevatorProject.Properties.Resources.G;

            }


        }

        private void TimerLiftUp_Tick(object sender, EventArgs e)
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


                dc.insertdata("Lift Going Up");// database record
                LoadData(); // shows databse reccord in GUI
                FirstFloorDoorOpen();
                arrivedAt1f = true;
            }
        }

        private void TimerGFloorDoorOpen_Tick(object sender, EventArgs e)
        {
            if (picLwrLeftDoor.Left >= xLeftDoorOpen && picLwrRightDoor.Left <= xRightDoorOpen)
            {
                Door d_o_d = new Door();
                d_o_d.DoorOpenDown(picLwrLeftDoor, picLwrRightDoor);
            }
            else
            {
                TimerGFloorDoorOpen.Enabled = false;
                dc.insertdata("Ground Floor Door Opening");// data inserted in database
                LoadData(); // shows databse reccord in GUI
            }
        }

        private void TimerGFloorDoorClose_Tick(object sender, EventArgs e)
        {
            if (picLwrLeftDoor.Left <= xLeftDoorClose && picLwrRightDoor.Left >= xRightDoorClose)
            {
                Door d_c_d = new Door();
                d_c_d.DoorCloseDown(picLwrLeftDoor, picLwrRightDoor);
            }
            else
            {
                TimerGFloorDoorClose.Enabled = true;
                dc.insertdata("Ground Floor Door Closing"); //database record
                LoadData(); // shows databse reccord in GUI


                if (liftGoUp == true)
                {
                    picMainDisplay.Image = global::WoodenElevatorProject.Properties.Resources.up;
                    pic1display.Image = global::WoodenElevatorProject.Properties.Resources.up;
                    picGdisplay.Image = global::WoodenElevatorProject.Properties.Resources.up;

                    reader.Speak(" Going up");
                    
                    TimerLiftUp.Enabled = true;
                    liftGoUp = false;
                }
            }
        }

        private void GFloorDoorClose()
        {
            reader.Speak("Ground floor, doors closing");
            TimerGFloorDoorClose.Enabled = true;
            TimerGFloorDoorOpen.Enabled = false;
        }
        private void GFloorDoorOpen()
        {
            reader.Speak("Ground floor, doors opening");
            TimerGFloorDoorClose.Enabled = false;
            TimerGFloorDoorOpen.Enabled = true;
        }

        private void FirstFloorDoorClose()
        {

            TimerFirstFloorDoorClose.Enabled = true;
            TimerFirstFloorDoorOpen.Enabled = false;

        }

        private void FirstFloorDoorOpen()
        {

            TimerFirstFloorDoorClose.Enabled = false;
            TimerFirstFloorDoorOpen.Enabled = true;
        }

        private void LiftGoingUp()
        {
            liftGoUp = true;
            GFloorDoorClose();
            btnG.Enabled = false;
            btnDown.Enabled = false;
            btnClose.Enabled = false;
            btnOpen.Enabled = false;
            arrivedAtGf = false;
        }

        private void LiftGoingDown()
        {
            liftGoDown = true;
            FirstFloorDoorClose();
            btn1.Enabled = false;
            btnUp.Enabled = false;
            btnClose.Enabled = false;
            btnOpen.Enabled = false;
            arrivedAt1f = false;

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            if (arrivedAt1f == true)
            {
                FirstFloorDoorOpen();
            }
            else if (arrivedAtGf == true)
            {
                GFloorDoorOpen();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (arrivedAtGf == true)
            {
                GFloorDoorClose();
            }
            else if (arrivedAt1f == true)
            {
                FirstFloorDoorClose();
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
            dc.insertdata("Emergency Exit");
            LoadData(); // shows databse reccord in GUI
            btnAlarm.BackColor = Color.Red;
            TimerFirstFloorDoorOpen.Enabled = true;
            TimerGFloorDoorOpen.Enabled = true;
            TimerFirstFloorDoorClose.Enabled = false;
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

        private void ElevatorControl_Load(object sender, EventArgs e)
        {
            DatabaseConnection.DbConnection(); //enables database connection

        }
        public void LoadData()
        {
            try
            {
                DatabaseCommand dc = new DatabaseCommand();
                DataTable dt = dc.ViewData();
                GridViewDatabase.DataSource = dt; //import data in datagrid view
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form1");
            }

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            GridViewDatabase.DataSource = null; // clears the data of datagrid view
            dc.remove();                    // delete record of database
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

