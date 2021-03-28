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
            this.btn_Atsijungti = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgwGrupe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrupe = new System.Windows.Forms.TextBox();
            this.btnPridetiGrupe = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGrupe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(835, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Studentas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPridetiGrupe);
            this.groupBox2.Controls.Add(this.dgwGrupe);
            this.groupBox2.Controls.Add(this.txtGrupe);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(199, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 461);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grupė";
            // 
            // btnLogIn
            // 
            this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnLogIn.FlatAppearance.BorderSize = 2;
            this.btnLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Location = new System.Drawing.Point(6, 31);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(139, 54);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Studentas";
            this.btnLogIn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(6, 89);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dėstytojas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Atsijungti
            // 
            this.btn_Atsijungti.Location = new System.Drawing.Point(983, 419);
            this.btn_Atsijungti.Name = "btn_Atsijungti";
            this.btn_Atsijungti.Size = new System.Drawing.Size(125, 54);
            this.btn_Atsijungti.TabIndex = 4;
            this.btn_Atsijungti.Text = "Atsijungti";
            this.btn_Atsijungti.UseVisualStyleBackColor = true;
            this.btn_Atsijungti.Click += new System.EventHandler(this.btn_Atsijungti_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLogIn);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 461);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Navigacija";
            // 
            // dgwGrupe
            // 
            this.dgwGrupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGrupe.Location = new System.Drawing.Point(6, 157);
            this.dgwGrupe.Name = "dgwGrupe";
            this.dgwGrupe.RowTemplate.Height = 24;
            this.dgwGrupe.Size = new System.Drawing.Size(240, 304);
            this.dgwGrupe.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Grupės pavadinimas";
            // 
            // txtGrupe
            // 
            this.txtGrupe.Location = new System.Drawing.Point(6, 51);
            this.txtGrupe.Name = "txtGrupe";
            this.txtGrupe.Size = new System.Drawing.Size(194, 22);
            this.txtGrupe.TabIndex = 7;
            // 
            // btnPridetiGrupe
            // 
            this.btnPridetiGrupe.Location = new System.Drawing.Point(6, 79);
            this.btnPridetiGrupe.Name = "btnPridetiGrupe";
            this.btnPridetiGrupe.Size = new System.Drawing.Size(125, 54);
            this.btnPridetiGrupe.TabIndex = 8;
            this.btnPridetiGrupe.Text = "Pridėti";
            this.btnPridetiGrupe.UseVisualStyleBackColor = true;
            this.btnPridetiGrupe.Click += new System.EventHandler(this.btnPridetiGrupe_Click);
            // 
            // frmAdminStudentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 485);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_Atsijungti);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminStudentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminStudentas";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGrupe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Atsijungti;
        private System.Windows.Forms.Button btnPridetiGrupe;
        private System.Windows.Forms.DataGridView dgwGrupe;
        private System.Windows.Forms.TextBox txtGrupe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}