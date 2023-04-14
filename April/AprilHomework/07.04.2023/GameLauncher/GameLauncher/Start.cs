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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void timer_Start_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;
            if (panel2.Width>=980)
            {
                timer_Start.Stop();
                GameLauncher gL = new GameLauncher();
                gL.Show();
                this.Hide();
            }
        }


    }
}
