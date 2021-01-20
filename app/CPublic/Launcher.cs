using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPublic
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        //Drag Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LaunchBtn_Click(object sender, EventArgs e)
        {
            using (WebClient c = new WebClient())
            {
                c.DownloadFile("", "");
                Process p = new Process();
                Process process = Process.Start("");
            }
        }

        private void Samsung_Click(object sender, EventArgs e)
        {
            using (WebClient c = new WebClient())
            {
                c.DownloadFile("", "");
                Process p = new Process();
                Process process = Process.Start("");
            }
        }

        private void Memenite_Click(object sender, EventArgs e)
        {
            using (WebClient c = new WebClient())
            {
                c.DownloadFile("", "");
                Process p = new Process();
                Process process = Process.Start("");
            }
        }
    }
}
