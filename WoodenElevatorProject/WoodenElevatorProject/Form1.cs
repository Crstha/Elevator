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

        bool liftGoUp = false;
        bool liftGoDown = false;

        bool arrivedAtGf = false;
        bool arrivedAt1f = false;

        SpeechSynthesizer reader = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
        }


        private void TimerFirstFloorDoorOpen_Tick(object sender, EventArgs e)
        {
            if (picUprLeftDoor.Left >= xLeftDoorOpen && picUprRightDoor.Left <= xRightDoorOpen)
            {
                picUprLeftDoor.Left -= 1;
                picUprRightDoor.Left += 1;
            }
            else
            {
                TimerFirstFloorDoorOpen.Enabled = false;
            }
        }

        private void TimerFirstFloorDoorClose_Tick(object sender, EventArgs e)
        {
            if (picUprLeftDoor.Left <= xLeftDoorClose && picUprRightDoor.Left >= xRightDoorClose)
            {
                picUprLeftDoor.Left += 1;
                picUprRightDoor.Left -= 1;
            }
            else
            {
                TimerFirstFloorDoorClose.Enabled = false;

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
                pnlLift.Top += 1;
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

                

                picMainDisplay.Image = global::WoodenElevatorProject.Properties.Resources.G;
                pic1display.Image = global::WoodenElevatorProject.Properties.Resources.G;
                picGdisplay.Image = global::WoodenElevatorProject.Properties.Resources.G;
               
            }


        }

        private void TimerLiftUp_Tick(object sender, EventArgs e)
        {
            if (pnlLift.Top >= yLiftUp)
            {
                pnlLift.Top -= 1;
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

        private void TimerGFloorDoorOpen_Tick(object sender, EventArgs e)
        {
            if (picLwrLeftDoor.Left >= xLeftDoorOpen && picLwrRightDoor.Left <= xRightDoorOpen)
            {
                picLwrLeftDoor.Left -= 1;
                picLwrRightDoor.Left += 1;
            }
            else
            {
                TimerGFloorDoorOpen.Enabled = false;
            }
        }

        private void TimerGFloorDoorClose_Tick(object sender, EventArgs e)
        {
            if (picLwrLeftDoor.Left <= xLeftDoorClose && picLwrRightDoor.Left >= xRightDoorClose)
            {
                picLwrLeftDoor.Left += 1;
                picLwrRightDoor.Left -= 1;
            }
            else
            {
                TimerGFloorDoorClose.Enabled = true;

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
            reader.Speak("First floor, doors closing");
            TimerFirstFloorDoorClose.Enabled = true;
            TimerFirstFloorDoorOpen.Enabled = false;

        }

        private void FirstFloorDoorOpen()
        {
            reader.Speak("First floor, doors opening");
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
    }
}
