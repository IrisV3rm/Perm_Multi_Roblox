using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Roblox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NotifyIcon1_Click(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                {
                    contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
                    }
                break;
            }
        }
    

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            Environment.Exit(Environment.ExitCode);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await Task.Delay(5);
            Hide();
            new Mutex(true, "ROBLOX_singletonMutex");
        }
    }
}
