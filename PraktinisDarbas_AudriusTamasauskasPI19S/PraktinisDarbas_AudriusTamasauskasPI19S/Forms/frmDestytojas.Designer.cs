namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    partial class FrmDestytojas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDestytojas));
            this.btn_Atsijungti = new System.Windows.Forms.Button();
            this.btn_IrasytiPazymi = new System.Windows.Forms.Button();
            this.ComboGrupe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DestytojasDataGridView = new System.Windows.Forms.DataGridView();
            this.ComboStudentas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboIvertinimas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_PakeistiPazimi = new System.Windows.Forms.Button();
            this.ComboDalykas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DestytojasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Atsijungti
            // 
            this.btn_Atsijungti.Location = new System.Drawing.Point(663, 384);
            this.btn_Atsijungti.Name = "btn_Atsijungti";
            this.btn_Atsijungti.Size = new System.Drawing.Size(125, 54);
            this.btn_Atsijungti.TabIndex = 5;
            this.btn_Atsijungti.Text = "Atsijungti";
            this.btn_Atsijungti.UseVisualStyleBackColor = true;
            this.btn_Atsijungti.Click += new System.EventHandler(this.btn_Atsijungti_Click);
            // 
            // btn_IrasytiPazymi
            // 
            this.btn_IrasytiPazymi.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btn_IrasytiPazymi.FlatAppearance.BorderSize = 2;
            this.btn_IrasytiPazymi.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_IrasytiPazymi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_IrasytiPazymi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_IrasytiPazymi.Location = new System.Drawing.Point(42, 247);
            this.btn_IrasytiPazymi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_IrasytiPazymi.Name = "btn_IrasytiPazymi";
            this.btn_IrasytiPazymi.Size = new System.Drawing.Size(139, 54);
            this.btn_IrasytiPazymi.TabIndex = 14;
            this.btn_IrasytiPazymi.Text = "Įrašyti pažymį";
            this.btn_IrasytiPazymi.UseVisualStyleBackColor = true;
            this.btn_IrasytiPazymi.Click += new System.EventHandler(this.btn_IrasytiPazymi_Click);
            // 
            // ComboGrupe
            // 
            this.ComboGrupe.FormattingEnabled = true;
            this.ComboGrupe.Location = new System.Drawing.Point(12, 42);
            this.ComboGrupe.Name = "ComboGrupe";
            this.ComboGrupe.Size = new System.Drawing.Size(194, 24);
            this.ComboGrupe.TabIndex = 18;
            this.ComboGrupe.SelectedIndexChanged += new System.EventHandler(this.ComboGrupe_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Grupe";
            // 
            // DestytojasDataGridView
            // 
            this.DestytojasDataGridView.AllowUserToAddRows = false;
            this.DestytojasDataGridView.AllowUserToDeleteRows = false;
            this.DestytojasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DestytojasDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DestytojasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DestytojasDataGridView.Location = new System.Drawing.Point(225, 4);
            this.DestytojasDataGridView.Name = "DestytojasDataGridView";
            this.DestytojasDataGridView.ReadOnly = true;
            this.DestytojasDataGridView.RowTemplate.Height = 24;
            this.DestytojasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DestytojasDataGridView.Size = new System.Drawing.Size(563, 374);
            this.DestytojasDataGridView.TabIndex = 15;
            this.DestytojasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DestytojasDataGridView_CellContentClick);
            // 
            // ComboStudentas
            // 
            this.ComboStudentas.FormattingEnabled = true;
            this.ComboStudentas.Location = new System.Drawing.Point(12, 94);
            this.ComboStudentas.Name = "ComboStudentas";
            this.ComboStudentas.Size = new System.Drawing.Size(194, 24);
            this.ComboStudentas.TabIndex = 20;
            this.ComboStudentas.SelectedIndexChanged += new System.EventHandler(this.ComboStudentas_SelectedIndexChanged);
            this.ComboStudentas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboStudentas_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Studentas";
            // 
            // ComboIvertinimas
            // 
            this.ComboIvertinimas.FormattingEnabled = true;
            this.ComboIvertinimas.Location = new System.Drawing.Point(12, 207);
            this.ComboIvertinimas.Name = "ComboIvertinimas";
            this.ComboIvertinimas.Size = new System.Drawing.Size(194, 24);
            this.ComboIvertinimas.TabIndex = 22;
            this.ComboIvertinimas.SelectedIndexChanged += new System.EventHandler(this.ComboIvertinimas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Įvertinimas";
            // 
            // btn_PakeistiPazimi
            // 
            this.btn_PakeistiPazimi.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btn_PakeistiPazimi.FlatAppearance.BorderSize = 2;
            this.btn_PakeistiPazimi.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_PakeistiPazimi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_PakeistiPazimi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PakeistiPazimi.Location = new System.Drawing.Point(42, 305);
            this.btn_PakeistiPazimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PakeistiPazimi.Name = "btn_PakeistiPazimi";
            this.btn_PakeistiPazimi.Size = new System.Drawing.Size(139, 54);
            this.btn_PakeistiPazimi.TabIndex = 23;
            this.btn_PakeistiPazimi.Text = "Pakeisti pažymį";
            this.btn_PakeistiPazimi.UseVisualStyleBackColor = true;
            this.btn_PakeistiPazimi.Click += new System.EventHandler(this.btn_PakeistiPazimi_Click);
            // 
            // ComboDalykas
            // 
            this.ComboDalykas.FormattingEnabled = true;
            this.ComboDalykas.Location = new System.Drawing.Point(12, 151);
            this.ComboDalykas.Name = "ComboDalykas";
            this.ComboDalykas.Size = new System.Drawing.Size(194, 24);
            this.ComboDalykas.TabIndex = 25;
            this.ComboDalykas.SelectedIndexChanged += new System.EventHandler(this.ComboDalykas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Dalykas";
            // 
            // FrmDestytojas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboDalykas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_PakeistiPazimi);
            this.Controls.Add(this.ComboIvertinimas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboStudentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_IrasytiPazymi);
            this.Controls.Add(this.ComboGrupe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DestytojasDataGridView);
            this.Controls.Add(this.btn_Atsijungti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDestytojas";
            this.Text = "frmDestytojas";
            ((System.ComponentModel.ISupportInitialize)(this.DestytojasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Atsijungti;
        private System.Windows.Forms.Button btn_IrasytiPazymi;
        private System.Windows.Forms.ComboBox ComboGrupe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DestytojasDataGridView;
        private System.Windows.Forms.ComboBox ComboStudentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboIvertinimas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_PakeistiPazimi;
        private System.Windows.Forms.ComboBox ComboDalykas;
        private System.Windows.Forms.Label label4;
    }
}