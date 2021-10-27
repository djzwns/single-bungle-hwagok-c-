using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEvent
{
    public partial class Form1 : Form
    {
        private bool mouseDrag = false;
        private Point offset = new Point();

        private Random rand = new Random();

        enum Direction
        {
            UP, DOWN, LEFT, RIGHT
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvent_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDrag = true;
            offset.X = MousePosition.X - btnEvent.Location.X;
            offset.Y = MousePosition.Y - btnEvent.Location.Y;
        }

        private void btnEvent_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDrag = false;
        }

        private void btnEvent_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDrag == false)
                return;            

            Point nextPosition = new Point();
            nextPosition.X = MousePosition.X - offset.X;
            nextPosition.Y = MousePosition.Y - offset.Y;
            btnEvent.Location = nextPosition;
        }

        private void btnCatch_Click(object sender, EventArgs e)
        {
            int dir = rand.Next(4);
            CatchButtonMove((Direction)dir);
        }

        private void CatchButtonMove(Direction dir)
        {
            Point nextPosition = btnCatch.Location;
            int size = btnCatch.Size.Width;
            switch (dir)
            {
                case Direction.UP:
                    nextPosition.Y -= size;
                    break;
                case Direction.DOWN:
                    nextPosition.Y += size;
                    break;
                case Direction.LEFT:
                    nextPosition.X -= size;
                    break;
                case Direction.RIGHT:
                    nextPosition.X += size;
                    break;
            }

            if (nextPosition.X < 0 || nextPosition.Y < 0 || (nextPosition.X - size) > this.Width || (nextPosition.Y - size) > this.Height)
            {
                btnCatch.Text = "Catched";
            }
            else
            {
                btnCatch.Location = nextPosition;
            }
        }
    }
}
