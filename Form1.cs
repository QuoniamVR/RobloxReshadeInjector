using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace ReshadeCraft
{
    public partial class ReshadeCraft : Form
    {
        public ReshadeCraft()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PROGRESS.Text = "Checking for ReShade64 and Inject64...";
            System.Diagnostics.Process.Start("CMD.exe", "/C cd C:/Users/%username%/Roblox_Reshade_Injector && inject64.exe RobloxPlayerBeta.exe");
            System.Threading.Thread.Sleep(1000);
            PROGRESS.Text = "INJECTING...";
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void PROGRESS_Click(object sender, EventArgs e)
        {

        }

        private void ReshadeCraft_Load(object sender, EventArgs e)
        {

        }
    }
}
