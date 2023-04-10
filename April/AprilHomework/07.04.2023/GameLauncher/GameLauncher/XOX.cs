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
    public partial class XOX : Form
    {
        public XOX()
        {
            InitializeComponent();
        }
        string input = "X";
        private void btnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.Text = input;
            btn.Enabled = false;

            if (input=="X")
            {
                btn.BackColor = Color.Green;
                input = "O";
            }
            else if (input == "O")
            {
                btn.BackColor = Color.Red;
                input = "X";
            }

            if (button1.Text + button2.Text + button3.Text == "XXX" ||
                button4.Text + button5.Text + button6.Text == "XXX" ||
                button7.Text + button8.Text + button9.Text == "XXX" ||
                button1.Text + button4.Text + button7.Text == "XXX" ||
                button2.Text + button5.Text + button8.Text == "XXX" ||
                button3.Text + button6.Text + button9.Text == "XXX" ||
                button1.Text + button5.Text + button9.Text == "XXX" ||
                button3.Text + button5.Text + button7.Text == "XXX")
            {
                MessageBox.Show("User1 Qazandı!!!", "XOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();

            }
            else if (button1.Text + button2.Text + button3.Text == "OOO" ||
                button4.Text + button5.Text + button6.Text == "OOO" ||
                button7.Text + button8.Text + button9.Text == "OOO" ||
                button1.Text + button4.Text + button7.Text == "OOO" ||
                button2.Text + button5.Text + button8.Text == "OOO" ||
                button3.Text + button6.Text + button9.Text == "OOO" ||
                button1.Text + button5.Text + button9.Text == "OOO" ||
                button3.Text + button5.Text + button7.Text == "OOO")
            {
                MessageBox.Show("User2 Qazandı!!!", "XOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();

            }

            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "" )
            {
                MessageBox.Show("Bərabərə!!!", "XOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }

        private void Clear()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.BackColor = Color.Aqua;
            button2.BackColor = Color.Aqua;
            button3.BackColor = Color.Aqua;
            button4.BackColor = Color.Aqua;
            button5.BackColor = Color.Aqua;
            button6.BackColor = Color.Aqua;
            button7.BackColor = Color.Aqua;
            button8.BackColor = Color.Aqua;
            button9.BackColor = Color.Aqua;

            input = "X";


        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
