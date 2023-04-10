using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class GameLauncher : Form
    {
        public GameLauncher()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            XOX xox = new XOX();
            xox.Show();
            this.Hide();
        }
    }
}
