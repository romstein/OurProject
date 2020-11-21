using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Matem
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        } 

        
        Point lastPoint;
        public XmlSerializer formater;

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
            if (File.Exists("theme.xml"))
            {
             
                Nazvanie_Theme nazvanie = new Nazvanie_Theme();
                formater = new XmlSerializer(typeof(Nazvanie_Theme));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
                }
                form.labelTheme1.Text = nazvanie.Name;
                form.Show();
                this.Hide();
            }
            else
            {
                form.Show();
                this.Hide();
            }

        }
       
        private void StudentButton_Click(object sender, EventArgs e)
        {
            StudentTasks1 form = new StudentTasks1();
            if (File.Exists("theme.xml"))
            {
                Nazvanie_Theme nazvanie = new Nazvanie_Theme();
                formater = new XmlSerializer(typeof(Nazvanie_Theme));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
                }
                form.Theme1.Text = nazvanie.Name;
                form.Show();
                this.Hide();
            }
            else
            {
                form.Show();
                this.Hide();
            }
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
