using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Programdan cixmaq isteyirsiniz?", "Cixis ekrani", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            string resultStr = result.ToString();
            if (resultStr == "Yes")
            {
                this.Close();
            }
        }
    }
}
