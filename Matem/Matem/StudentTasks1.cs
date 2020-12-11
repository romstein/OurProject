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
            this.Close();
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
                this.Close();
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
                this.Close();
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
                this.Close();
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
                this.Close();
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
                this.Close();
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
                this.Close();
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
                this.Close();
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
                this.Close();
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
                this.Close();
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
                this.Close();
            }
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

        private void Theme1_MouseEnter(object sender, EventArgs e)
        {
            Theme1.ForeColor = Color.Red;

        }

        private void Theme1_MouseLeave(object sender, EventArgs e)
        {
            Theme1.ForeColor = Color.Black;

        }

        private void Theme2_MouseEnter(object sender, EventArgs e)
        {
            Theme2.ForeColor = Color.Red;

        }

        private void Theme2_MouseLeave(object sender, EventArgs e)
        {
            Theme2.ForeColor = Color.Black;

        }

        private void Theme3_MouseEnter(object sender, EventArgs e)
        {
            Theme3.ForeColor = Color.Red;

        }

        private void Theme3_MouseLeave(object sender, EventArgs e)
        {
            Theme3.ForeColor = Color.Black;

        }

        private void Theme4_MouseEnter(object sender, EventArgs e)
        {
            Theme4.ForeColor = Color.Red;

        }

        private void Theme4_MouseLeave(object sender, EventArgs e)
        {
            Theme4.ForeColor = Color.Black;

        }

        private void Theme5_MouseEnter(object sender, EventArgs e)
        {
            Theme5.ForeColor = Color.Red;

        }

        private void Theme5_MouseLeave(object sender, EventArgs e)
        {
            Theme5.ForeColor = Color.Black;

        }

        private void Theme6_MouseEnter(object sender, EventArgs e)
        {
            Theme6.ForeColor = Color.Red;

        }

        private void Theme6_MouseLeave(object sender, EventArgs e)
        {
            Theme6.ForeColor = Color.Black;


        }

        private void Theme7_MouseEnter(object sender, EventArgs e)
        {
            Theme7.ForeColor = Color.Red;

        }

        private void Theme7_MouseLeave(object sender, EventArgs e)
        {
            Theme7.ForeColor = Color.Black;

        }

        private void Theme8_MouseEnter(object sender, EventArgs e)
        {
            Theme8.ForeColor = Color.Red;

        }

        private void Theme8_MouseLeave(object sender, EventArgs e)
        {
            Theme8.ForeColor = Color.Black;

        }

        private void Theme9_MouseEnter(object sender, EventArgs e)
        {
            Theme9.ForeColor = Color.Red;

        }

        private void Theme9_MouseLeave(object sender, EventArgs e)
        {
            Theme9.ForeColor = Color.Black;

        }

        private void Theme10_MouseEnter(object sender, EventArgs e)
        {
            Theme10.ForeColor = Color.Red;

        }

        private void Theme10_MouseLeave(object sender, EventArgs e)
        {
            Theme10.ForeColor = Color.Black;

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            button1.BackColor = Color.MintCream;
        }
    }
}
