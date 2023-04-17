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
    public partial class MemoryGame : Form
    {
        
        Image[] images = {Properties.Resources._1, Properties.Resources._2, Properties.Resources._3,
        Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7,
        Properties.Resources._8, Properties.Resources._9, Properties.Resources._10};

        int[] index = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9 };

        Button firstClickBtn;
        Button secondClickBtn;
        int firstIndex;
        int clickCount;
        public MemoryGame()
        {
            InitializeComponent();
        }

        private void MemoryGame_Load(object sender, EventArgs e)
        {
            ChangeImagePlace();
        }
        private void ChangeImagePlace()
        {
            Random random = new Random();
            for (int i = 0; i < index.Length; i++)
            {
                int newIndex = random.Next(20);


                int x = index[i];
                index[i] = index[newIndex];
                index[newIndex] = x;
            }
        }
        private void buttonClick(object sender, EventArgs e)
        {
            clickCount++;

            
            Button btn = (Button)sender;
            int btnNumber = int.Parse(btn.Name.Substring(6));
            int indexNumber = index[btnNumber - 1];
            btn.BackgroundImage = images[indexNumber];
            btn.Refresh();
            if (clickCount == 3)
            {
                firstClickBtn.BackgroundImage = null;
                secondClickBtn.BackgroundImage = null;
                firstClickBtn = null;
                clickCount=1;
            }

            if (firstClickBtn == null)
            {
                firstClickBtn = btn;
                firstIndex = indexNumber;
            }
            else if (firstIndex == indexNumber)
            {
                firstClickBtn.Enabled = false;
                btn.Enabled = false;
                clickCount = 0;
                firstClickBtn = null;

            }
            secondClickBtn = btn;



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
