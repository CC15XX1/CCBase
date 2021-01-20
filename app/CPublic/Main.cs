using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPublic
{
    public partial class Main : Form
    {
        public Main()
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
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }

        private void NotepadBtn_Click(object sender, EventArgs e)
        {
            Process.Start("Notepad");
        }

        private void FileExplorerBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Can't find FIle Explorer path.");
        }

        private void ChromeBtn_Click(object sender, EventArgs e)
        {
            Process.Start("chrome");
        }

        private void DefaultMode_CheckedChanged(object sender, EventArgs e)
        {
            Dark();
        }

        private void Dark()
        {
            this.BackColor = Color.FromArgb(40,40,40);
            this.ForeColor = Color.White;
            this.panel1.BackColor = Color.FromArgb(35, 35, 35);
            this.ChromeBtn.BackColor = Color.FromArgb(50, 50, 50);
            this.FileExplorerBtn.BackColor = Color.FromArgb(50, 50, 50);
            this.NotepadBtn.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void Light()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.panel1.BackColor = Color.Silver;
            this.ChromeBtn.BackColor = Color.Silver;
            this.FileExplorerBtn.BackColor = Color.Silver;
            this.NotepadBtn.BackColor = Color.Silver;
        }

        private void LightMode_CheckedChanged(object sender, EventArgs e)
        {
            Light();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            credits.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void LauncherBtn_Click(object sender, EventArgs e)
        {
            Launcher launcher = new Launcher();
            launcher.Show();
        }
    }
}