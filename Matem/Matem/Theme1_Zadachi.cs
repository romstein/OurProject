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
    public partial class Theme1_Zadachi : Form
    {
        public Theme1_Zadachi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Theme1_Itog itog = new Theme1_Itog();
            itog.Show();
            this.Hide();
        }
    }
}
