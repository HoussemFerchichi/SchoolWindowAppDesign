using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginScreen.Controls;

namespace LoginScreen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            addUserControl(hm);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Studets studets = new Studets();
            addUserControl(studets);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Class clss = new Class();
            addUserControl(clss);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Icomes ic = new Icomes();
            addUserControl(ic);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Announcements announcements = new Announcements();
            addUserControl(announcements);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
