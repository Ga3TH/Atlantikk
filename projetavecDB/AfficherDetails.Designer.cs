namespace projetavecDB
{
    partial class AfficherDetails
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
            this.cmbNom = new System.Windows.Forms.ComboBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lvReservation = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // cmbNom
            // 
            this.cmbNom.FormattingEnabled = true;
            this.cmbNom.Location = new System.Drawing.Point(106, 38);
            this.cmbNom.Name = "cmbNom";
            this.cmbNom.Size = new System.Drawing.Size(121, 21);
            this.cmbNom.TabIndex = 0;
            this.cmbNom.SelectedIndexChanged += new System.EventHandler(this.cmbNom_SelectedIndexChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 41);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(71, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom, Prénom";
            // 
            // lvReservation
            // 
            this.lvReservation.HideSelection = false;
            this.lvReservation.Location = new System.Drawing.Point(233, 38);
            this.lvReservation.Name = "lvReservation";
            this.lvReservation.Size = new System.Drawing.Size(555, 96);
            this.lvReservation.TabIndex = 2;
            this.lvReservation.UseCompatibleStateImageBehavior = false;
            this.lvReservation.SelectedIndexChanged += new System.EventHandler(this.lvReservation_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(309, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 267);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gbxCaracteristiques";
            // 
            // AfficherDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvReservation);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.cmbNom);
            this.Name = "AfficherDetails";
            this.Text = "AfficherDetails";
            this.Load += new System.EventHandler(this.AfficherDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.ListView lvReservation;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}