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
            this.panel1.Controls.Add(this.LabelTheme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 87);
            this.panel1.TabIndex = 0;
            // 
            // LabelTheme
            // 
            this.LabelTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTheme.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTheme.ForeColor = System.Drawing.Color.Green;
            this.LabelTheme.Location = new System.Drawing.Point(0, 0);
            this.LabelTheme.Name = "LabelTheme";
            this.LabelTheme.Size = new System.Drawing.Size(907, 87);
            this.LabelTheme.TabIndex = 0;
            this.LabelTheme.Text = "ThemeLabel";
            this.LabelTheme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteQuestions
            // 
            this.DeleteQuestions.BackColor = System.Drawing.Color.Lime;
            this.DeleteQuestions.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteQuestions.Location = new System.Drawing.Point(484, 147);
            this.DeleteQuestions.Name = "DeleteQuestions";
            this.DeleteQuestions.Size = new System.Drawing.Size(335, 213);
            this.DeleteQuestions.TabIndex = 1;
            this.DeleteQuestions.Text = "Удалить вопросы";
            this.DeleteQuestions.UseVisualStyleBackColor = false;
            this.DeleteQuestions.Click += new System.EventHandler(this.DeleteQuestions_Click);
            // 
            // AddQuestions
            // 
            this.AddQuestions.BackColor = System.Drawing.Color.Lime;
            this.AddQuestions.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddQuestions.Location = new System.Drawing.Point(79, 147);
            this.AddQuestions.Name = "AddQuestions";
            this.AddQuestions.Size = new System.Drawing.Size(335, 213);
            this.AddQuestions.TabIndex = 2;
            this.AddQuestions.Text = "Добавить вопросы";
            this.AddQuestions.UseVisualStyleBackColor = false;
            this.AddQuestions.Click += new System.EventHandler(this.AddQuestions_Click);
            // 
            // Nazad
            // 
            this.Nazad.BackColor = System.Drawing.Color.Lime;
            this.Nazad.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazad.Location = new System.Drawing.Point(351, 424);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(194, 83);
            this.Nazad.TabIndex = 3;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = false;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // ChooseAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(907, 540);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.AddQuestions);
            this.Controls.Add(this.DeleteQuestions);
            this.Controls.Add(this.panel1);
            this.Name = "ChooseAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseAction";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label LabelTheme;
        private System.Windows.Forms.Button DeleteQuestions;
        private System.Windows.Forms.Button AddQuestions;
        private System.Windows.Forms.Button Nazad;
    }
}