using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControl
{
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds == 0)
            {
                timer1.Stop();
                frmAnh  a= new frmAnh();
                a.Show();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(BasicControl.Properties.Resources.hny1);
                player.Play();

            }
            
            else
            {
                seconds--;
                lblTimer.Text = $"{seconds / 60}:{seconds % 60}";
            }
        }
        int seconds = 0;
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            seconds = (int) (numTimer.Value);
            timer1.Start();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
