using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matem
{
    public partial class Theme1_Itog : Form
    {
        public Theme1_Itog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentTasks1 form = new StudentTasks1();
            form.Show();
            this.Hide();
        }
        
    }
    
}
