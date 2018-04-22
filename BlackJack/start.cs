using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarGUI
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Form1 fr1 = new Form1();
            fr1.StartPosition = FormStartPosition.CenterParent;
            fr1.ShowDialog();
            this.Close();

        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
           pictureBox4.BackgroundImage = Properties.Resources.start2;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = Properties.Resources.start1;
        }
    }
}
