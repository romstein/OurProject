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
        public List<Task> any = new List<Task>();
        public int currentIndexRadio = 0;
        public int currentRadioButton = 0;
        RadioButton[] radio = new RadioButton[1000];

        public int Nans = 0;
        public int localHeight = 0;
        public int flagVyborOtveta = 0;

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
            panel[PanelConstanta] = new Panel();
            panel[PanelConstanta].Width = panel1.Width;
            panel[PanelConstanta].Height = 0;
            panel[PanelConstanta].Location = new Point(0, panelLokation);
            //panel[PanelConstanta].Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            textTask[currentIndexTextTask] = new TextBox();
            textTask[currentIndexTextTask].Multiline = true;
            textTask[currentIndexTextTask].Width = panel1.Width;
            textTask[currentIndexTextTask].Height = 20;
            textTask[currentIndexTextTask].Font = new System.Drawing.Font("Times New Roman", 9);
            // textTask[currentIndexTextTask].Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel[PanelConstanta].Height += textTask[currentIndexTextTask].Height;
            panel[PanelConstanta].Controls.Add(textTask[currentIndexTextTask]);
            localHeight += textTask[currentIndexTextTask].Height;

            Nans = int.Parse(KolichestvoAnswer.Text);
            if (flagVyborOtveta == 1)
            {
                for (int i = currentIndexRadio; i < currentIndexRadio + Nans; i++)
                {
                    radio[i] = new RadioButton();
                    radio[i].Width = panel1.Width - 200;
                    radio[i].Height = 20;
                    radio[i].Location = new Point(0, localHeight);
                    radio[i].BackColor = Color.Red;
                    radio[i].Font = new System.Drawing.Font("Times New Roman", 9);
                    //radio[i].Anchor = AnchorStyles.Left|AnchorStyles.Top|AnchorStyles.Right;
                    panel[PanelConstanta].Height += radio[i].Height;
                    panel[PanelConstanta].Controls.Add(radio[i]);
                    textAnswer[currentIndexTextAnswer] = new TextBox();
                    textAnswer[currentIndexTextAnswer].Width = 200;
                    textAnswer[currentIndexTextAnswer].Height = 20;
                    textAnswer[currentIndexTextAnswer].Location = new Point(radio[i].Width, localHeight);
                    textAnswer[currentIndexTextAnswer].Font = new System.Drawing.Font("Times New Roman", 9);
                    //textAnswer[currentIndexTextAnswer].Anchor = AnchorStyles.Right|AnchorStyles.Top|AnchorStyles.Left;
                    textAnswer[currentIndexTextAnswer].KeyDown += new System.Windows.Forms.KeyEventHandler(AddAnswer);
                    panel[PanelConstanta].Controls.Add(textAnswer[currentIndexTextAnswer]);
                    localHeight += radio[i].Height;
                    currentIndexTextAnswer++;
                }
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

        private void сОднимВариантомОтветаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flagVyborOtveta = 1;
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
                ThemeZagolovok.BackColor = Color.Yellow;
            }
        }

        private void CreateTheme_Click(object sender, EventArgs e)
        {
            Nazvanie_Theme theme = new Nazvanie_Theme(StrokaTheme);
            XmlSerializer formater = new XmlSerializer(typeof(Nazvanie_Theme));
            if (File.Exists("theme.xml"))
            {
                File.Delete("theme.xml");
            }
            using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
            {
                formater.Serialize(fs, theme);
            }
            MenuWithThemes menu = new MenuWithThemes();
            menu.labelTheme1.Text = StrokaTheme;
            menu.Show();
            this.Hide();


        }
    }
}
