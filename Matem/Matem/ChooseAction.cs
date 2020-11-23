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
        public XmlSerializer formater;

        private void Nazad_Click(object sender, EventArgs e)
        {
            MenuWithThemes form = new MenuWithThemes();
            Nazvanie_Theme nazvanie = new Nazvanie_Theme();
            formater = new XmlSerializer(typeof(Nazvanie_Theme));
            using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
            {
                nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
            }
            form.labelTheme1.Text = nazvanie.Name;
            form.Show();
            this.Hide();
        }

        private void AddQuestions_Click(object sender, EventArgs e)
        {
            AddQuestionsForm form = new AddQuestionsForm();
            Nazvanie_Theme nazvanie = new Nazvanie_Theme();
            formater = new XmlSerializer(typeof(Nazvanie_Theme));
            using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
            {
                nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
            }
            form.label1.Text = nazvanie.Name;
            form.Show();
            this.Hide();
        }

        private void DeleteQuestions_Click(object sender, EventArgs e)
        {
            DeleteQuestionsForm form = new DeleteQuestionsForm();
            Nazvanie_Theme nazvanie = new Nazvanie_Theme();
            formater = new XmlSerializer(typeof(Nazvanie_Theme));
            using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
            {
                nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
            }
            form.label1.Text = nazvanie.Name;
            form.Show();
            this.Hide();
        }
    }
}
