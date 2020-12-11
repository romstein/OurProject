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
    public partial class Theme1_Itog : Form
    {
        public Theme1_Itog()
        {
            InitializeComponent();
        }
        public XmlSerializer formater;
        public List<Mission> list;
        public int localHeight = 125;
        public int x1,y1;



        private void button1_Click(object sender, EventArgs e)
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
            this.Close();
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

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.MintCream;
            button1.ForeColor = Color.Black;
        }

        private void Theme1_Itog_Load(object sender, EventArgs e)
        {
            XmlSerializer diser = new XmlSerializer(typeof(List<Mission>));
            using (FileStream fs = new FileStream("Itog.xml", FileMode.OpenOrCreate))
            {
                list = (List<Mission>)diser.Deserialize(fs);
            }
            int Verno = 0;
            Label[] labels = new Label[list.Count];
            Label[] answers = new Label[list.Count];
            for (int i=0;i<list.Count;i++)
            {
                int x = i + 1;
                labels[i] = new Label();
                labels[i].Width = 30;
                labels[i].Height = 20;
                labels[i].Location = new Point(0, localHeight);
                labels[i].Text = x.ToString();
                labels[i].Font= new System.Drawing.Font("Times New Roman", 14);
                labels[i].BackColor = Color.White;
                answers[i] = new Label();
                answers[i].Width = 150;
                answers[i].Height = 20;
                answers[i].Location = new Point(30, localHeight);
                if (list[i].Status == true)
                {
                    answers[i].Text = "Правильно";
                    answers[i].Font = new System.Drawing.Font("Times New Roman", 14);
                    answers[i].ForeColor = Color.Green;
                    Verno++;
                }
                else
                {
                    answers[i].Text = "Неправильно";
                    answers[i].Font = new System.Drawing.Font("Times New Roman", 14);
                    answers[i].ForeColor = Color.Red;
                }
                answers[i].BackColor = Color.White;
                this.Controls.Add(labels[i]);
                this.Controls.Add(answers[i]);
                localHeight += 20;
            }
            x1 = (this.Width / 2) - 100;
            y1 = localHeight;
            Label otvet = new Label();
            otvet.Width = 300;
            otvet.Height = 20;
            otvet.Location = new Point(x1, y1);
            otvet.Text = $"Решено {Verno} из {list.Count}";
            otvet.Font = new System.Drawing.Font("Times New Roman", 14);
            this.Controls.Add(otvet);
            button1.Location = new Point(x1, y1 + otvet.Height);

        }
    }
    
}
