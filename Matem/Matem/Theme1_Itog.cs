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
            Nazvanie_Theme nazvanie;
            formater = new XmlSerializer(typeof(Nazvanie_Theme));
            using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
            {
                nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
            }
            form.Theme1.Text = nazvanie.Name;
            form.Show();
            this.Hide();
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
                labels[i].Width = 20;
                labels[i].Height = 20;
                labels[i].Location = new Point(0, localHeight);
                labels[i].Text = x.ToString();
                labels[i].Font= new System.Drawing.Font("Times New Roman", 14);
                labels[i].BackColor = Color.White;
                answers[i] = new Label();
                answers[i].Width = 150;
                answers[i].Height = 20;
                answers[i].Location = new Point(20, localHeight);
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
