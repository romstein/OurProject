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

        
       
        private void StudentButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("theme.xml"))
            {
                StudentTasks1 form = new StudentTasks1();
                List<Nazvanie_Theme> themes = new List<Nazvanie_Theme>();
                formater = new XmlSerializer(typeof(List<Nazvanie_Theme>));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    themes = (List<Nazvanie_Theme>)formater.Deserialize(fs);
                }
                for (int i = 0; i < themes.Count; i++)
                {
                    switch (i)
                    {
                        case 0:
                            {
                                form.Theme1.Text = themes[0].Name;
                                break;
                            }
                        case 1:
                            {
                                form.Theme2.Text = themes[1].Name;
                                break;
                            }
                        case 2:
                            {
                                form.Theme3.Text = themes[2].Name;
                                break;
                            }
                        case 3:
                            {
                                form.Theme4.Text = themes[3].Name;
                                break;
                            }
                        case 4:
                            {
                                form.Theme5.Text = themes[4].Name;
                                break;
                            }
                        case 5:
                            {
                                form.Theme6.Text = themes[5].Name;
                                break;
                            }
                        case 6:
                            {
                                form.Theme7.Text = themes[6].Name;
                                break;
                            }
                        case 7:
                            {
                                form.Theme8.Text = themes[7].Name;
                                break;
                            }
                        case 8:
                            {
                                form.Theme9.Text = themes[8].Name;
                                break;
                            }
                        case 9:
                            {
                                form.Theme10.Text = themes[9].Name;
                                break;
                            }
                    }
                }
                form.Show();
                this.Hide();
            }
            else
            {
                StudentTasks1 form = new StudentTasks1();
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

        

        private void StudentButton1_Click(object sender, EventArgs e)
        {
            if (File.Exists("theme.xml"))
            {
                StudentTasks1 form = new StudentTasks1();
                List<Nazvanie_Theme> themes = new List<Nazvanie_Theme>();
                formater = new XmlSerializer(typeof(List<Nazvanie_Theme>));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    themes = (List<Nazvanie_Theme>)formater.Deserialize(fs);
                }
                for (int i = 0; i < themes.Count; i++)
                {
                    switch (i)
                    {
                        case 0:
                            {
                                form.Theme1.Text = themes[0].Name;
                                break;
                            }
                        case 1:
                            {
                                form.Theme2.Text = themes[1].Name;
                                break;
                            }
                        case 2:
                            {
                                form.Theme3.Text = themes[2].Name;
                                break;
                            }
                        case 3:
                            {
                                form.Theme4.Text = themes[3].Name;
                                break;
                            }
                        case 4:
                            {
                                form.Theme5.Text = themes[4].Name;
                                break;
                            }
                        case 5:
                            {
                                form.Theme6.Text = themes[5].Name;
                                break;
                            }
                        case 6:
                            {
                                form.Theme7.Text = themes[6].Name;
                                break;
                            }
                        case 7:
                            {
                                form.Theme8.Text = themes[7].Name;
                                break;
                            }
                        case 8:
                            {
                                form.Theme9.Text = themes[8].Name;
                                break;
                            }
                        case 9:
                            {
                                form.Theme10.Text = themes[9].Name;
                                break;
                            }
                    }
                }
                form.Show();
                this.Hide();
            }
            else
            {
                StudentTasks1 form = new StudentTasks1();
                form.Show();
                this.Hide();
            }
        }

        private void TeacherButton1_Click(object sender, EventArgs e)
        {
            if (File.Exists("theme.xml"))
            {
                MenuWithThemes form = new MenuWithThemes();
                List<Nazvanie_Theme> themes = new List<Nazvanie_Theme>();
                formater = new XmlSerializer(typeof(List<Nazvanie_Theme>));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    themes = (List<Nazvanie_Theme>)formater.Deserialize(fs);
                }
                for (int i = 0; i < themes.Count; i++)
                {
                    switch (i)
                    {
                        case 0:
                            {
                                form.labelTheme1.Text = themes[0].Name;
                                break;
                            }
                        case 1:
                            {
                                form.labelTheme2.Text = themes[1].Name;
                                break;
                            }
                        case 2:
                            {
                                form.labelTheme3.Text = themes[2].Name;
                                break;
                            }
                        case 3:
                            {
                                form.labelTheme4.Text = themes[3].Name;
                                break;
                            }
                        case 4:
                            {
                                form.labelTheme5.Text = themes[4].Name;
                                break;
                            }
                        case 5:
                            {
                                form.labelTheme6.Text = themes[5].Name;
                                break;
                            }
                        case 6:
                            {
                                form.labelTheme7.Text = themes[6].Name;
                                break;
                            }
                        case 7:
                            {
                                form.labelTheme8.Text = themes[7].Name;
                                break;
                            }
                        case 8:
                            {
                                form.labelTheme9.Text = themes[8].Name;
                                break;
                            }
                        case 9:
                            {
                                form.labelTheme10.Text = themes[9].Name;
                                break;
                            }
                    }
                }
                form.Show();
                this.Hide();
            }
            else
            {
                MenuWithThemes form = new MenuWithThemes();
                form.Show();
                this.Hide();
            }
        }

        private void TeacherButton1_MouseEnter(object sender, EventArgs e)
        {
            TeacherButton1.BackColor = Color.DarkSlateGray;
            TeacherButton1.BackColor2 = Color.DarkSlateGray;
            TeacherButton1.ForeColor = Color.White;
        }

        private void TeacherButton1_MouseLeave(object sender, EventArgs e)
        {
            TeacherButton1.BackColor = Color.MintCream;
            TeacherButton1.BackColor2 = Color.MintCream;
            TeacherButton1.ForeColor = Color.Black;
        }

        private void StudentButton1_MouseEnter(object sender, EventArgs e)
        {
            StudentButton1.BackColor = Color.DarkSlateGray;
            StudentButton1.BackColor2 = Color.DarkSlateGray;
            StudentButton1.ForeColor = Color.White;
        }

        private void StudentButton1_MouseLeave(object sender, EventArgs e)
        {
            StudentButton1.BackColor = Color.MintCream;
            StudentButton1.BackColor2 = Color.MintCream;
            StudentButton1.ForeColor = Color.Black;
        }
    }
}
