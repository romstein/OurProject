using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;


namespace Matem
{
    public partial class Theme1_Zadachi : Form
    {
        public List<Mission> list = new List<Mission>();
        public int PanelConstanta = 0;
        public int panelLokation = 115;
        public Panel[] panel = new Panel[100];
        public Label[] textTask = new Label[100];
        public int currentIndexTextTask = 0;
        public int localHeight = 0;
        public int currentRadioButton = 0;
        public RadioButton[] radio = new RadioButton[1000];
 



        TextBox[] textAnswer = new TextBox[1000];
        public int currentIndexTextAnswer = 0;

        public Theme1_Zadachi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Theme1_Itog itog = new Theme1_Itog();
            
            int ind = 0;
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Status = false; // если вдруг идет повторное решение теста. Перед проверкой зануляю все статусы
                for (int j = 0; j < list[i].answers.Count; j++)
                {
                    if (radio[ind].Checked == true && list[i].answers[j].Second == true)
                    {
                        list[i].Status = true;

                    }
                    ind++;

                }
            }
            XmlSerializer ser = new XmlSerializer(typeof(List<Mission>));
            if (File.Exists("Itog.xml"))
            {
                File.Delete("Itog.xml");
            }
            using (FileStream fs = new FileStream("Itog.xml", FileMode.OpenOrCreate))
            {
                ser.Serialize(fs, list);
            }


            itog.label1.Text = label1.Text;
            itog.Show();
            this.Hide();
        }

        private void Theme1_Zadachi_Load(object sender, EventArgs e)
        {

            XmlSerializer formater = new XmlSerializer(typeof(List<Mission>));
            using (FileStream fs = new FileStream("listmission.xml", FileMode.OpenOrCreate))
            {

                list = (List<Mission>)formater.Deserialize(fs);

            }
            label1.Text = list[0].Theme;

            foreach (var item in list)
            {
                panel[PanelConstanta] = new Panel();
                panel[PanelConstanta].Width = panel1.Width;
                panel[PanelConstanta].Height = 0;
                panel[PanelConstanta].Location = new Point(0, panelLokation);
                textTask[currentIndexTextTask] = new Label();
                textTask[currentIndexTextTask].Width = this.Width;
                textTask[currentIndexTextTask].Height = 20;
                textTask[currentIndexTextTask].Font = new System.Drawing.Font("Times New Roman", 9);
                textTask[currentIndexTextTask].Text = item.question;
                textTask[currentIndexTextTask].BackColor= Color.Cyan;
                panel[PanelConstanta].Height += textTask[currentIndexTextTask].Height;
                panel[PanelConstanta].Controls.Add(textTask[currentIndexTextTask]);
                localHeight += textTask[currentIndexTextTask].Height;


                for (int i = 0; i < item.answers.Count; i++)
                {

                    radio[currentRadioButton] = new RadioButton();
                    radio[currentRadioButton].Width = this.Width;
                    radio[currentRadioButton].Height = 20;
                    radio[currentRadioButton].Location = new Point(0, localHeight);
                    radio[currentRadioButton].BackColor = Color.Beige;
                    radio[currentRadioButton].Font = new System.Drawing.Font("Times New Roman", 9);
                    radio[currentRadioButton].Text = item.answers[i].First;
                    panel[PanelConstanta].Height += radio[currentRadioButton].Height;
                    panel[PanelConstanta].Controls.Add(radio[currentRadioButton]);
                    localHeight += radio[currentRadioButton].Height;
                    currentRadioButton++;
                }
                this.Controls.Add(panel[PanelConstanta]);
                localHeight += 5;
                PanelConstanta++;
                currentIndexTextTask++;
                panelLokation += localHeight;
                localHeight = 0;
            }
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
    }
}
