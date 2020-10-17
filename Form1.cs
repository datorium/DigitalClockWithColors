using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClockWithColors
{
    public partial class Form1 : Form
    {
        int dsec = 0;
        int sec = 0;
        int min = 0;
        int hou = 0;

        public Form1()
        {
            InitializeComponent();
            MainTimer.Start();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
