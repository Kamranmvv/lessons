﻿using System;
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
        int allClickCount;

        TimeSpan elapsedTime;
        TimeSpan recordTime = TimeSpan.MaxValue;

        DateTime startTime;
        

        public MemoryGame()
        {
            InitializeComponent();
        }

        private void MemoryGame_Load(object sender, EventArgs e)
        {
            ChangeImagePlace();

            startTime = DateTime.Now;
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            
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
                firstClickBtn.Enabled = true;
                secondClickBtn.Enabled = true;
                firstClickBtn.BackgroundImage = null;
                secondClickBtn.BackgroundImage = null;
                firstClickBtn = null;
                clickCount=1;
            }

            if (firstClickBtn == null)
            {
                firstClickBtn = btn;
                firstIndex = indexNumber;
                firstClickBtn.Enabled = false;

            }
            else if (firstIndex == indexNumber)
            {
               
                firstClickBtn.Enabled = false;
                btn.Enabled = false;
                clickCount = 0;
                firstClickBtn = null;

                allClickCount++;

            }
            secondClickBtn = btn;
            secondClickBtn.Enabled = false;



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Begin:
            elapsedTime = DateTime.Now - startTime;
            label1.Text = "Timer: " + elapsedTime.ToString(@"hh\:mm\:ss");
            if (allClickCount == 10)
            {
                
                timer1.Stop();
                if (recordTime > elapsedTime)
                {
                    MessageBox.Show("Yeni Rekord!!!" +elapsedTime.ToString(@"hh\:mm\:ss"), "Memory Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblRecord.Text ="Rekord: " + elapsedTime.ToString(@"hh\:mm\:ss");
                    recordTime = elapsedTime;
                    RestartGame();
                    goto Begin;
                }
                else
                {
                    MessageBox.Show("Oyun Bitdi!", "Memory Game", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RestartGame();
                    goto Begin;
                }
               

            }
        }
        private void RestartGame()
        {
            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    item.BackgroundImage = null;
                    item.Enabled = true;
                    
                }
                
                    
                
            }
            firstClickBtn = null;
            secondClickBtn = null;
            firstIndex =0;
            clickCount = 0;
            allClickCount = 0;


            startTime = DateTime.Now;
            timer1.Start();
            ChangeImagePlace();

        }



        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
