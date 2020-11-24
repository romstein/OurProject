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
    public partial class DeleteQuestionsForm : Form
    {
        public List<Mission> localLIST;
        public XmlSerializer formater,formater2;
        public CheckBox[] checks;
        public int localHEIGHT = 150;
        public DeleteQuestionsForm()
        {
            InitializeComponent();
        }

        public void CreateCheckBoxs()
        {
            formater = new XmlSerializer(typeof(List<Mission>));
            using (FileStream fs = new FileStream("local.xml", FileMode.OpenOrCreate))
            {
                localLIST = (List<Mission>)formater.Deserialize(fs);
            }
            checks = new CheckBox[localLIST.Count];
            for (int i = 0; i < localLIST.Count; i++)
            {
                checks[i] = new CheckBox();
                checks[i].Text = localLIST[i].question;
                checks[i].Width = panel1.Width;
                checks[i].BackColor = Color.White;
                checks[i].Height = 30;
                checks[i].Location = new Point(0, localHEIGHT);
                localHEIGHT += 30;
                panel1.Controls.Add(checks[i]);
            }
        }

        private void Vyvod_Click(object sender, EventArgs e)
        {
            CreateCheckBoxs();
            Delete.BackColor = Color.Lime;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            ChooseAction form = new ChooseAction();
            for(int i=0;i<checks.Length;i++)
            {
                if(checks[i].Checked)
                {
                    // Если этот checkBox помечен, то мы удаляем этот вопрос из localLIST
                    // Затем эти изменения должны быть применены к общему хранилищу, т. е. bank.xml
                    // 
                }
            }
            formater2 = new XmlSerializer(typeof(Nazvanie_Theme));
            Nazvanie_Theme s;
            using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
            {
                s = (Nazvanie_Theme)formater2.Deserialize(fs);
            }
            form.LabelTheme.Text = s.Name;
            form.Show();
            this.Hide();
        }
    }
}
