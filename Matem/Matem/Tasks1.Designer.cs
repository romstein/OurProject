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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1272, 140);
            this.panel2.TabIndex = 0;
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 113);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(247, 27);
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
            // KolichestvoAnswer
            // 
            this.KolichestvoAnswer.Name = "KolichestvoAnswer";
            this.KolichestvoAnswer.Size = new System.Drawing.Size(209, 27);
            this.KolichestvoAnswer.Text = "Введите количество ответов";
            this.KolichestvoAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox2_KeyDown);
            this.KolichestvoAnswer.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.CreateTheme);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 743);
            this.panel1.TabIndex = 0;
            // 
            // CreateTheme
            // 
            this.CreateTheme.BackColor = System.Drawing.Color.MintCream;
            this.CreateTheme.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateTheme.Location = new System.Drawing.Point(0, 197);
            this.CreateTheme.Margin = new System.Windows.Forms.Padding(4);
            this.CreateTheme.Name = "CreateTheme";
            this.CreateTheme.Size = new System.Drawing.Size(356, 79);
            this.CreateTheme.TabIndex = 1;
            this.CreateTheme.Text = "Создать тему";
            this.CreateTheme.UseVisualStyleBackColor = false;
            this.CreateTheme.Click += new System.EventHandler(this.CreateTheme_Click);
            this.CreateTheme.MouseEnter += new System.EventHandler(this.CreateTheme_MouseEnter);
            this.CreateTheme.MouseLeave += new System.EventHandler(this.CreateTheme_MouseLeave);
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
        private System.Windows.Forms.Button CreateTheme;
    }
}