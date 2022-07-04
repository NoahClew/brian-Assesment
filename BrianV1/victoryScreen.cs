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
    public partial class victoryScreen : Form
    {
        public victoryScreen()
        {
            InitializeComponent();
            label1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
