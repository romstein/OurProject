﻿using System;
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
        Point lastPoint;

        public string StrokaTheme;
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
            int res;
            bool isInt = Int32.TryParse(KolichestvoAnswer.Text, out res);
            if (KolichestvoAnswer.Text=="Введите количество ответов")
            {
                MessageBox.Show("Вы не ввели количество ответов");
            }
            if (isInt == false)
            {
                MessageBox.Show("Введите количество ответов числом");
            }
            else
            {
                int countAnswers = int.Parse(KolichestvoAnswer.Text);
                if (countAnswers <= 0)
                {
                    MessageBox.Show("Количество ответов может быть только положительным и больше нуля");
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
                    textTask[currentIndexTextTask].Height = 300;
                    textTask[currentIndexTextTask].Font = new System.Drawing.Font("Times New Roman", 14);
                    panel[PanelConstanta].Height += textTask[currentIndexTextTask].Height;
                    panel[PanelConstanta].Controls.Add(textTask[currentIndexTextTask]);
                    localHeight += textTask[currentIndexTextTask].Height;

                    Nans = int.Parse(KolichestvoAnswer.Text);
                    CountNans.Add(Nans);
                    for (int i = currentIndexRadio; i < currentIndexRadio + Nans; i++)
                    {
                        radio[i] = new RadioButton();
                        radio[i].Width = panel1.Width - 200;
                        radio[i].Height = 30;
                        radio[i].Location = new Point(0, localHeight);
                        radio[i].BackColor = Color.White;
                        radio[i].Font = new System.Drawing.Font("Times New Roman", 14);
                        radio[i].Text = "";
                        radio[i].UseMnemonic = false;
                        panel[PanelConstanta].Height += radio[i].Height;
                        panel[PanelConstanta].Controls.Add(radio[i]);
                        textAnswer[currentIndexTextAnswer] = new TextBox();
                        textAnswer[currentIndexTextAnswer].Width = 200;
                        textAnswer[currentIndexTextAnswer].Height = 30;
                        textAnswer[currentIndexTextAnswer].Location = new Point(radio[i].Width, localHeight);
                        textAnswer[currentIndexTextAnswer].Font = new System.Drawing.Font("Times New Roman", 14);
                        textAnswer[currentIndexTextAnswer].KeyDown += new System.Windows.Forms.KeyEventHandler(AddAnswer);
                        panel[PanelConstanta].Controls.Add(textAnswer[currentIndexTextAnswer]);
                        localHeight += radio[i].Height;
                        currentIndexTextAnswer++;
                    }

                    panel1.Controls.Add(panel[PanelConstanta]);
                    CreateTheme1.Location = new Point(0, panelLokation + panel[PanelConstanta].Height);
                    currentIndexRadio += Nans;
                    currentIndexTextTask++;
                    localHeight += 5;
                    PanelConstanta++;
                    panelLokation += localHeight;
                    localHeight = 0;
                }
                
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

        private void CreateTheme1_Click(object sender, EventArgs e)
        {
            bool fal1 = false;
            bool fal2 = false;
            bool fal3 = false;
            bool fal4 = false;
            bool fal5 = false;
            int countRadioCheck = 0;
            if (PanelConstanta == 0)
            {
                fal5 = true;
            }
            for (int j = 0; j < currentIndexRadio; j++)
            {
                if (radio[j].Checked)
                {
                    countRadioCheck++;
                }
            }
            if (countRadioCheck != CountNans.Count)
            {
                fal4 = true;
            }
            if (ThemeZagolovok.Text == "Введите название темы" || ThemeZagolovok.Text == "")
            {
                fal3 = true;
            }
            for (int j = 0; j < currentIndexRadio; j++)
            {
                if (radio[j].Text == "")
                {
                    fal1 = true;
                    break;
                }
            }
            for (int j = 0; j < currentIndexTextTask; j++)
            {
                if (textTask[j].Text == "")
                {
                    fal2 = true;
                    break;
                }
            }
            if (fal1 || fal2 || fal3 || fal4 || fal5)
            {
                MessageBox.Show("Некорректные введенные данные");
            }
            else
            {
                int ind = 0;
                int i = 0;
                StrokaTheme = ThemeZagolovok.Text;
                XmlSerializer diser = new XmlSerializer(typeof(List<Mission>));
                if (File.Exists("bank.xml"))
                {
                    using (FileStream fs = new FileStream("bank.xml", FileMode.OpenOrCreate))
                    {
                        any = (List<Mission>)diser.Deserialize(fs);
                    }
                }
                while (i < radio.Length && ind < CountNans.Count)
                {
                    Mission mr = new Mission();

                    int n = CountNans[ind];
                    for (int j = 0; j < n; j++)
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
                for (int j = 0; j < themes.Count; j++)
                {
                    switch (j)
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
                this.Close();
            }
        }

        private void CreateTheme1_MouseEnter(object sender, EventArgs e)
        {
            CreateTheme1.BackColor = Color.DarkSlateGray;
            CreateTheme1.BackColor2 = Color.DarkSlateGray;
            CreateTheme1.ForeColor = Color.White;
        }

        private void CreateTheme1_MouseLeave(object sender, EventArgs e)
        {
            CreateTheme1.BackColor = Color.MintCream;
            CreateTheme1.BackColor2 = Color.MintCream;
            CreateTheme1.ForeColor = Color.Black;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ThemeZagolovok_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ThemeZagolovok_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
