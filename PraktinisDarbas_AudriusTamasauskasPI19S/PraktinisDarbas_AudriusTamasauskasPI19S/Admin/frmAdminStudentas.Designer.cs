namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    partial class frmAdminStudentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminStudentas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(346, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Studentas";
            this.groupBox1.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(346, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grupė";
            this.groupBox2.UseWaitCursor = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnLogIn.FlatAppearance.BorderSize = 2;
            this.btnLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Location = new System.Drawing.Point(12, 11);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(139, 54);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Studentas";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 72);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dėstytojas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            // 
            // frmAdminStudentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminStudentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminStudentas";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button button1;
    }
}