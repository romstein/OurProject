namespace Matem
{
    partial class AddQuestionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuestionsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nazad = new System.Windows.Forms.Button();
            this.DopolniteTheme = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddQuestion = new System.Windows.Forms.ToolStripButton();
            this.KolichestvoAnswer = new System.Windows.Forms.ToolStripTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.Nazad);
            this.panel1.Controls.Add(this.DopolniteTheme);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 604);
            this.panel1.TabIndex = 0;
            // 
            // Nazad
            // 
            this.Nazad.BackColor = System.Drawing.Color.MintCream;
            this.Nazad.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazad.Location = new System.Drawing.Point(319, 160);
            this.Nazad.Margin = new System.Windows.Forms.Padding(2);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(149, 64);
            this.Nazad.TabIndex = 2;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = false;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // DopolniteTheme
            // 
            this.DopolniteTheme.BackColor = System.Drawing.Color.MintCream;
            this.DopolniteTheme.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DopolniteTheme.Location = new System.Drawing.Point(0, 160);
            this.DopolniteTheme.Margin = new System.Windows.Forms.Padding(2);
            this.DopolniteTheme.Name = "DopolniteTheme";
            this.DopolniteTheme.Size = new System.Drawing.Size(267, 64);
            this.DopolniteTheme.TabIndex = 1;
            this.DopolniteTheme.Text = "Дополнить тему";
            this.DopolniteTheme.UseVisualStyleBackColor = false;
            this.DopolniteTheme.Click += new System.EventHandler(this.DopolniteTheme_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 114);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(930, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddQuestion,
            this.KolichestvoAnswer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 87);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(196, 27);
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
            this.AddQuestion.Text = "Довавить вопрос";
            this.AddQuestion.Click += new System.EventHandler(this.AddQuestion_Click);
            // 
            // KolichestvoAnswer
            // 
            this.KolichestvoAnswer.Name = "KolichestvoAnswer";
            this.KolichestvoAnswer.Size = new System.Drawing.Size(158, 27);
            this.KolichestvoAnswer.Text = "Введите количество ответов";
            this.KolichestvoAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KolichestvoAnswer_KeyDown);
            this.KolichestvoAnswer.Click += new System.EventHandler(this.KolichestvoAnswer_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(954, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "ThemeZagolovok";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddQuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 604);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddQuestionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuestionsForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddQuestion;
        private System.Windows.Forms.ToolStripTextBox KolichestvoAnswer;
        private System.Windows.Forms.Button DopolniteTheme;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Label closeButton;
    }
}