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
    public partial class AddQuestionsForm : Form
    {
        public List<Mission> any = new List<Mission>();
        public List<Mission> localT = new List<Mission>();
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

        public AddQuestionsForm()
        {
            InitializeComponent();
        }

        

        private void AddQuestion_Click(object sender, EventArgs e)
        {
            if (KolichestvoAnswer.Text=="Введите количество ответов")
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
                DopolniteTheme1.Location = new Point(0, panelLokation + panel[PanelConstanta].Height);
                Nazad1.Location = new Point(325, panelLokation + panel[PanelConstanta].Height);
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

        

        private void KolichestvoAnswer_Click(object sender, EventArgs e)
        {
            KolichestvoAnswer.Text = "";
        }

        private void KolichestvoAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PanelConstanta = int.Parse(KolichestvoAnswer.Text);
            }
        }

        private void DopolniteTheme_Click(object sender, EventArgs e)
        {
            
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            
        }
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void DopolniteTheme1_Click(object sender, EventArgs e)
        {
            bool fal1 = false;
            bool fal2 = false;
            bool fal3 = false;
            bool fal4 = false;
            int countRadioCheck = 0;
            if (PanelConstanta == 0)
            {
                fal3 = true;
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
            if (fal1 || fal2 || fal3 || fal4)
            {
                MessageBox.Show("Некорректные введенные данные");
            }
            else
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
                    mr.Theme = label1.Text;
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
                ChooseAction menu = new ChooseAction();
                menu.LabelTheme.Text = label1.Text;
                menu.Show();
                this.Close();
            }
        }

        private void Nazad1_Click(object sender, EventArgs e)
        {
            ChooseAction form = new ChooseAction();
            form.LabelTheme.Text = label1.Text;
            form.Show();
            this.Close();
        }

        private void DopolniteTheme1_MouseEnter(object sender, EventArgs e)
        {
            DopolniteTheme1.BackColor = Color.DarkSlateGray;
            DopolniteTheme1.BackColor2 = Color.DarkSlateGray;
            DopolniteTheme1.ForeColor = Color.White;
        }

        private void DopolniteTheme1_MouseLeave(object sender, EventArgs e)
        {
            DopolniteTheme1.BackColor = Color.MintCream;
            DopolniteTheme1.BackColor2 = Color.MintCream;
            DopolniteTheme1.ForeColor = Color.Black;
        }

        private void Nazad1_MouseEnter(object sender, EventArgs e)
        {
            Nazad1.BackColor = Color.DarkSlateGray;
            Nazad1.BackColor2 = Color.DarkSlateGray;
            Nazad1.ForeColor = Color.White;
        }

        private void Nazad1_MouseLeave(object sender, EventArgs e)
        {
            Nazad1.BackColor = Color.MintCream;
            Nazad1.BackColor2 = Color.MintCream;
            Nazad1.ForeColor = Color.Black;
        }
    }
}
