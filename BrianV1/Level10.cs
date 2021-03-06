using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrianV1
{
    public partial class Level10 : Form
    {

        const int STARTX = 43;
        const int STARTY = 320;
        bool right;
        bool left;
        bool jump;
        int g = 26;
        int force;
        List<PictureBox> collision = new List<PictureBox>();
        List<PictureBox> dangerBlocks = new List<PictureBox>();
        List<PictureBox> springs = new List<PictureBox>();

        public Level10()
        {
            InitializeComponent();
            picPlayer.BringToFront();
            foreach (PictureBox x in this.screen.Controls)
            {
                if ((string)x.Tag == "collide") { collision.Add(x); }
            }
            foreach (PictureBox x in this.screen.Controls)
            {
                if ((string)x.Tag == "danger") { dangerBlocks.Add(x); }
            }
            foreach (PictureBox x in this.screen.Controls)
            {
                if ((string)x.Tag == "spring") { springs.Add(x); }
            }
            screen.SendToBack();
            picPlayer.Location = new Point(STARTX, STARTY);
            lblNdeaths.Text = $"{Program.deaths}";


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tmrMove_Tick(object sender, EventArgs e)
        {



            if (right == true)
            {
                picPlayer.Left += 7;
            }
            if (left == true)
            {
                picPlayer.Left -= 7;
            }

            if (jump == true)
            {
                picPlayer.Top -= force;
                force -= 1;
            }
            if (picPlayer.Top + picPlayer.Height >= picFloor1.Top)
            {
                jump = false;
            }
            else
            {
                picPlayer.Top += 7;
            }




        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {

                right = true;
            }
            if (e.KeyCode == Keys.A)
            {

                left = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (jump != true)
            {
                if (e.KeyCode == Keys.W)
                {
                    jump = true;
                    g = 26;
                    force = g;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                right = false;
            }
            if (e.KeyCode == Keys.A)
            {
                left = false;
            }
        }
        private void tmrColl_Tick(object sender, EventArgs e)
        {
            if (picPlayer.Left < screen.Left)
            {
                picPlayer.Left += 7;
            }
            if (picPlayer.Bounds.IntersectsWith(picNextLevel.Bounds))
            {
                picNextLevel.Left -= 100;
                this.Hide();
                victoryScreen Vic = new victoryScreen();
                Vic.Show();
                this.Close();

            }
            foreach (var item in collision)
            {
                if (picPlayer.Bounds.IntersectsWith(item.Bounds))
                {
                    picPlayer.Top = item.Top - picPlayer.Height;

                }
            }
            foreach (var item in dangerBlocks)
            {
                if (picPlayer.Bounds.IntersectsWith(item.Bounds))
                {
                    Program.deaths++;
                    lblNdeaths.Text = $"{Program.deaths}";
                    picPlayer.Location = new Point(STARTX, STARTY);
                    picPlayer.Show();
                }
            }
            foreach (var item in springs)
            {
                if (jump == false)
                {
                    item.Image = Properties.Resources.springboardDown;
                }
                if (picPlayer.Bounds.IntersectsWith(item.Bounds))
                {
                    item.Image = Properties.Resources.springboardUp;
                    jump = true;
                    g = 32;
                    force = g;
                }
            }
        }






    }

}
