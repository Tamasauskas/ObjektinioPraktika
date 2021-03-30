namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    partial class frmPazimiai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPazimiai));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPazimiai = new System.Windows.Forms.Button();
            this.BtnGrupsDalykai = new System.Windows.Forms.Button();
            this.btnStudentas = new System.Windows.Forms.Button();
            this.btnDestytojas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPazymysNaikinti = new System.Windows.Forms.Button();
            this.txtPazymys = new System.Windows.Forms.TextBox();
            this.PazymiaiDataGridView = new System.Windows.Forms.DataGridView();
            this.btnPazymysAtnaujinti = new System.Windows.Forms.Button();
            this.btnPazymysPridėti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PazymiaiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPazimiai);
            this.groupBox3.Controls.Add(this.BtnGrupsDalykai);
            this.groupBox3.Controls.Add(this.btnStudentas);
            this.groupBox3.Controls.Add(this.btnDestytojas);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 461);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Navigacija";
            // 
            // btnPazimiai
            // 
            this.btnPazimiai.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnPazimiai.FlatAppearance.BorderSize = 2;
            this.btnPazimiai.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPazimiai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPazimiai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPazimiai.Location = new System.Drawing.Point(6, 205);
            this.btnPazimiai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPazimiai.Name = "btnPazimiai";
            this.btnPazimiai.Size = new System.Drawing.Size(139, 54);
            this.btnPazimiai.TabIndex = 11;
            this.btnPazimiai.Text = "Pažymiai";
            this.btnPazimiai.UseVisualStyleBackColor = true;
            // 
            // BtnGrupsDalykai
            // 
            this.BtnGrupsDalykai.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.BtnGrupsDalykai.FlatAppearance.BorderSize = 2;
            this.BtnGrupsDalykai.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnGrupsDalykai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnGrupsDalykai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGrupsDalykai.Location = new System.Drawing.Point(6, 147);
            this.BtnGrupsDalykai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGrupsDalykai.Name = "BtnGrupsDalykai";
            this.BtnGrupsDalykai.Size = new System.Drawing.Size(139, 54);
            this.BtnGrupsDalykai.TabIndex = 4;
            this.BtnGrupsDalykai.Text = "Grupes/Dalykai";
            this.BtnGrupsDalykai.UseVisualStyleBackColor = true;
            this.BtnGrupsDalykai.Click += new System.EventHandler(this.BtnGrupsDalykai_Click);
            // 
            // btnStudentas
            // 
            this.btnStudentas.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnStudentas.FlatAppearance.BorderSize = 2;
            this.btnStudentas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnStudentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStudentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStudentas.Location = new System.Drawing.Point(6, 31);
            this.btnStudentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudentas.Name = "btnStudentas";
            this.btnStudentas.Size = new System.Drawing.Size(139, 54);
            this.btnStudentas.TabIndex = 2;
            this.btnStudentas.Text = "Studentas";
            this.btnStudentas.UseVisualStyleBackColor = true;
            this.btnStudentas.Click += new System.EventHandler(this.btnStudentas_Click);
            // 
            // btnDestytojas
            // 
            this.btnDestytojas.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnDestytojas.FlatAppearance.BorderSize = 2;
            this.btnDestytojas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDestytojas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDestytojas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDestytojas.Location = new System.Drawing.Point(6, 89);
            this.btnDestytojas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDestytojas.Name = "btnDestytojas";
            this.btnDestytojas.Size = new System.Drawing.Size(139, 54);
            this.btnDestytojas.TabIndex = 3;
            this.btnDestytojas.Text = "Dėstytojas";
            this.btnDestytojas.UseVisualStyleBackColor = true;
            this.btnDestytojas.Click += new System.EventHandler(this.btnDestytojas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPazymysNaikinti);
            this.groupBox1.Controls.Add(this.txtPazymys);
            this.groupBox1.Controls.Add(this.PazymiaiDataGridView);
            this.groupBox1.Controls.Add(this.btnPazymysAtnaujinti);
            this.groupBox1.Controls.Add(this.btnPazymysPridėti);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(190, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 461);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pazymiai";
            // 
            // btnPazymysNaikinti
            // 
            this.btnPazymysNaikinti.Location = new System.Drawing.Point(6, 206);
            this.btnPazymysNaikinti.Name = "btnPazymysNaikinti";
            this.btnPazymysNaikinti.Size = new System.Drawing.Size(125, 54);
            this.btnPazymysNaikinti.TabIndex = 15;
            this.btnPazymysNaikinti.Text = "Naikinti";
            this.btnPazymysNaikinti.UseVisualStyleBackColor = true;
            this.btnPazymysNaikinti.Click += new System.EventHandler(this.btnPazymysNaikinti_Click);
            // 
            // txtPazymys
            // 
            this.txtPazymys.Location = new System.Drawing.Point(6, 51);
            this.txtPazymys.Name = "txtPazymys";
            this.txtPazymys.Size = new System.Drawing.Size(125, 22);
            this.txtPazymys.TabIndex = 14;
            // 
            // PazymiaiDataGridView
            // 
            this.PazymiaiDataGridView.AllowUserToAddRows = false;
            this.PazymiaiDataGridView.AllowUserToDeleteRows = false;
            this.PazymiaiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PazymiaiDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PazymiaiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PazymiaiDataGridView.Location = new System.Drawing.Point(137, 12);
            this.PazymiaiDataGridView.Name = "PazymiaiDataGridView";
            this.PazymiaiDataGridView.ReadOnly = true;
            this.PazymiaiDataGridView.RowTemplate.Height = 24;
            this.PazymiaiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PazymiaiDataGridView.Size = new System.Drawing.Size(206, 443);
            this.PazymiaiDataGridView.TabIndex = 13;
            this.PazymiaiDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PazymiaiDataGridView_CellContentClick);
            // 
            // btnPazymysAtnaujinti
            // 
            this.btnPazymysAtnaujinti.Location = new System.Drawing.Point(6, 146);
            this.btnPazymysAtnaujinti.Name = "btnPazymysAtnaujinti";
            this.btnPazymysAtnaujinti.Size = new System.Drawing.Size(125, 54);
            this.btnPazymysAtnaujinti.TabIndex = 11;
            this.btnPazymysAtnaujinti.Text = "Atnaujinti";
            this.btnPazymysAtnaujinti.UseVisualStyleBackColor = true;
            // 
            // btnPazymysPridėti
            // 
            this.btnPazymysPridėti.Location = new System.Drawing.Point(6, 86);
            this.btnPazymysPridėti.Name = "btnPazymysPridėti";
            this.btnPazymysPridėti.Size = new System.Drawing.Size(125, 54);
            this.btnPazymysPridėti.TabIndex = 10;
            this.btnPazymysPridėti.Text = "Pridėti";
            this.btnPazymysPridėti.UseVisualStyleBackColor = true;
            this.btnPazymysPridėti.Click += new System.EventHandler(this.btnPazimysPridėti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pazymys";
            // 
            // frmPazimiai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 481);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPazimiai";
            this.Text = "frmPazimiai";
            this.Load += new System.EventHandler(this.frmPazimiai_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PazymiaiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPazimiai;
        private System.Windows.Forms.Button BtnGrupsDalykai;
        private System.Windows.Forms.Button btnStudentas;
        private System.Windows.Forms.Button btnDestytojas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView PazymiaiDataGridView;
        private System.Windows.Forms.Button btnPazymysAtnaujinti;
        private System.Windows.Forms.Button btnPazymysPridėti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPazymys;
        private System.Windows.Forms.Button btnPazymysNaikinti;
    }
}