namespace projetavecDB
{
    partial class ModifierParametre
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
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.cbxProd = new System.Windows.Forms.CheckBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gbxInfo
            // 
            this.gbxInfo.Location = new System.Drawing.Point(28, 12);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(352, 378);
            this.gbxInfo.TabIndex = 0;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "groupBox1";
            // 
            // cbxProd
            // 
            this.cbxProd.AutoSize = true;
            this.cbxProd.Location = new System.Drawing.Point(612, 42);
            this.cbxProd.Name = "cbxProd";
            this.cbxProd.Size = new System.Drawing.Size(116, 17);
            this.cbxProd.TabIndex = 1;
            this.cbxProd.Text = "EN PRODUCTION";
            this.cbxProd.UseVisualStyleBackColor = true;
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(495, 92);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(31, 13);
            this.lblmail.TabIndex = 2;
            this.lblmail.Text = "mail :";
            // 
            // tbxMail
            // 
            this.tbxMail.Location = new System.Drawing.Point(549, 89);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(162, 20);
            this.tbxMail.TabIndex = 3;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(503, 282);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(208, 108);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // ModifierParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.tbxMail);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.cbxProd);
            this.Controls.Add(this.gbxInfo);
            this.Name = "ModifierParametre";
            this.Text = "ModifierParametre";
            this.Load += new System.EventHandler(this.ModifierParametre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.CheckBox cbxProd;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.Button btnModifier;
    }
}