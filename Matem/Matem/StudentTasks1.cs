﻿using System;
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
            //здесь надо передать задачи
            form.Show();
            this.Hide();
        }
    }
}
