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
    public partial class startMenu : Form
    {
        public startMenu()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            picBrian.Location = new Point ( 230, 117); 
        }

        private void btnAb_MouseHover(object sender, EventArgs e)
        {
            picBrian.Location = new Point(230, 159);
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            picBrian.Location = new Point(230, 201);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            startMenu menu = new startMenu();
            menu.Close();
            Level1 L1 = new Level1();
            L1.Show();
            
                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAb_Click(object sender, EventArgs e)
        {
            About A = new About();
            A.Show();
        }

        private void tmrHov_Tick(object sender, EventArgs e)
        {

        }
    }
}
