namespace Matem
{
    partial class Tasks1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ThemeZagolovok = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddQuestion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.сОднимВариантомОтветаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KolichestvoAnswer = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateTheme = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ThemeZagolovok);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 140);
            this.panel2.TabIndex = 0;
            // 
            // ThemeZagolovok
            // 
            this.ThemeZagolovok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemeZagolovok.ForeColor = System.Drawing.Color.Green;
            this.ThemeZagolovok.Location = new System.Drawing.Point(75, 29);
            this.ThemeZagolovok.Name = "ThemeZagolovok";
            this.ThemeZagolovok.Size = new System.Drawing.Size(911, 53);
            this.ThemeZagolovok.TabIndex = 3;
            this.ThemeZagolovok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThemeZagolovok.Click += new System.EventHandler(this.ThemeZagolovok_Click);
            this.ThemeZagolovok.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ThemeZagolovok_KeyDown);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(992, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 29);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddQuestion,
            this.toolStripSplitButton1,
            this.KolichestvoAnswer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 111);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(287, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddQuestion
            // 
            this.AddQuestion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddQuestion.Image = ((System.Drawing.Image)(resources.GetObject("AddQuestion.Image")));
            this.AddQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddQuestion.Name = "AddQuestion";
            this.AddQuestion.Size = new System.Drawing.Size(24, 24);
            this.AddQuestion.Text = "Добавить вопрос";
            this.AddQuestion.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.BackColor = System.Drawing.Color.Yellow;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сОднимВариантомОтветаToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(39, 24);
            this.toolStripSplitButton1.Text = "Выберите тип вопроса";
            // 
            // сОднимВариантомОтветаToolStripMenuItem
            // 
            this.сОднимВариантомОтветаToolStripMenuItem.Name = "сОднимВариантомОтветаToolStripMenuItem";
            this.сОднимВариантомОтветаToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.сОднимВариантомОтветаToolStripMenuItem.Text = "С одним вариантом ответа";
            this.сОднимВариантомОтветаToolStripMenuItem.Click += new System.EventHandler(this.сОднимВариантомОтветаToolStripMenuItem_Click);
            // 
            // KolichestvoAnswer
            // 
            this.KolichestvoAnswer.Name = "KolichestvoAnswer";
            this.KolichestvoAnswer.Size = new System.Drawing.Size(210, 27);
            this.KolichestvoAnswer.Text = "Введите количество ответов";
            this.KolichestvoAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox2_KeyDown);
            this.KolichestvoAnswer.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.CreateTheme);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 580);
            this.panel1.TabIndex = 0;
            // 
            // CreateTheme
            // 
            this.CreateTheme.BackColor = System.Drawing.Color.Lime;
            this.CreateTheme.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateTheme.Location = new System.Drawing.Point(0, 160);
            this.CreateTheme.Name = "CreateTheme";
            this.CreateTheme.Size = new System.Drawing.Size(267, 64);
            this.CreateTheme.TabIndex = 1;
            this.CreateTheme.Text = "Создать тему";
            this.CreateTheme.UseVisualStyleBackColor = false;
            this.CreateTheme.Click += new System.EventHandler(this.CreateTheme_Click);
            // 
            // Tasks1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 580);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(951, 603);
            this.Name = "Tasks1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шаблон для редактиования";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddQuestion;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem сОднимВариантомОтветаToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox KolichestvoAnswer;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.TextBox ThemeZagolovok;
        private System.Windows.Forms.Button CreateTheme;
    }
}