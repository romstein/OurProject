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
            this.Close();
        }

        private void labelTheme1_Click(object sender, EventArgs e)
        {            
            if (File.Exists("theme.xml"))
            {
                List<Nazvanie_Theme> listThemes = new List<Nazvanie_Theme>();
                XmlSerializer formater = new XmlSerializer(typeof(List<Nazvanie_Theme>));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    listThemes = (List<Nazvanie_Theme>)formater.Deserialize(fs);
                }
                

                Nazvanie_Theme nazvanie1 = new Nazvanie_Theme(labelTheme1.Text);

                if(listThemes.Contains(nazvanie1))
                {
                    ChooseAction form = new ChooseAction();
                    form.LabelTheme.Text = nazvanie1.Name;
                    form.Show();
                    this.Close();
                }
                else
                {
                    Tasks1 t = new Tasks1();
                    t.ThemeZagolovok.Text = "Введите название темы";
                    t.Show();
                    this.Close();
                }
                
                
            }
            else
            {
                Tasks1 t = new Tasks1();
                t.ThemeZagolovok.Text = "Введите название темы";
                t.Show();
                this.Close();
            }
        }

        private void labelTheme2_Click(object sender, EventArgs e)
        {
            if (File.Exists("theme.xml"))
            {
                List<Nazvanie_Theme> listThemes = new List<Nazvanie_Theme>();
                XmlSerializer formater = new XmlSerializer(typeof(List<Nazvanie_Theme>));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    listThemes = (List<Nazvanie_Theme>)formater.Deserialize(fs);
                }


                Nazvanie_Theme nazvanie2 = new Nazvanie_Theme(labelTheme2.Text);

                if (listThemes.Contains(nazvanie2))
                {
                    ChooseAction form = new ChooseAction();
                    form.LabelTheme.Text = nazvanie2.Name;
                    form.Show();
                    this.Close();
                }
                else
                {
                    Tasks1 t = new Tasks1();
                    t.ThemeZagolovok.Text = "Введите название темы";
                    t.Show();
                    this.Close();
                }


            }
            else
            {
                Tasks1 t = new Tasks1();
                t.ThemeZagolovok.Text = "Введите название темы";
                t.Show();
                this.Close();
            }
        }

        private void labelTheme3_Click(object sender, EventArgs e)
        {
            if (File.Exists("theme.xml"))
            {
                List<Nazvanie_Theme> listThemes = new List<Nazvanie_Theme>();
                XmlSerializer formater = new XmlSerializer(typeof(List<Nazvanie_Theme>));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    listThemes = (List<Nazvanie_Theme>)formater.Deserialize(fs);
                }


                Nazvanie_Theme nazvanie3 = new Nazvanie_Theme(labelTheme3.Text);

                if (listThemes.Contains(nazvanie3))
                {
                    ChooseAction form = new ChooseAction();
                    form.LabelTheme.Text = nazvanie3.Name;
                    form.Show();
                    this.Close();
                }
                else
                {
                    Tasks1 t = new Tasks1();
                    t.ThemeZagolovok.Text = "Введите название темы";
                    t.Show();
                    this.Close();
                }


            }
            else
            {
                Tasks1 t = new Tasks1();
                t.ThemeZagolovok.Text = "Введите название темы";
                t.Show();
                this.Close();
            }
        }

        private void labelTheme4_Click(object sender, EventArgs e)
        {
            if (File.Exists("theme.xml"))
            {
                List<Nazvanie_Theme> listThemes = new List<Nazvanie_Theme>();
                XmlSerializer formater = new XmlSerializer(typeof(List<Nazvanie_Theme>));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    listThemes = (List<Nazvanie_Theme>)formater.Deserialize(fs);
                }


                Nazvanie_Theme nazvanie4 = new Nazvanie_Theme(labelTheme4.Text);

                if (listThemes.Contains(nazvanie4))
                {
                    ChooseAction form = new ChooseAction();
                    form.LabelTheme.Text = nazvanie4.Name;
                    form.Show();
                    this.Close();
                }
                else
                {
                    Tasks1 t = new Tasks1();
                    t.ThemeZagolovok.Text = "Введите название темы";
                    t.Show();
                    this.Close();
                }


            }
            else
            {
                Tasks1 t = new Tasks1();
                t.ThemeZagolovok.Text = "Введите название темы";
                t.Show();
                this.Close();
            }
        }

        private void labelTheme5_Click(object sender, EventArgs e)
        {
            if (File.Exists("theme.xml"))
            {
                List<Nazvanie_Theme> listThemes = new List<Nazvanie_Theme>();
                XmlSerializer formater = new XmlSerializer(typeof(List<Nazvanie_Theme>));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    listThemes = (List<Nazvanie_Theme>)formater.Deserialize(fs);
                }


                Nazvanie_Theme nazvanie5 = new Nazvanie_Theme(labelTheme5.Text);

                if (listThemes.Contains(nazvanie5))
                {
                    ChooseAction form = new ChooseAction();
                    form.LabelTheme.Text = nazvanie5.Name;
                    form.Show();
                    this.Close();
                }
                else
                {
                    Tasks1 t = new Tasks1();
                    t.ThemeZagolovok.Text = "Введите название темы";
                    t.Show();
                    this.Close();
                }


            }
            else
            {
                Tasks1 t = new Tasks1();
                t.ThemeZagolovok.Text = "Введите название темы";
                t.Show();
                this.Close();
            }
        }

        private void labelTheme6_Click(object sender, EventArgs e)
        {
            if (File.Exists("theme.xml"))
            {
                List<Nazvanie_Theme> listThemes = new List<Nazvanie_Theme>();
                XmlSerializer formater = new XmlSerializer(typeof(List<Nazvanie_Theme>));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    listThemes = (List<Nazvanie_Theme>)formater.Deserialize(fs);
                }


                Nazvanie_Theme nazvanie6 = new Nazvanie_Theme(labelTheme6.Text);

                if (listThemes.Contains(nazvanie6))
                {
                    ChooseAction form = new ChooseAction();
                    form.LabelTheme.Text = nazvanie6.Name;
                    form.Show();
                    this.Close();
                }
                else
                {
                    Tasks1 t = new Tasks1();
                    t.ThemeZagolovok.Text = "Введите название темы";
                    t.Show();
                    this.Close();
                }


            }
            else
            {
                Tasks1 t = new Tasks1();
                t.ThemeZagolovok.Text = "Введите название темы";
                t.Show();
                this.Close();
            }
        }

        private void labelTheme7_Click(object sender, EventArgs e)
        {
            if (File.Exists("theme.xml"))
            {
                List<Nazvanie_Theme> listThemes = new List<Nazvanie_Theme>();
                XmlSerializer formater = new XmlSerializer(typeof(List<Nazvanie_Theme>));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    listThemes = (List<Nazvanie_Theme>)formater.Deserialize(fs);
                }


                Nazvanie_Theme nazvanie7 = new Nazvanie_Theme(labelTheme7.Text);

                if (listThemes.Contains(nazvanie7))
                {
                    ChooseAction form = new ChooseAction();
                    form.LabelTheme.Text = nazvanie7.Name;
                    form.Show();
                    this.Close();
                }
                else
                {
                    Tasks1 t = new Tasks1();
                    t.ThemeZagolovok.Text = "Введите название темы";
                    t.Show();
                    this.Close();
                }


            }
            else
            {
                Tasks1 t = new Tasks1();
                t.ThemeZagolovok.Text = "Введите название темы";
                t.Show();
                this.Close();
            }
        }

        private void labelTheme8_Click(object sender, EventArgs e)
        {
            if (File.Exists("theme.xml"))
            {
                List<Nazvanie_Theme> listThemes = new List<Nazvanie_Theme>();
                XmlSerializer formater = new XmlSerializer(typeof(List<Nazvanie_Theme>));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    listThemes = (List<Nazvanie_Theme>)formater.Deserialize(fs);
                }


                Nazvanie_Theme nazvanie8 = new Nazvanie_Theme(labelTheme8.Text);

                if (listThemes.Contains(nazvanie8))
                {
                    ChooseAction form = new ChooseAction();
                    form.LabelTheme.Text = nazvanie8.Name;
                    form.Show();
                    this.Close();
                }
                else
                {
                    Tasks1 t = new Tasks1();
                    t.ThemeZagolovok.Text = "Введите название темы";
                    t.Show();
                    this.Close();
                }


            }
            else
            {
                Tasks1 t = new Tasks1();
                t.ThemeZagolovok.Text = "Введите название темы";
                t.Show();
                this.Close();
            }
        }

        private void labelTheme9_Click(object sender, EventArgs e)
        {
            if (File.Exists("theme.xml"))
            {
                List<Nazvanie_Theme> listThemes = new List<Nazvanie_Theme>();
                XmlSerializer formater = new XmlSerializer(typeof(List<Nazvanie_Theme>));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    listThemes = (List<Nazvanie_Theme>)formater.Deserialize(fs);
                }


                Nazvanie_Theme nazvanie9 = new Nazvanie_Theme(labelTheme9.Text);

                if (listThemes.Contains(nazvanie9))
                {
                    ChooseAction form = new ChooseAction();
                    form.LabelTheme.Text = nazvanie9.Name;
                    form.Show();
                    this.Close();
                }
                else
                {
                    Tasks1 t = new Tasks1();
                    t.ThemeZagolovok.Text = "Введите название темы";
                    t.Show();
                    this.Close();
                }


            }
            else
            {
                Tasks1 t = new Tasks1();
                t.ThemeZagolovok.Text = "Введите название темы";
                t.Show();
                this.Close();
            }
        }
        

       

        
        private void labelTheme10_Click(object sender, EventArgs e)
        {
            if (File.Exists("theme.xml"))
            {
                List<Nazvanie_Theme> listThemes = new List<Nazvanie_Theme>();
                XmlSerializer formater = new XmlSerializer(typeof(List<Nazvanie_Theme>));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    listThemes = (List<Nazvanie_Theme>)formater.Deserialize(fs);
                }


                Nazvanie_Theme nazvanie10 = new Nazvanie_Theme(labelTheme10.Text);

                if (listThemes.Contains(nazvanie10))
                {
                    ChooseAction form = new ChooseAction();
                    form.LabelTheme.Text = nazvanie10.Name;
                    form.Show();
                    this.Close();
                }
                else
                {
                    Tasks1 t = new Tasks1();
                    t.ThemeZagolovok.Text = "Введите название темы";
                    t.Show();
                    this.Close();
                }


            }
            else
            {
                Tasks1 t = new Tasks1();
                t.ThemeZagolovok.Text = "Введите название темы";
                t.Show();
                this.Close();
            }

        }

        private void labelTheme1_MouseEnter(object sender, EventArgs e)
        {
            labelTheme1.ForeColor = Color.Red;
        }

        private void labelTheme1_MouseLeave(object sender, EventArgs e)
        {
            labelTheme1.ForeColor = Color.Black;
        }

        private void labelTheme2_MouseLeave(object sender, EventArgs e)
        {
            labelTheme2.ForeColor = Color.Black;
        }
        private void labelTheme2_MouseEnter(object sender, EventArgs e)
        {
            labelTheme2.ForeColor = Color.Red;
        }

        private void labelTheme3_MouseEnter(object sender, EventArgs e)
        {
            labelTheme3.ForeColor = Color.Red;
        }

        private void labelTheme3_MouseLeave(object sender, EventArgs e)
        {
            labelTheme3.ForeColor = Color.Black;
        }

        private void labelTheme4_MouseEnter(object sender, EventArgs e)
        {
            labelTheme4.ForeColor = Color.Red;
        }

        private void labelTheme4_MouseLeave(object sender, EventArgs e)
        {
            labelTheme4.ForeColor = Color.Black;
        }

        private void labelTheme5_MouseEnter(object sender, EventArgs e)
        {
            labelTheme5.ForeColor = Color.Red;
        }

        private void labelTheme5_MouseLeave(object sender, EventArgs e)
        {
            labelTheme5.ForeColor = Color.Black;

        }

        private void labelTheme6_MouseEnter(object sender, EventArgs e)
        {
            labelTheme6.ForeColor = Color.Red;

        }

        private void labelTheme6_MouseLeave(object sender, EventArgs e)
        {
            labelTheme6.ForeColor = Color.Black;

        }

        private void labelTheme7_MouseEnter(object sender, EventArgs e)
        {
            labelTheme7.ForeColor = Color.Red;

        }

        private void labelTheme7_MouseLeave(object sender, EventArgs e)
        {
            labelTheme7.ForeColor = Color.Black;

        }

        private void labelTheme8_MouseEnter(object sender, EventArgs e)
        {
            labelTheme8.ForeColor = Color.Red;

        }

        private void labelTheme8_MouseLeave(object sender, EventArgs e)
        {
            labelTheme8.ForeColor = Color.Black;

        }

        private void labelTheme9_MouseEnter(object sender, EventArgs e)
        {
            labelTheme9.ForeColor = Color.Red;

        }

        private void labelTheme9_MouseLeave(object sender, EventArgs e)
        {
            labelTheme9.ForeColor = Color.Black;

        }

        private void labelTheme10_MouseEnter(object sender, EventArgs e)
        {
            labelTheme10.ForeColor = Color.Red;

        }

        private void labelTheme10_MouseLeave(object sender, EventArgs e)
        {
            labelTheme10.ForeColor = Color.Black;

        }

        

        private void GoBack1_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Close();
        }

        private void GoBack1_MouseEnter(object sender, EventArgs e)
        {
            GoBack1.BackColor = Color.DarkSlateGray;
            GoBack1.BackColor2 = Color.DarkSlateGray;
            GoBack1.ForeColor = Color.White;
        }

        private void GoBack1_MouseLeave(object sender, EventArgs e)
        {
            GoBack1.BackColor = Color.MintCream;
            GoBack1.BackColor2 = Color.MintCream;
            GoBack1.ForeColor = Color.Black;
        }
    }
}
