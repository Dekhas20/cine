using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            maximize.Visible = false;
            maximize2.Visible = true;
            bunifuElipse2.ElipseRadius = 0;
            menuLeft.Height = left.Height - 15;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            
        }

        private void maximize2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            maximize2.Visible = false;
            maximize.Visible = true;
            bunifuElipse2.ElipseRadius = 0;
            menuLeft.Height = left.Height - 15;
        }

        private void menu_Click(object sender, EventArgs e)
        {

            if (menuLeft.Width == 190)
            {
                menuLeft.Visible = false;
                left.Visible = false;
                left.Width = 80;
                menuLeft.Width = 60;
                transitionLR.Show(left);
                transitionLR.Show(menuLeft);
            }
            else
            {
                menuLeft.Visible = false;
                left.Visible = false;
                left.Width = 215;
                menuLeft.Width = 190;
                transitionLR.Show(left);
                transitionLR.Show(menuLeft);
            }
            
        }
    }
}
