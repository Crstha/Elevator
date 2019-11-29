using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodenElevatorProject
{
    class Lift: Form1
    {
        public void LiftUp(Panel pnlLift)
        {
            if (pnlLift.Top >= -2)
            {
                pnlLift.Top -= 3;
            }
        }
        public void LiftDown(Panel pnlLift)
        {
            if (pnlLift.Top <= 263)
            {
                pnlLift.Top += 3;
            }
        }

    }
}
