using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer.Interval = 500;
            timer.Start();
        }

        private void BakuBtn_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Baku;
            timer.Tick += Timer_Tick;
            timer.Interval = 500;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeShowLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void LondonBtn_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.London_800x450;
            timer.Tick += Timer_TickLondon;
            timer.Interval = 500;
            timer.Start();
        }

        private void Timer_TickLondon(object sender, EventArgs e)
        {
            TimeShowLbl.Text = DateTime.Now.AddHours(4).ToLongTimeString();
        }
    }
}
