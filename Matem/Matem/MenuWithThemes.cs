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

        private void AddTheme_MouseEnter(object sender, EventArgs e)
        {
            AddTheme.ForeColor = Color.White;
            AddTheme.BackColor = Color.Red;
        }

        private void AddTheme_MouseLeave(object sender, EventArgs e)
        {
            AddTheme.ForeColor = Color.Black;
            AddTheme.BackColor = Color.Lime;
        }

        private void AddTheme_Click(object sender, EventArgs e)
        {
            Tasks1 frm = new Tasks1();
            frm.Show();
            this.Hide();
        }
    }
}
