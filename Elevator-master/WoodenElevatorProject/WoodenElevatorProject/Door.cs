using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodenElevatorProject
{
    class Door
    {
        public void DoorCloseUp(PictureBox picUprLeftDoor, PictureBox picUprRightDoor)
        {
            if (picUprLeftDoor.Left <= -24 && picUprRightDoor.Left >= 83)
            {
                picUprLeftDoor.Left += 3; //shifts door to right with 3 increment
                picUprRightDoor.Left -= 3;//shifts door to left with 3 increment
            }
        }

        public void DoorOpenUp(PictureBox picUprLeftDoor, PictureBox picUprRightDoor)
        {
            if (picUprLeftDoor.Left >= -105 && picUprRightDoor.Left <= 159)
            {
                picUprLeftDoor.Left -= 3; //shifts door to left with 3 increment
                picUprRightDoor.Left += 3; //shifts door to right with 3 increment
            }
        }

        public void DoorOpenDown(PictureBox picLwrLeftDoor, PictureBox picLwrRightDoor)
        {
            if (picLwrLeftDoor.Left >= -105 && picLwrRightDoor.Left <= 159)
            {
                picLwrLeftDoor.Left -= 3; //shifts door to left with 3 increment
                picLwrRightDoor.Left += 3; //shifts door to right with 3 increment
            }

        }
         public void DoorCloseDown(PictureBox picLwrLeftDoor, PictureBox picLwrRightDoor)
        {
            if (picLwrLeftDoor.Left <= -24 && picLwrRightDoor.Left >= 83)
            {
                picLwrLeftDoor.Left += 3; //shifts door to right with 3 increment
                picLwrRightDoor.Left -= 3; //shifts door to left with 3 increment
            }
        }

    }
}
