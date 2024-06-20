using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nature_Biomarkt
{
    public partial class StartWindow : Form

    {

        private int loadingBarValue;

        public StartWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void StartWindow_Load(object sender, EventArgs e)
        {
            loadingbarTimer.Start();

        }

        private void loadingbarTimer_Tick(object sender, EventArgs e)
        {
            loadingBarValue += 1;
            lblLoadingProgress.Text = loadingBarValue.ToString() + " %";
            loadingProgressBar.Value = loadingBarValue;

            if(loadingBarValue >= loadingProgressBar.Maximum) 
            { 
                loadingbarTimer.Stop();
            }
        }

       
    }
}
