using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodenElevatorProject
{
    class Door : Form1
    {
        public void DoorCloseUp(PictureBox picUprLeftDoor, PictureBox picUprRightDoor)
        {
            if (picUprLeftDoor.Left <= -24 && picUprRightDoor.Left >= 83)
            {
                picUprLeftDoor.Left += 1;
                picUprRightDoor.Left -= 1;
            }
        }

        public void DoorOpenUp(PictureBox picUprLeftDoor, PictureBox picUprRightDoor)
        {
            if (picUprLeftDoor.Left >= -105 && picUprRightDoor.Left <= 159)
            {
                picUprLeftDoor.Left -= 3;
                picUprRightDoor.Left += 3;
            }
        }

        public void DoorOpenDown(PictureBox picLwrLeftDoor, PictureBox picLwrRightDoor)
        {
            if (picLwrLeftDoor.Left >= -105 && picLwrRightDoor.Left <= 159)
            {
                picLwrLeftDoor.Left -= 3;
                picLwrRightDoor.Left += 3;
            }

        }
         public void DoorCloseDown(PictureBox picLwrLeftDoor, PictureBox picLwrRightDoor)
        {
            if (picLwrLeftDoor.Left <= -24 && picLwrRightDoor.Left >= 83)
            {
                picLwrLeftDoor.Left += 3;
                picLwrRightDoor.Left -= 3;
            }
        }

    }
}
