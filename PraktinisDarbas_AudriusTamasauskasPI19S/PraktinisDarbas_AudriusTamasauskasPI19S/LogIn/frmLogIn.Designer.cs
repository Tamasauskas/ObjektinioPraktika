namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.txtLonInName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnLogIn.FlatAppearance.BorderSize = 2;
            this.btnLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Location = new System.Drawing.Point(113, 142);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(139, 54);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "Prisijungti";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(113, 224);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogOut.Size = new System.Drawing.Size(139, 54);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Atsijungti";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // txtLonInName
            // 
            this.txtLonInName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLonInName.ForeColor = System.Drawing.Color.LightGray;
            this.txtLonInName.Location = new System.Drawing.Point(46, 28);
            this.txtLonInName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLonInName.Multiline = true;
            this.txtLonInName.Name = "txtLonInName";
            this.txtLonInName.Size = new System.Drawing.Size(279, 36);
            this.txtLonInName.TabIndex = 2;
            this.txtLonInName.Text = "Prisijungimo vardas";
            this.txtLonInName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLonInName.Enter += new System.EventHandler(this.txtUserEnter);
            this.txtLonInName.Leave += new System.EventHandler(this.txtUserLeave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.LightGray;
            this.txtPassword.Location = new System.Drawing.Point(46, 85);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassword.Size = new System.Drawing.Size(279, 36);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Slaptažodis";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassEnter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PraktinisDarbas_AudriusTamasauskasPI19S.Properties.Resources.explosion_pink_blue_powder_freeze_260nw_1077184466;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 320);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLonInName);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLogIn";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prisijungimas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TextBox txtLonInName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

