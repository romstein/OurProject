namespace Matem
{
    partial class MainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TeacherButton1 = new Matem.RoundButton();
            this.StudentButton1 = new Matem.RoundButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.TeacherButton1);
            this.panel1.Controls.Add(this.StudentButton1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 544);
            this.panel1.TabIndex = 0;
            // 
            // TeacherButton1
            // 
            this.TeacherButton1.BackColor = System.Drawing.Color.MintCream;
            this.TeacherButton1.BackColor2 = System.Drawing.Color.MintCream;
            this.TeacherButton1.ButtonBorderColor = System.Drawing.Color.Black;
            this.TeacherButton1.ButtonHighlightColor = System.Drawing.Color.DarkSlateGray;
            this.TeacherButton1.ButtonHighlightColor2 = System.Drawing.Color.DarkSlateGray;
            this.TeacherButton1.ButtonHighlightForeColor = System.Drawing.Color.White;
            this.TeacherButton1.ButtonPressedColor = System.Drawing.Color.DarkSlateGray;
            this.TeacherButton1.ButtonPressedColor2 = System.Drawing.Color.DarkSlateGray;
            this.TeacherButton1.ButtonPressedForeColor = System.Drawing.Color.White;
            this.TeacherButton1.ButtonRoundRadius = 40;
            this.TeacherButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeacherButton1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeacherButton1.Location = new System.Drawing.Point(581, 210);
            this.TeacherButton1.Name = "TeacherButton1";
            this.TeacherButton1.Size = new System.Drawing.Size(360, 180);
            this.TeacherButton1.TabIndex = 4;
            this.TeacherButton1.Text = "Учитель";
            this.TeacherButton1.Click += new System.EventHandler(this.TeacherButton1_Click);
            this.TeacherButton1.MouseEnter += new System.EventHandler(this.TeacherButton1_MouseEnter);
            this.TeacherButton1.MouseLeave += new System.EventHandler(this.TeacherButton1_MouseLeave);
            // 
            // StudentButton1
            // 
            this.StudentButton1.BackColor = System.Drawing.Color.MintCream;
            this.StudentButton1.BackColor2 = System.Drawing.Color.MintCream;
            this.StudentButton1.ButtonBorderColor = System.Drawing.Color.Black;
            this.StudentButton1.ButtonHighlightColor = System.Drawing.Color.DarkSlateGray;
            this.StudentButton1.ButtonHighlightColor2 = System.Drawing.Color.DarkSlateGray;
            this.StudentButton1.ButtonHighlightForeColor = System.Drawing.Color.White;
            this.StudentButton1.ButtonPressedColor = System.Drawing.Color.DarkSlateGray;
            this.StudentButton1.ButtonPressedColor2 = System.Drawing.Color.DarkSlateGray;
            this.StudentButton1.ButtonPressedForeColor = System.Drawing.Color.White;
            this.StudentButton1.ButtonRoundRadius = 40;
            this.StudentButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentButton1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentButton1.Location = new System.Drawing.Point(163, 210);
            this.StudentButton1.Name = "StudentButton1";
            this.StudentButton1.Size = new System.Drawing.Size(360, 180);
            this.StudentButton1.TabIndex = 3;
            this.StudentButton1.Text = "Ученик";
            this.StudentButton1.Click += new System.EventHandler(this.StudentButton1_Click);
            this.StudentButton1.MouseEnter += new System.EventHandler(this.StudentButton1_MouseEnter);
            this.StudentButton1.MouseLeave += new System.EventHandler(this.StudentButton1_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1117, 81);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(1087, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 29);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1117, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тренажер по математике";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 544);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(825, 340);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label closeButton;
        private RoundButton StudentButton1;
        private RoundButton TeacherButton1;
    }
}