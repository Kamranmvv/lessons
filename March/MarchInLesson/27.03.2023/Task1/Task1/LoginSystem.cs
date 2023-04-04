using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class LoginSystem : Form
    {
        public LoginSystem()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "12345")
            {
                Form2 form2 = new Form2(txtUsername.Text);
                form2.Show();
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
        }
    }
}
