using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matem
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        } 

        
        Point lastPoint;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void TeacherButton_Click(object sender, EventArgs e)
        {
            MenuWithThemes form = new MenuWithThemes();
            form.Show();
            this.Hide();
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            StudentTasks1 form = new StudentTasks1();
            form.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        private void TeacherButton_MouseEnter(object sender, EventArgs e)
        {
            TeacherButton.BackColor = Color.Red;
            TeacherButton.ForeColor = Color.White;
        }

        private void TeacherButton_MouseLeave(object sender, EventArgs e)
        {
            TeacherButton.BackColor = Color.Lime;
            TeacherButton.ForeColor = Color.Black;
        }

        private void StudentButton_MouseEnter(object sender, EventArgs e)
        {
            StudentButton.BackColor = Color.Red;
            StudentButton.ForeColor = Color.White;
        }

        private void StudentButton_MouseLeave(object sender, EventArgs e)
        {
            StudentButton.BackColor = Color.Lime;
            StudentButton.ForeColor = Color.Black;
        }
    }
}
