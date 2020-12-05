namespace Matem
{
    partial class ChooseAction
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
            this.closeButton = new System.Windows.Forms.Label();
            this.LabelTheme = new System.Windows.Forms.Label();
            this.DeleteQuestions = new System.Windows.Forms.Button();
            this.AddQuestions = new System.Windows.Forms.Button();
            this.Nazad = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.LabelTheme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 71);
            this.panel1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(654, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // LabelTheme
            // 
            this.LabelTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTheme.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTheme.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LabelTheme.Location = new System.Drawing.Point(0, 0);
            this.LabelTheme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTheme.Name = "LabelTheme";
            this.LabelTheme.Size = new System.Drawing.Size(680, 71);
            this.LabelTheme.TabIndex = 0;
            this.LabelTheme.Text = "ThemeLabel";
            this.LabelTheme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteQuestions
            // 
            this.DeleteQuestions.BackColor = System.Drawing.Color.MintCream;
            this.DeleteQuestions.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteQuestions.Location = new System.Drawing.Point(363, 119);
            this.DeleteQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteQuestions.Name = "DeleteQuestions";
            this.DeleteQuestions.Size = new System.Drawing.Size(251, 173);
            this.DeleteQuestions.TabIndex = 1;
            this.DeleteQuestions.Text = "Удалить вопросы";
            this.DeleteQuestions.UseVisualStyleBackColor = false;
            this.DeleteQuestions.Click += new System.EventHandler(this.DeleteQuestions_Click);
            this.DeleteQuestions.MouseEnter += new System.EventHandler(this.DeleteQuestions_MouseEnter);
            this.DeleteQuestions.MouseLeave += new System.EventHandler(this.DeleteQuestions_MouseLeave);
            // 
            // AddQuestions
            // 
            this.AddQuestions.BackColor = System.Drawing.Color.MintCream;
            this.AddQuestions.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddQuestions.Location = new System.Drawing.Point(59, 119);
            this.AddQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.AddQuestions.Name = "AddQuestions";
            this.AddQuestions.Size = new System.Drawing.Size(251, 173);
            this.AddQuestions.TabIndex = 2;
            this.AddQuestions.Text = "Добавить вопросы";
            this.AddQuestions.UseVisualStyleBackColor = false;
            this.AddQuestions.Click += new System.EventHandler(this.AddQuestions_Click);
            this.AddQuestions.MouseEnter += new System.EventHandler(this.AddQuestions_MouseEnter);
            this.AddQuestions.MouseLeave += new System.EventHandler(this.AddQuestions_MouseLeave);
            // 
            // Nazad
            // 
            this.Nazad.BackColor = System.Drawing.Color.MintCream;
            this.Nazad.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazad.Location = new System.Drawing.Point(263, 344);
            this.Nazad.Margin = new System.Windows.Forms.Padding(2);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(146, 67);
            this.Nazad.TabIndex = 3;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = false;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            this.Nazad.MouseEnter += new System.EventHandler(this.Nazad_MouseEnter);
            this.Nazad.MouseLeave += new System.EventHandler(this.Nazad_MouseLeave);
            // 
            // ChooseAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(680, 439);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.AddQuestions);
            this.Controls.Add(this.DeleteQuestions);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChooseAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseAction";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label LabelTheme;
        private System.Windows.Forms.Button DeleteQuestions;
        private System.Windows.Forms.Button AddQuestions;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Label closeButton;
    }
}