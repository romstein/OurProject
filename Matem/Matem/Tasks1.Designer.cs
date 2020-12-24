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
            this.KolichestvoAnswer = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateTheme1 = new Matem.RoundButton();
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1272, 140);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // ThemeZagolovok
            // 
            this.ThemeZagolovok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemeZagolovok.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ThemeZagolovok.Location = new System.Drawing.Point(44, 36);
            this.ThemeZagolovok.Margin = new System.Windows.Forms.Padding(4);
            this.ThemeZagolovok.Name = "ThemeZagolovok";
            this.ThemeZagolovok.Size = new System.Drawing.Size(1159, 53);
            this.ThemeZagolovok.TabIndex = 3;
            this.ThemeZagolovok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThemeZagolovok.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThemeZagolovok_MouseDown);
            this.ThemeZagolovok.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThemeZagolovok_MouseMove);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(1215, 0);
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
            this.KolichestvoAnswer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 111);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(286, 29);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddQuestion
            // 
            this.AddQuestion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddQuestion.Image = ((System.Drawing.Image)(resources.GetObject("AddQuestion.Image")));
            this.AddQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddQuestion.Name = "AddQuestion";
            this.AddQuestion.Size = new System.Drawing.Size(24, 26);
            this.AddQuestion.Text = "Добавить вопрос";
            this.AddQuestion.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // KolichestvoAnswer
            // 
            this.KolichestvoAnswer.Name = "KolichestvoAnswer";
            this.KolichestvoAnswer.Size = new System.Drawing.Size(209, 29);
            this.KolichestvoAnswer.Text = "Введите количество ответов";
            this.KolichestvoAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox2_KeyDown);
            this.KolichestvoAnswer.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.CreateTheme1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 743);
            this.panel1.TabIndex = 0;
            // 
            // CreateTheme1
            // 
            this.CreateTheme1.BackColor = System.Drawing.Color.MintCream;
            this.CreateTheme1.BackColor2 = System.Drawing.Color.MintCream;
            this.CreateTheme1.ButtonBorderColor = System.Drawing.Color.Black;
            this.CreateTheme1.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.CreateTheme1.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.CreateTheme1.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.CreateTheme1.ButtonPressedColor = System.Drawing.Color.Red;
            this.CreateTheme1.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.CreateTheme1.ButtonPressedForeColor = System.Drawing.Color.White;
            this.CreateTheme1.ButtonRoundRadius = 40;
            this.CreateTheme1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateTheme1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateTheme1.Location = new System.Drawing.Point(0, 197);
            this.CreateTheme1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateTheme1.Name = "CreateTheme1";
            this.CreateTheme1.Size = new System.Drawing.Size(360, 80);
            this.CreateTheme1.TabIndex = 2;
            this.CreateTheme1.Text = "Создать тему";
            this.CreateTheme1.Click += new System.EventHandler(this.CreateTheme1_Click);
            this.CreateTheme1.MouseEnter += new System.EventHandler(this.CreateTheme1_MouseEnter);
            this.CreateTheme1.MouseLeave += new System.EventHandler(this.CreateTheme1_MouseLeave);
            // 
            // Tasks1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 743);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(956, 612);
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
        private System.Windows.Forms.ToolStripTextBox KolichestvoAnswer;
        private System.Windows.Forms.Label closeButton;
        public System.Windows.Forms.TextBox ThemeZagolovok;
        private RoundButton CreateTheme1;
    }
}