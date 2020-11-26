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
            Theme1_Zadachi form = new Theme1_Zadachi();
            List<Mission> any = new List<Mission>();
            XmlSerializer diser = new XmlSerializer(typeof(List<Mission>));
            using (FileStream fs = new FileStream("bank.xml", FileMode.OpenOrCreate))
            {
                any = (List<Mission>)diser.Deserialize(fs);
            }
            Nazvanie_Theme nazvanie = new Nazvanie_Theme();
            XmlSerializer formater = new XmlSerializer(typeof(Nazvanie_Theme));
            using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
            {
                nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
            }
            List<Mission> list = new List<Mission>();
            foreach(var item in any)
            {
                if (item.Theme == nazvanie.Name)
                {
                    list.Add(item);
                    
                }
            }
            XmlSerializer formatterlist = new XmlSerializer(typeof(List<Mission>));

            using (FileStream fs = new FileStream("listmission.xml", FileMode.OpenOrCreate))
            {
                formatterlist.Serialize(fs, list);
            }
            form.Show();
            this.Hide();
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
    }
}
