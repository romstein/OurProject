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
    public partial class ChooseAction : Form
    {
        public ChooseAction()
        {
            InitializeComponent();
        }
        public XmlSerializer formater,formater2,formater3;
        public List<Mission> any;
        public List<Mission> themeQuestions;

        private void Nazad_Click(object sender, EventArgs e)
        {
            MenuWithThemes form = new MenuWithThemes();
            List<Nazvanie_Theme> listThemes = new List<Nazvanie_Theme>();
            formater = new XmlSerializer(typeof(List<Nazvanie_Theme>));
            using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
            {
                listThemes = (List<Nazvanie_Theme>)formater.Deserialize(fs);
            }
            for(int i=0;i<listThemes.Count;i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            form.labelTheme1.Text = listThemes[0].Name;
                            break;
                        }
                    case 1:
                        {
                            form.labelTheme2.Text = listThemes[1].Name;
                            break;
                        }
                    case 2:
                        {
                            form.labelTheme3.Text = listThemes[2].Name;
                            break;
                        }
                    case 3:
                        {
                            form.labelTheme4.Text = listThemes[3].Name;
                            break;
                        }
                    case 4:
                        {
                            form.labelTheme5.Text = listThemes[4].Name;
                            break;
                        }
                    case 5:
                        {
                            form.labelTheme6.Text = listThemes[5].Name;
                            break;
                        }
                    case 6:
                        {
                            form.labelTheme7.Text = listThemes[6].Name;
                            break;
                        }
                    case 7:
                        {
                            form.labelTheme8.Text = listThemes[7].Name;
                            break;
                        }
                    case 8:
                        {
                            form.labelTheme9.Text = listThemes[8].Name;
                            break;
                        }
                    case 9:
                        {
                            form.labelTheme10.Text = listThemes[9].Name;
                            break;
                        }
                }
            }

            //form.labelTheme1.Text = nazvanie.Name;
            form.Show();
            this.Hide();
        }

        private void AddQuestions_Click(object sender, EventArgs e)
        {
            AddQuestionsForm form = new AddQuestionsForm();
            /*Nazvanie_Theme nazvanie = new Nazvanie_Theme();
            formater = new XmlSerializer(typeof(Nazvanie_Theme));
            using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
            {
                nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
            }*/
            form.label1.Text = LabelTheme.Text;
            form.Show();
            this.Hide();
        }

        private void DeleteQuestions_Click(object sender, EventArgs e)
        {
            DeleteQuestionsForm form = new DeleteQuestionsForm();
            /*Nazvanie_Theme nazvanie = new Nazvanie_Theme();
            formater = new XmlSerializer(typeof(Nazvanie_Theme));
            using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
            {
                nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
            }*/
            form.label1.Text = this.LabelTheme.Text;
            formater2 = new XmlSerializer(typeof(List<Mission>));
            using (FileStream fs = new FileStream("bank.xml", FileMode.OpenOrCreate))
            {
                any = (List<Mission>)formater2.Deserialize(fs);
            }
            themeQuestions = new List<Mission>();
            foreach(var t in any)
            {
                if(t.Theme==LabelTheme.Text)
                {
                    themeQuestions.Add(t);
                }
            }
            if(File.Exists("local.xml"))
            {
                File.Delete("local.xml");
                formater3 = new XmlSerializer(typeof(List<Mission>));
                using (FileStream fs = new FileStream("local.xml", FileMode.OpenOrCreate))
                {
                    formater3.Serialize(fs, themeQuestions);
                }
            }
            else
            {
                formater3 = new XmlSerializer(typeof(List<Mission>));
                using (FileStream fs = new FileStream("local.xml", FileMode.OpenOrCreate))
                {
                    formater3.Serialize(fs, themeQuestions);
                }
            }            
            form.Show();
            this.Hide();
        }
    }
}
