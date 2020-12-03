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
    public partial class StudentTasks1 : Form
    {
        public StudentTasks1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }

        private void Theme1_Click(object sender, EventArgs e)
        {
            if(Theme1.Text!="---")
            {
                Theme1_Zadachi form = new Theme1_Zadachi();
                List<Mission> any = new List<Mission>();
                XmlSerializer diser = new XmlSerializer(typeof(List<Mission>));
                using (FileStream fs = new FileStream("bank.xml", FileMode.OpenOrCreate))
                {
                    any = (List<Mission>)diser.Deserialize(fs);
                }
                /*Nazvanie_Theme nazvanie = new Nazvanie_Theme();
                XmlSerializer formater = new XmlSerializer(typeof(Nazvanie_Theme));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
                }*/
                List<Mission> list = new List<Mission>();
                foreach (var item in any)
                {
                    if (item.Theme == Theme1.Text)
                    {
                        list.Add(item);
                    }
                }
                XmlSerializer formatterlist = new XmlSerializer(typeof(List<Mission>));


                if (File.Exists("listmission.xml"))
                {
                    File.Delete("listmission.xml");
                }
                using (FileStream fs = new FileStream("listmission.xml", FileMode.OpenOrCreate))
                {
                    formatterlist.Serialize(fs, list);
                }
                form.Show();
                this.Hide();
            }
            
        }

        void SearchThemes(List<Mission> any, List<string> thm) //метод находит все уникальные темы в хранилище
        {
           
            foreach (var item in any)
            {
                if (thm.Contains(item.Theme) == false)
                {
                    thm.Add(item.Theme);
                }
            }
        }

        private void Theme2_Click(object sender, EventArgs e)
        {
            if (Theme2.Text != "---")
            {
                Theme1_Zadachi form = new Theme1_Zadachi();
                List<Mission> any = new List<Mission>();
                XmlSerializer diser = new XmlSerializer(typeof(List<Mission>));
                using (FileStream fs = new FileStream("bank.xml", FileMode.OpenOrCreate))
                {
                    any = (List<Mission>)diser.Deserialize(fs);
                }
                /*Nazvanie_Theme nazvanie = new Nazvanie_Theme();
                XmlSerializer formater = new XmlSerializer(typeof(Nazvanie_Theme));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
                }*/
                List<Mission> list = new List<Mission>();
                foreach (var item in any)
                {
                    if (item.Theme == Theme2.Text)
                    {
                        list.Add(item);
                    }
                }
                XmlSerializer formatterlist = new XmlSerializer(typeof(List<Mission>));


                if (File.Exists("listmission.xml"))
                {
                    File.Delete("listmission.xml");
                }
                using (FileStream fs = new FileStream("listmission.xml", FileMode.OpenOrCreate))
                {
                    formatterlist.Serialize(fs, list);
                }
                form.Show();
                this.Hide();
            }
        }

        private void Theme3_Click(object sender, EventArgs e)
        {
            if (Theme3.Text != "---")
            {
                Theme1_Zadachi form = new Theme1_Zadachi();
                List<Mission> any = new List<Mission>();
                XmlSerializer diser = new XmlSerializer(typeof(List<Mission>));
                using (FileStream fs = new FileStream("bank.xml", FileMode.OpenOrCreate))
                {
                    any = (List<Mission>)diser.Deserialize(fs);
                }
                /*Nazvanie_Theme nazvanie = new Nazvanie_Theme();
                XmlSerializer formater = new XmlSerializer(typeof(Nazvanie_Theme));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
                }*/
                List<Mission> list = new List<Mission>();
                foreach (var item in any)
                {
                    if (item.Theme == Theme3.Text)
                    {
                        list.Add(item);
                    }
                }
                XmlSerializer formatterlist = new XmlSerializer(typeof(List<Mission>));


                if (File.Exists("listmission.xml"))
                {
                    File.Delete("listmission.xml");
                }
                using (FileStream fs = new FileStream("listmission.xml", FileMode.OpenOrCreate))
                {
                    formatterlist.Serialize(fs, list);
                }
                form.Show();
                this.Hide();
            }
        }

        private void Theme4_Click(object sender, EventArgs e)
        {
            if (Theme4.Text != "---")
            {
                Theme1_Zadachi form = new Theme1_Zadachi();
                List<Mission> any = new List<Mission>();
                XmlSerializer diser = new XmlSerializer(typeof(List<Mission>));
                using (FileStream fs = new FileStream("bank.xml", FileMode.OpenOrCreate))
                {
                    any = (List<Mission>)diser.Deserialize(fs);
                }
                /*Nazvanie_Theme nazvanie = new Nazvanie_Theme();
                XmlSerializer formater = new XmlSerializer(typeof(Nazvanie_Theme));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
                }*/
                List<Mission> list = new List<Mission>();
                foreach (var item in any)
                {
                    if (item.Theme == Theme4.Text)
                    {
                        list.Add(item);
                    }
                }
                XmlSerializer formatterlist = new XmlSerializer(typeof(List<Mission>));


                if (File.Exists("listmission.xml"))
                {
                    File.Delete("listmission.xml");
                }
                using (FileStream fs = new FileStream("listmission.xml", FileMode.OpenOrCreate))
                {
                    formatterlist.Serialize(fs, list);
                }
                form.Show();
                this.Hide();
            }
        }

        private void Theme5_Click(object sender, EventArgs e)
        {
            if (Theme5.Text != "---")
            {
                Theme1_Zadachi form = new Theme1_Zadachi();
                List<Mission> any = new List<Mission>();
                XmlSerializer diser = new XmlSerializer(typeof(List<Mission>));
                using (FileStream fs = new FileStream("bank.xml", FileMode.OpenOrCreate))
                {
                    any = (List<Mission>)diser.Deserialize(fs);
                }
                /*Nazvanie_Theme nazvanie = new Nazvanie_Theme();
                XmlSerializer formater = new XmlSerializer(typeof(Nazvanie_Theme));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
                }*/
                List<Mission> list = new List<Mission>();
                foreach (var item in any)
                {
                    if (item.Theme == Theme5.Text)
                    {
                        list.Add(item);
                    }
                }
                XmlSerializer formatterlist = new XmlSerializer(typeof(List<Mission>));


                if (File.Exists("listmission.xml"))
                {
                    File.Delete("listmission.xml");
                }
                using (FileStream fs = new FileStream("listmission.xml", FileMode.OpenOrCreate))
                {
                    formatterlist.Serialize(fs, list);
                }
                form.Show();
                this.Hide();
            }
        }

        private void Theme6_Click(object sender, EventArgs e)
        {
            if (Theme6.Text != "---")
            {
                Theme1_Zadachi form = new Theme1_Zadachi();
                List<Mission> any = new List<Mission>();
                XmlSerializer diser = new XmlSerializer(typeof(List<Mission>));
                using (FileStream fs = new FileStream("bank.xml", FileMode.OpenOrCreate))
                {
                    any = (List<Mission>)diser.Deserialize(fs);
                }
                /*Nazvanie_Theme nazvanie = new Nazvanie_Theme();
                XmlSerializer formater = new XmlSerializer(typeof(Nazvanie_Theme));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
                }*/
                List<Mission> list = new List<Mission>();
                foreach (var item in any)
                {
                    if (item.Theme == Theme6.Text)
                    {
                        list.Add(item);
                    }
                }
                XmlSerializer formatterlist = new XmlSerializer(typeof(List<Mission>));


                if (File.Exists("listmission.xml"))
                {
                    File.Delete("listmission.xml");
                }
                using (FileStream fs = new FileStream("listmission.xml", FileMode.OpenOrCreate))
                {
                    formatterlist.Serialize(fs, list);
                }
                form.Show();
                this.Hide();
            }
        }

        private void Theme7_Click(object sender, EventArgs e)
        {
            if (Theme7.Text != "---")
            {
                Theme1_Zadachi form = new Theme1_Zadachi();
                List<Mission> any = new List<Mission>();
                XmlSerializer diser = new XmlSerializer(typeof(List<Mission>));
                using (FileStream fs = new FileStream("bank.xml", FileMode.OpenOrCreate))
                {
                    any = (List<Mission>)diser.Deserialize(fs);
                }
                /*Nazvanie_Theme nazvanie = new Nazvanie_Theme();
                XmlSerializer formater = new XmlSerializer(typeof(Nazvanie_Theme));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
                }*/
                List<Mission> list = new List<Mission>();
                foreach (var item in any)
                {
                    if (item.Theme == Theme7.Text)
                    {
                        list.Add(item);
                    }
                }
                XmlSerializer formatterlist = new XmlSerializer(typeof(List<Mission>));


                if (File.Exists("listmission.xml"))
                {
                    File.Delete("listmission.xml");
                }
                using (FileStream fs = new FileStream("listmission.xml", FileMode.OpenOrCreate))
                {
                    formatterlist.Serialize(fs, list);
                }
                form.Show();
                this.Hide();
            }
        }

        private void Theme8_Click(object sender, EventArgs e)
        {
            if (Theme8.Text != "---")
            {
                Theme1_Zadachi form = new Theme1_Zadachi();
                List<Mission> any = new List<Mission>();
                XmlSerializer diser = new XmlSerializer(typeof(List<Mission>));
                using (FileStream fs = new FileStream("bank.xml", FileMode.OpenOrCreate))
                {
                    any = (List<Mission>)diser.Deserialize(fs);
                }
                /*Nazvanie_Theme nazvanie = new Nazvanie_Theme();
                XmlSerializer formater = new XmlSerializer(typeof(Nazvanie_Theme));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
                }*/
                List<Mission> list = new List<Mission>();
                foreach (var item in any)
                {
                    if (item.Theme == Theme8.Text)
                    {
                        list.Add(item);
                    }
                }
                XmlSerializer formatterlist = new XmlSerializer(typeof(List<Mission>));


                if (File.Exists("listmission.xml"))
                {
                    File.Delete("listmission.xml");
                }
                using (FileStream fs = new FileStream("listmission.xml", FileMode.OpenOrCreate))
                {
                    formatterlist.Serialize(fs, list);
                }
                form.Show();
                this.Hide();
            }
        }

        private void Theme9_Click(object sender, EventArgs e)
        {
            if (Theme9.Text != "---")
            {
                Theme1_Zadachi form = new Theme1_Zadachi();
                List<Mission> any = new List<Mission>();
                XmlSerializer diser = new XmlSerializer(typeof(List<Mission>));
                using (FileStream fs = new FileStream("bank.xml", FileMode.OpenOrCreate))
                {
                    any = (List<Mission>)diser.Deserialize(fs);
                }
                /*Nazvanie_Theme nazvanie = new Nazvanie_Theme();
                XmlSerializer formater = new XmlSerializer(typeof(Nazvanie_Theme));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
                }*/
                List<Mission> list = new List<Mission>();
                foreach (var item in any)
                {
                    if (item.Theme == Theme9.Text)
                    {
                        list.Add(item);
                    }
                }
                XmlSerializer formatterlist = new XmlSerializer(typeof(List<Mission>));


                if (File.Exists("listmission.xml"))
                {
                    File.Delete("listmission.xml");
                }
                using (FileStream fs = new FileStream("listmission.xml", FileMode.OpenOrCreate))
                {
                    formatterlist.Serialize(fs, list);
                }
                form.Show();
                this.Hide();
            }
        }

        private void Theme10_Click(object sender, EventArgs e)
        {
            if (Theme10.Text != "---")
            {
                Theme1_Zadachi form = new Theme1_Zadachi();
                List<Mission> any = new List<Mission>();
                XmlSerializer diser = new XmlSerializer(typeof(List<Mission>));
                using (FileStream fs = new FileStream("bank.xml", FileMode.OpenOrCreate))
                {
                    any = (List<Mission>)diser.Deserialize(fs);
                }
                /*Nazvanie_Theme nazvanie = new Nazvanie_Theme();
                XmlSerializer formater = new XmlSerializer(typeof(Nazvanie_Theme));
                using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
                {
                    nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
                }*/
                List<Mission> list = new List<Mission>();
                foreach (var item in any)
                {
                    if (item.Theme == Theme10.Text)
                    {
                        list.Add(item);
                    }
                }
                XmlSerializer formatterlist = new XmlSerializer(typeof(List<Mission>));


                if (File.Exists("listmission.xml"))
                {
                    File.Delete("listmission.xml");
                }
                using (FileStream fs = new FileStream("listmission.xml", FileMode.OpenOrCreate))
                {
                    formatterlist.Serialize(fs, list);
                }
                form.Show();
                this.Hide();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
