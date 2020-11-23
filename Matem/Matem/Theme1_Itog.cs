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
    public partial class Theme1_Itog : Form
    {
        public Theme1_Itog()
        {
            InitializeComponent();
        }
        public XmlSerializer formater;

        private void button1_Click(object sender, EventArgs e)
        {
            StudentTasks1 form = new StudentTasks1();
            Nazvanie_Theme nazvanie;
            formater = new XmlSerializer(typeof(Nazvanie_Theme));
            using (FileStream fs = new FileStream("theme.xml", FileMode.OpenOrCreate))
            {
                nazvanie = (Nazvanie_Theme)formater.Deserialize(fs);
            }
            form.Theme1.Text = nazvanie.Name;
            form.Show();
            this.Hide();
        }
        
    }
    
}
