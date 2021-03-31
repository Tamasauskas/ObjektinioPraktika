namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    partial class FrmStudentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentas));
            this.btn_Atsijungti = new System.Windows.Forms.Button();
            this.StudentoIvertinimaiDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentoIvertinimaiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Atsijungti
            // 
            this.btn_Atsijungti.Location = new System.Drawing.Point(826, 373);
            this.btn_Atsijungti.Name = "btn_Atsijungti";
            this.btn_Atsijungti.Size = new System.Drawing.Size(125, 54);
            this.btn_Atsijungti.TabIndex = 5;
            this.btn_Atsijungti.Text = "Atsijungti";
            this.btn_Atsijungti.UseVisualStyleBackColor = true;
            this.btn_Atsijungti.Click += new System.EventHandler(this.btn_Atsijungti_Click);
            // 
            // StudentoIvertinimaiDataGridView
            // 
            this.StudentoIvertinimaiDataGridView.AllowUserToAddRows = false;
            this.StudentoIvertinimaiDataGridView.AllowUserToDeleteRows = false;
            this.StudentoIvertinimaiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentoIvertinimaiDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StudentoIvertinimaiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentoIvertinimaiDataGridView.Location = new System.Drawing.Point(12, 8);
            this.StudentoIvertinimaiDataGridView.Name = "StudentoIvertinimaiDataGridView";
            this.StudentoIvertinimaiDataGridView.ReadOnly = true;
            this.StudentoIvertinimaiDataGridView.RowTemplate.Height = 24;
            this.StudentoIvertinimaiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentoIvertinimaiDataGridView.Size = new System.Drawing.Size(939, 359);
            this.StudentoIvertinimaiDataGridView.TabIndex = 10;
            // 
            // frmStudentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 435);
            this.Controls.Add(this.StudentoIvertinimaiDataGridView);
            this.Controls.Add(this.btn_Atsijungti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStudentas";
            this.Text = "frmStudentas";
            ((System.ComponentModel.ISupportInitialize)(this.StudentoIvertinimaiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Atsijungti;
        private System.Windows.Forms.DataGridView StudentoIvertinimaiDataGridView;
    }
}