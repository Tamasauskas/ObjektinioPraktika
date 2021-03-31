namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    partial class FrmAdminDestytojas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminDestytojas));
            this.btnNaikinti = new System.Windows.Forms.Button();
            this.btnAtnaujinti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboDalykas = new System.Windows.Forms.ComboBox();
            this.txtDestytojoPavarde = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestytojoVardas = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnGrupesDalykai = new System.Windows.Forms.Button();
            this.btnStudentas = new System.Windows.Forms.Button();
            this.btnDestytojas = new System.Windows.Forms.Button();
            this.btn_Atsijungti = new System.Windows.Forms.Button();
            this.btnPridėti = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DestytojasDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboGrupe = new System.Windows.Forms.ComboBox();
            this.btnPazimiai = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DestytojasDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNaikinti
            // 
            this.btnNaikinti.Location = new System.Drawing.Point(12, 354);
            this.btnNaikinti.Name = "btnNaikinti";
            this.btnNaikinti.Size = new System.Drawing.Size(125, 54);
            this.btnNaikinti.TabIndex = 16;
            this.btnNaikinti.Text = "Naikinti";
            this.btnNaikinti.UseVisualStyleBackColor = true;
            this.btnNaikinti.Click += new System.EventHandler(this.btnNaikinti_Click);
            // 
            // btnAtnaujinti
            // 
            this.btnAtnaujinti.Location = new System.Drawing.Point(12, 294);
            this.btnAtnaujinti.Name = "btnAtnaujinti";
            this.btnAtnaujinti.Size = new System.Drawing.Size(125, 54);
            this.btnAtnaujinti.TabIndex = 15;
            this.btnAtnaujinti.Text = "Atnaujinti";
            this.btnAtnaujinti.UseVisualStyleBackColor = true;
            this.btnAtnaujinti.Click += new System.EventHandler(this.btnAtnaujinti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dalykas";
            // 
            // ComboDalykas
            // 
            this.ComboDalykas.FormattingEnabled = true;
            this.ComboDalykas.Location = new System.Drawing.Point(13, 146);
            this.ComboDalykas.Name = "ComboDalykas";
            this.ComboDalykas.Size = new System.Drawing.Size(194, 24);
            this.ComboDalykas.TabIndex = 13;
            // 
            // txtDestytojoPavarde
            // 
            this.txtDestytojoPavarde.Location = new System.Drawing.Point(13, 99);
            this.txtDestytojoPavarde.Name = "txtDestytojoPavarde";
            this.txtDestytojoPavarde.Size = new System.Drawing.Size(194, 22);
            this.txtDestytojoPavarde.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Destytojo Pavardė";
            // 
            // txtDestytojoVardas
            // 
            this.txtDestytojoVardas.Location = new System.Drawing.Point(13, 51);
            this.txtDestytojoVardas.Name = "txtDestytojoVardas";
            this.txtDestytojoVardas.Size = new System.Drawing.Size(194, 22);
            this.txtDestytojoVardas.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPazimiai);
            this.groupBox3.Controls.Add(this.BtnGrupesDalykai);
            this.groupBox3.Controls.Add(this.btnStudentas);
            this.groupBox3.Controls.Add(this.btnDestytojas);
            this.groupBox3.Location = new System.Drawing.Point(22, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 461);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Navigacija";
            // 
            // BtnGrupesDalykai
            // 
            this.BtnGrupesDalykai.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.BtnGrupesDalykai.FlatAppearance.BorderSize = 2;
            this.BtnGrupesDalykai.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnGrupesDalykai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnGrupesDalykai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGrupesDalykai.Location = new System.Drawing.Point(6, 147);
            this.BtnGrupesDalykai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGrupesDalykai.Name = "BtnGrupesDalykai";
            this.BtnGrupesDalykai.Size = new System.Drawing.Size(139, 54);
            this.BtnGrupesDalykai.TabIndex = 4;
            this.BtnGrupesDalykai.Text = "Grupes/Dalykai";
            this.BtnGrupesDalykai.UseVisualStyleBackColor = true;
            this.BtnGrupesDalykai.Click += new System.EventHandler(this.BtnGrupesDalykai_Click);
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
            // 
            // btn_Atsijungti
            // 
            this.btn_Atsijungti.Location = new System.Drawing.Point(816, 473);
            this.btn_Atsijungti.Name = "btn_Atsijungti";
            this.btn_Atsijungti.Size = new System.Drawing.Size(125, 54);
            this.btn_Atsijungti.TabIndex = 7;
            this.btn_Atsijungti.Text = "Atsijungti";
            this.btn_Atsijungti.UseVisualStyleBackColor = true;
            this.btn_Atsijungti.Click += new System.EventHandler(this.btnAtsijungti_Click);
            // 
            // btnPridėti
            // 
            this.btnPridėti.Location = new System.Drawing.Point(12, 234);
            this.btnPridėti.Name = "btnPridėti";
            this.btnPridėti.Size = new System.Drawing.Size(125, 54);
            this.btnPridėti.TabIndex = 9;
            this.btnPridėti.Text = "Pridėti";
            this.btnPridėti.UseVisualStyleBackColor = true;
            this.btnPridėti.Click += new System.EventHandler(this.btnPridėti_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Destytojo vardas";
            // 
            // DestytojasDataGridView
            // 
            this.DestytojasDataGridView.AllowUserToAddRows = false;
            this.DestytojasDataGridView.AllowUserToDeleteRows = false;
            this.DestytojasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DestytojasDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DestytojasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DestytojasDataGridView.Location = new System.Drawing.Point(231, 21);
            this.DestytojasDataGridView.Name = "DestytojasDataGridView";
            this.DestytojasDataGridView.ReadOnly = true;
            this.DestytojasDataGridView.RowTemplate.Height = 24;
            this.DestytojasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DestytojasDataGridView.Size = new System.Drawing.Size(648, 434);
            this.DestytojasDataGridView.TabIndex = 9;
            this.DestytojasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DestytojasDataGridView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ComboGrupe);
            this.groupBox1.Controls.Add(this.btnNaikinti);
            this.groupBox1.Controls.Add(this.btnAtnaujinti);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ComboDalykas);
            this.groupBox1.Controls.Add(this.txtDestytojoPavarde);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDestytojoVardas);
            this.groupBox1.Controls.Add(this.btnPridėti);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DestytojasDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(211, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 461);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Studentas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Grupe";
            // 
            // ComboGrupe
            // 
            this.ComboGrupe.FormattingEnabled = true;
            this.ComboGrupe.Location = new System.Drawing.Point(13, 204);
            this.ComboGrupe.Name = "ComboGrupe";
            this.ComboGrupe.Size = new System.Drawing.Size(194, 24);
            this.ComboGrupe.TabIndex = 17;
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
            this.btnPazimiai.TabIndex = 6;
            this.btnPazimiai.Text = "Pažymiai";
            this.btnPazimiai.UseVisualStyleBackColor = true;
            this.btnPazimiai.Click += new System.EventHandler(this.btnPazimiai_Click);
            // 
            // frmAdminDestytojas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 532);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_Atsijungti);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminDestytojas";
            this.Text = "AdminDestytojas";
            this.Load += new System.EventHandler(this.frmAdminDestytojas_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DestytojasDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNaikinti;
        private System.Windows.Forms.Button btnAtnaujinti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboDalykas;
        private System.Windows.Forms.TextBox txtDestytojoPavarde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestytojoVardas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnGrupesDalykai;
        private System.Windows.Forms.Button btnStudentas;
        private System.Windows.Forms.Button btnDestytojas;
        private System.Windows.Forms.Button btn_Atsijungti;
        private System.Windows.Forms.Button btnPridėti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DestytojasDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboGrupe;
        private System.Windows.Forms.Button btnPazimiai;
    }
}