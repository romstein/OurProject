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
            Delete.BackColor = Color.MintCream;
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

        private void Vyvod_MouseEnter(object sender, EventArgs e)
        {
           Vyvod.BackColor = Color.DarkSlateGray;

        }

        private void Vyvod_MouseLeave(object sender, EventArgs e)
        {
            Vyvod.BackColor = Color.White;

        }

        private void Delete_MouseEnter(object sender, EventArgs e)
        {
            Delete.BackColor = Color.Red;

        }

        private void Delete_MouseLeave(object sender, EventArgs e)
        {
            Delete.BackColor = Color.Firebrick;

        }

        private void Delete_Click(object sender, EventArgs e)
        { 
            if(Delete.BackColor==Color.Red)
            {                
                List<Mission> any = new List<Mission>();
                XmlSerializer diser = new XmlSerializer(typeof(List<Mission>));
                using (FileStream fs = new FileStream("bank.xml", FileMode.OpenOrCreate))
                {
                    any = (List<Mission>)diser.Deserialize(fs);
                }
                string TemaEbat = localLIST[0].Theme;
                for (int i = 0; i < checks.Length; i++)
                {
                    if (checks[i].Checked)
                    {
                        foreach (var item in localLIST)
                        {

                            if (item.Theme == TemaEbat && item.question == checks[i].Text)
                            {
                                localLIST.Remove(item);
                                break;
                            }
                        }
                        foreach (var item in any)
                        {
                            
                            if (item.Theme == TemaEbat && item.question == checks[i].Text)
                            {
                                any.Remove(item);
                                break;
                            }
                        }
                        // Если этот checkBox помечен, то мы удаляем этот вопрос из localLIST
                        // Затем эти изменения должны быть применены к общему хранилищу, т. е. bank.xml
                        // 
                    }
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
                /*formater2 = new XmlSerializer(typeof(Nazvanie_Theme));
                Nazvanie_Theme s;
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    s = (Nazvanie_Theme)formater2.Deserialize(fs);
                }*/
                if(localLIST.Count!=0)
                {
                    ChooseAction form = new ChooseAction();
                    form.LabelTheme.Text = label1.Text;
                    form.Show();
                    this.Hide();
                }           
                else
                {
                    // Нужно удалить тему, если удалены все вопросы по этой теме

                    Nazvanie_Theme theme = new Nazvanie_Theme(label1.Text);
                    List<Nazvanie_Theme> themes = new List<Nazvanie_Theme>();
                    XmlSerializer deformater = new XmlSerializer(typeof(List<Nazvanie_Theme>));
                    if (File.Exists("theme.xml"))
                    {
                        using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                        {
                            themes = (List<Nazvanie_Theme>)deformater.Deserialize(fs);
                        }
                        File.Delete("theme.xml");
                    }
                    themes.Remove(theme);
                    XmlSerializer formater = new XmlSerializer(typeof(List<Nazvanie_Theme>));
                    using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                    {
                        formater.Serialize(fs, themes);
                    }
                    MenuWithThemes menu = new MenuWithThemes();

                    
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
                    this.Hide();
                }
            }
            
        }
    }
}
