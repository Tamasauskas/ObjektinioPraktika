namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    partial class frmStudentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentas));
            this.btn_Atsijungti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Atsijungti
            // 
            this.btn_Atsijungti.Location = new System.Drawing.Point(338, 198);
            this.btn_Atsijungti.Name = "btn_Atsijungti";
            this.btn_Atsijungti.Size = new System.Drawing.Size(125, 54);
            this.btn_Atsijungti.TabIndex = 5;
            this.btn_Atsijungti.Text = "Atsijungti";
            this.btn_Atsijungti.UseVisualStyleBackColor = true;
            this.btn_Atsijungti.Click += new System.EventHandler(this.btn_Atsijungti_Click);
            // 
            // frmStudentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Atsijungti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStudentas";
            this.Text = "frmStudentas";
            this.Load += new System.EventHandler(this.frmStudentas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Atsijungti;
    }
}