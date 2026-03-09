namespace projetavecDB
{
    partial class ModifierBateau
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
            this.gbxCapacite = new System.Windows.Forms.GroupBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBateau = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // gbxCapacite
            // 
            this.gbxCapacite.Location = new System.Drawing.Point(409, 63);
            this.gbxCapacite.Name = "gbxCapacite";
            this.gbxCapacite.Size = new System.Drawing.Size(365, 349);
            this.gbxCapacite.TabIndex = 7;
            this.gbxCapacite.TabStop = false;
            this.gbxCapacite.Text = "Capacité maximal";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(167, 302);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(158, 49);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom Bateau";
            // 
            // cmbBateau
            // 
            this.cmbBateau.FormattingEnabled = true;
            this.cmbBateau.Location = new System.Drawing.Point(152, 36);
            this.cmbBateau.Name = "cmbBateau";
            this.cmbBateau.Size = new System.Drawing.Size(121, 21);
            this.cmbBateau.TabIndex = 8;
            this.cmbBateau.SelectedIndexChanged += new System.EventHandler(this.cmbBateau_SelectedIndexChanged);
            // 
            // ModifierBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbBateau);
            this.Controls.Add(this.gbxCapacite);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label1);
            this.Name = "ModifierBateau";
            this.Text = "ModifierBateau";
            this.Load += new System.EventHandler(this.ModifierBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCapacite;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBateau;
    }
}