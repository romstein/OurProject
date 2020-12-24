namespace Matem
{
    partial class Theme1_Itog
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
            this.label1 = new System.Windows.Forms.Label();
            this.NazadVMenu = new Matem.RoundButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 121);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(864, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 29);
            this.closeButton.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(923, 121);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // NazadVMenu
            // 
            this.NazadVMenu.BackColor = System.Drawing.Color.MintCream;
            this.NazadVMenu.BackColor2 = System.Drawing.Color.MintCream;
            this.NazadVMenu.ButtonBorderColor = System.Drawing.Color.Black;
            this.NazadVMenu.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.NazadVMenu.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.NazadVMenu.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.NazadVMenu.ButtonPressedColor = System.Drawing.Color.Red;
            this.NazadVMenu.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.NazadVMenu.ButtonPressedForeColor = System.Drawing.Color.White;
            this.NazadVMenu.ButtonRoundRadius = 40;
            this.NazadVMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NazadVMenu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NazadVMenu.Location = new System.Drawing.Point(333, 491);
            this.NazadVMenu.Name = "NazadVMenu";
            this.NazadVMenu.Size = new System.Drawing.Size(225, 60);
            this.NazadVMenu.TabIndex = 2;
            this.NazadVMenu.Text = "Вернуться в меню";
            this.NazadVMenu.Click += new System.EventHandler(this.NazadVMenu_Click);
            this.NazadVMenu.MouseEnter += new System.EventHandler(this.NazadVMenu_MouseEnter);
            this.NazadVMenu.MouseLeave += new System.EventHandler(this.NazadVMenu_MouseLeave);
            // 
            // Theme1_Itog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(923, 553);
            this.Controls.Add(this.NazadVMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Theme1_Itog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theme1_Itog";
            this.Load += new System.EventHandler(this.Theme1_Itog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label closeButton;
        private RoundButton NazadVMenu;
    }
}