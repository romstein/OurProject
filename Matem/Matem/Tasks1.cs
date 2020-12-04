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
    public partial class Tasks1 : Form
    {
        public string StrokaTheme = "";
        public List<Mission> any = new List<Mission>();
        public List<Mission> localT = new List<Mission>();
        public List<Nazvanie_Theme> themes = new List<Nazvanie_Theme>();
        List<int> CountNans = new List<int>();
        public int currentIndexRadio = 0;
        public int currentRadioButton = 0;
        RadioButton[] radio = new RadioButton[1000];

        public int Nans = 0;
        public int localHeight = 0;

        public int panelLokation = 115;
        public int PanelConstanta = 0;
        public Panel[] panel = new Panel[100];

        TextBox[] textTask = new TextBox[100];
        public int currentIndexTextTask = 0;

        TextBox[] textAnswer = new TextBox[1000];
        public int currentIndexTextAnswer = 0;


        public Tasks1()
        {
            InitializeComponent();
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(KolichestvoAnswer.Text=="Введите количество ответов")
            {
                MessageBox.Show("Вы не ввели количество ответов");
            }
            else
            {
                panel[PanelConstanta] = new Panel();
                panel[PanelConstanta].Width = panel1.Width;
                panel[PanelConstanta].Height = 0;
                panel[PanelConstanta].Location = new Point(0, panelLokation);
                textTask[currentIndexTextTask] = new TextBox();
                textTask[currentIndexTextTask].Multiline = true;
                textTask[currentIndexTextTask].Width = panel1.Width;
                textTask[currentIndexTextTask].Height = 20;
                textTask[currentIndexTextTask].Font = new System.Drawing.Font("Times New Roman", 9);
                panel[PanelConstanta].Height += textTask[currentIndexTextTask].Height;
                panel[PanelConstanta].Controls.Add(textTask[currentIndexTextTask]);
                localHeight += textTask[currentIndexTextTask].Height;

                Nans = int.Parse(KolichestvoAnswer.Text);
                CountNans.Add(Nans);
                for (int i = currentIndexRadio; i < currentIndexRadio + Nans; i++)
                {
                    radio[i] = new RadioButton();
                    radio[i].Width = panel1.Width - 200;
                    radio[i].Height = 20;
                    radio[i].Location = new Point(0, localHeight);
                    radio[i].BackColor = Color.White; 
                    radio[i].Font = new System.Drawing.Font("Times New Roman", 9);
                    panel[PanelConstanta].Height += radio[i].Height;
                    panel[PanelConstanta].Controls.Add(radio[i]);
                    textAnswer[currentIndexTextAnswer] = new TextBox();
                    textAnswer[currentIndexTextAnswer].Width = 200;
                    textAnswer[currentIndexTextAnswer].Height = 20;
                    textAnswer[currentIndexTextAnswer].Location = new Point(radio[i].Width, localHeight);
                    textAnswer[currentIndexTextAnswer].Font = new System.Drawing.Font("Times New Roman", 9);
                    textAnswer[currentIndexTextAnswer].KeyDown += new System.Windows.Forms.KeyEventHandler(AddAnswer);
                    panel[PanelConstanta].Controls.Add(textAnswer[currentIndexTextAnswer]);
                    localHeight += radio[i].Height;
                    currentIndexTextAnswer++;
                }

                panel1.Controls.Add(panel[PanelConstanta]);
                CreateTheme.Location = new Point(0, panelLokation + panel[PanelConstanta].Height);
                currentIndexRadio += Nans;
                currentIndexTextTask++;
                localHeight += 5;
                PanelConstanta++;
                panelLokation += localHeight;
                localHeight = 0;
            }
            

        }

        private void AddAnswer(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (textAnswer[i].Focused)
                    {
                        radio[i].Text = textAnswer[i].Text;
                        break;
                    }
                }

            }
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            KolichestvoAnswer.Text = "";
        }

        private void toolStripTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PanelConstanta = int.Parse(KolichestvoAnswer.Text);
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


        private void ThemeZagolovok_Click(object sender, EventArgs e)
        {
            ThemeZagolovok.Text = StrokaTheme;
            ThemeZagolovok.BackColor = Color.White;
        }

        private void ThemeZagolovok_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StrokaTheme = ThemeZagolovok.Text;
                ThemeZagolovok.BackColor = Color.Honeydew;
            }
        }

        private void CreateTheme_Click(object sender, EventArgs e)
        {
            int ind = 0;
            int i = 0;
            XmlSerializer diser = new XmlSerializer(typeof(List<Mission>));
            if (File.Exists("bank.xml"))
            {
                using (FileStream fs = new FileStream("bank.xml", FileMode.OpenOrCreate))
                {
                    any = (List<Mission>)diser.Deserialize(fs);
                }
            }
            while ( i < radio.Length && ind<CountNans.Count)
            {
                Mission mr = new Mission();
                
                int n = CountNans[ind];
                for(int j = 0; j <n ;j++)
                {
                    Pair<string, bool> v = new Pair<string, bool>();
                    v.First = radio[i].Text;
                    v.Second = radio[i].Checked;
                    mr.answers.Add(v);
                    i++;

                }
                mr.Theme = StrokaTheme;
                mr.question = textTask[ind].Text;
                any.Add(mr);
                ind++;
            }
            XmlSerializer ser = new XmlSerializer(typeof(List<Mission>));
            if (File.Exists("bank.xml"))
            {
                File.Delete("bank.xml");
            }
            using (FileStream fs = new FileStream("bank.xml", FileMode.OpenOrCreate))
            {
                ser.Serialize(fs, any);
            }

            Nazvanie_Theme theme = new Nazvanie_Theme(StrokaTheme);
            XmlSerializer deformater = new XmlSerializer(typeof(List<Nazvanie_Theme>));
            if (File.Exists("theme.xml"))
            {
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    themes = (List<Nazvanie_Theme>)deformater.Deserialize(fs);
                }
                File.Delete("theme.xml");
            }
            themes.Add(theme);
            XmlSerializer formater = new XmlSerializer(typeof(List<Nazvanie_Theme>));
            using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
            {
                formater.Serialize(fs, themes);
            }
            MenuWithThemes menu = new MenuWithThemes();

            // Допустим у нас есть несколько созданных тем
            // Далее мы создаем новую тему
            // Когда создали и жмем на кнопку ,,создать тему,,
            // нужно при загрузке формы с темами для учителя вывести все имеющиеся темы в хранилище ,,theme.xml,,
            // Я это сделал сразу в логике кнопки ,,создать тему,,
            // 
            for(int j=0;j<themes.Count;j++)
            {
                switch(j)
                {
                    case 0:
                        {
                            menu.labelTheme1.Text = themes[0].Name;
                            break;
                        }
                    case 1:
                        {
                            menu.labelTheme2.Text = themes[1].Name;
                            break;
                        }
                    case 2:
                        {
                            menu.labelTheme3.Text = themes[2].Name;
                            break;
                        }
                    case 3:
                        {
                            menu.labelTheme4.Text = themes[3].Name;
                            break;
                        }
                    case 4:
                        {
                            menu.labelTheme5.Text = themes[4].Name;
                            break;
                        }
                    case 5:
                        {
                            menu.labelTheme6.Text = themes[5].Name;
                            break;
                        }
                    case 6:
                        {
                            menu.labelTheme7.Text = themes[6].Name;
                            break;
                        }
                    case 7:
                        {
                            menu.labelTheme8.Text = themes[7].Name;
                            break;
                        }
                    case 8:
                        {
                            menu.labelTheme9.Text = themes[8].Name;
                            break;
                        }
                    case 9:
                        {
                            menu.labelTheme10.Text = themes[9].Name;
                            break;
                        }
                }
            }

            //menu.labelTheme1.Text = StrokaTheme;
            menu.Show();
            this.Hide();


        }

        private void CreateTheme_MouseEnter(object sender, EventArgs e)
        {
            CreateTheme.BackColor = Color.DarkSlateGray;

        }

        private void CreateTheme_MouseLeave(object sender, EventArgs e)
        {
            CreateTheme.BackColor = Color.White;

        }
    }
}
