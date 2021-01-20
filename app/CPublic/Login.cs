using CPublic.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPublic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Form System

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(Resources.User1 == UserBox.Text && Resources.Password1 == PasswordBox.Text)
            {
                Main main = new Main();
                main.Show();
                MessageBox.Show("Whitelisted!", "Success!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Not Whitelisted!", "Failed!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TrialLoginBtn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                PasswordBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordBox.UseSystemPasswordChar = true;
            }
        }
    }
}
