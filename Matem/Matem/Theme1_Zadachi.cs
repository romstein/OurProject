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
        int [] forRandom;
        List<Mission> forResult=new List<Mission>();



        TextBox[] textAnswer = new TextBox[1000];
        public int currentIndexTextAnswer = 0;

        public Theme1_Zadachi()
        {
            InitializeComponent();
        }

        private void Theme1_Zadachi_Load(object sender, EventArgs e)
        {

            XmlSerializer formater = new XmlSerializer(typeof(List<Mission>));
            using (FileStream fs = new FileStream("listmission.xml", FileMode.OpenOrCreate))
            {

                list = (List<Mission>)formater.Deserialize(fs);

            }
            forRandom = new int [list.Count];
            List<Mission> any = new List<Mission>();
            label1.Text = list[0].Theme;
            using (FileStream fs = new FileStream("listmission.xml", FileMode.OpenOrCreate))
            {

                any = (List<Mission>)formater.Deserialize(fs);

            }
            int ind = 0;
            while (any.Count > 0)
            {
                Random r = new Random();
                int RandomIndex = r.Next(any.Count);
                Mission a = any[RandomIndex];
                for (int kol = 0; kol < list.Count; kol++)
                {
                    if (list[kol].question == a.question)
                    {
                        bool k = false;
                        for (int pr = 0; pr < a.answers.Count; pr++)
                        {
                            if (a.answers[pr].First != list[kol].answers[pr].First || a.answers[pr].Second != list[kol].answers[pr].Second)
                            {
                                k = true;
                            }
                        }
                        if (k == false)
                        {
                            forRandom[ind] = kol;
                        }
                        
                    }
                    
                }
                
                ind++;
                
                panel[PanelConstanta] = new Panel();
                panel[PanelConstanta].Width = panel1.Width;
                panel[PanelConstanta].Height = 0;
                panel[PanelConstanta].Location = new Point(0, panelLokation);
                textTask[currentIndexTextTask] = new Label();
                textTask[currentIndexTextTask].Width = this.Width;
                textTask[currentIndexTextTask].Height = 20;
                textTask[currentIndexTextTask].Font = new System.Drawing.Font("Times New Roman", 9);
                textTask[currentIndexTextTask].Text = any[RandomIndex].question;
                textTask[currentIndexTextTask].BackColor = Color.SkyBlue;
                panel[PanelConstanta].Height += textTask[currentIndexTextTask].Height;
                panel[PanelConstanta].Controls.Add(textTask[currentIndexTextTask]);
                localHeight += textTask[currentIndexTextTask].Height;


                for (int i = 0; i < any[RandomIndex].answers.Count; i++)
                {

                    radio[currentRadioButton] = new RadioButton();
                    radio[currentRadioButton].Width = this.Width;
                    radio[currentRadioButton].Height = 20;
                    radio[currentRadioButton].Location = new Point(0, localHeight);
                    radio[currentRadioButton].BackColor = Color.Honeydew;
                    radio[currentRadioButton].Font = new System.Drawing.Font("Times New Roman", 9);
                    radio[currentRadioButton].Text = any[RandomIndex].answers[i].First;
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
                any.RemoveAt(RandomIndex);
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

        private void Proverka_Click(object sender, EventArgs e)
        {
            Theme1_Itog itog = new Theme1_Itog();
            XmlSerializer formater = new XmlSerializer(typeof(List<Mission>));
            using (FileStream fs = new FileStream("listmission.xml", FileMode.OpenOrCreate))
            {

                list = (List<Mission>)formater.Deserialize(fs);

            }

            int ind = 0;
            for (int i = 0; i < forRandom.Length; i++)
            {
                int vr = forRandom[i];
                forResult.Add(list[vr]);
                list[vr].Status = false;// если вдруг идет повторное решение теста. Перед проверкой зануляю все статусы
                for (int j = 0; j < list[vr].answers.Count; j++)
                {
                    if (radio[ind].Checked == true && list[vr].answers[j].Second == true)
                    {
                        list[vr].Status = true;

                    }
                    ind++;
                }
            }
            //for (int i = 0; i < list.Count; i++)
            //{
            //    list[i].Status = false; // если вдруг идет повторное решение теста. Перед проверкой зануляю все статусы
            //    for (int j = 0; j < list[i].answers.Count; j++)
            //    {
            //        if (radio[ind].Checked == true && list[i].answers[j].Second == true)
            //        {
            //            list[i].Status = true;

            //        }
            //        ind++;

            //    }
            //}
            XmlSerializer ser = new XmlSerializer(typeof(List<Mission>));
            if (File.Exists("Itog.xml"))
            {
                File.Delete("Itog.xml");
            }
            using (FileStream fs = new FileStream("Itog.xml", FileMode.OpenOrCreate))
            {
                ser.Serialize(fs, forResult);
            }


            itog.label1.Text = label1.Text;
            itog.Show();
            this.Close();
        }

        private void Proverka_MouseEnter(object sender, EventArgs e)
        {
            Proverka.BackColor = Color.DarkSlateGray;
            Proverka.BackColor2 = Color.DarkSlateGray;
            Proverka.ForeColor = Color.White;
        }

        private void Proverka_MouseLeave(object sender, EventArgs e)
        {
            Proverka.BackColor = Color.MintCream;
            Proverka.BackColor2 = Color.MintCream;
            Proverka.ForeColor = Color.Black;
        }
    }
}
