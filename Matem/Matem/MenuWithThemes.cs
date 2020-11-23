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
    public partial class MenuWithThemes : Form
    {
        public MenuWithThemes()
        {
            InitializeComponent();
        }

        private void closeButton_MouseClick(object sender, MouseEventArgs e)
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

        
        

        private void GoBack_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }

        private void labelTheme1_Click(object sender, EventArgs e)
        {
            Tasks1 t = new Tasks1();
            if (File.Exists("theme.xml"))
            {
                Nazvanie_Theme nazvanie = new Nazvanie_Theme();
                XmlSerializer formater = new XmlSerializer(typeof(Nazvanie_Theme));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
                }
                ChooseAction form = new ChooseAction();
                form.LabelTheme.Text = nazvanie.Name;
                form.Show();
                this.Hide();
            }
            else
            {
                t.ThemeZagolovok.Text = "Тема 1";
                t.Show();
                this.Hide();
            }
        }
    }
}
