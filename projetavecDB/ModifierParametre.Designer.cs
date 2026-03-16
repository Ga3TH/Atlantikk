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
            this.components = new System.ComponentModel.Container();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.tbxCleHMAC = new System.Windows.Forms.TextBox();
            this.tbxIdentifiant = new System.Windows.Forms.TextBox();
            this.tbxRang = new System.Windows.Forms.TextBox();
            this.tbxSite = new System.Windows.Forms.TextBox();
            this.cbxProd = new System.Windows.Forms.CheckBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblSite = new System.Windows.Forms.Label();
            this.lblRang = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblHMAC = new System.Windows.Forms.Label();
            this.gbxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.lblHMAC);
            this.gbxInfo.Controls.Add(this.lblIdentifiant);
            this.gbxInfo.Controls.Add(this.lblRang);
            this.gbxInfo.Controls.Add(this.lblSite);
            this.gbxInfo.Controls.Add(this.tbxCleHMAC);
            this.gbxInfo.Controls.Add(this.tbxIdentifiant);
            this.gbxInfo.Controls.Add(this.tbxRang);
            this.gbxInfo.Controls.Add(this.tbxSite);
            this.gbxInfo.Location = new System.Drawing.Point(28, 12);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(352, 378);
            this.gbxInfo.TabIndex = 0;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "groupBox1";
            // 
            // tbxCleHMAC
            // 
            this.tbxCleHMAC.Location = new System.Drawing.Point(156, 218);
            this.tbxCleHMAC.Multiline = true;
            this.tbxCleHMAC.Name = "tbxCleHMAC";
            this.tbxCleHMAC.Size = new System.Drawing.Size(175, 154);
            this.tbxCleHMAC.TabIndex = 3;
            // 
            // tbxIdentifiant
            // 
            this.tbxIdentifiant.Location = new System.Drawing.Point(216, 157);
            this.tbxIdentifiant.Name = "tbxIdentifiant";
            this.tbxIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.tbxIdentifiant.TabIndex = 2;
            // 
            // tbxRang
            // 
            this.tbxRang.Location = new System.Drawing.Point(216, 99);
            this.tbxRang.Name = "tbxRang";
            this.tbxRang.Size = new System.Drawing.Size(100, 20);
            this.tbxRang.TabIndex = 1;
            // 
            // tbxSite
            // 
            this.tbxSite.Location = new System.Drawing.Point(216, 46);
            this.tbxSite.Name = "tbxSite";
            this.tbxSite.Size = new System.Drawing.Size(100, 20);
            this.tbxSite.TabIndex = 0;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(106, 46);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(31, 13);
            this.lblSite.TabIndex = 4;
            this.lblSite.Text = "Site :";
            // 
            // lblRang
            // 
            this.lblRang.AutoSize = true;
            this.lblRang.Location = new System.Drawing.Point(106, 99);
            this.lblRang.Name = "lblRang";
            this.lblRang.Size = new System.Drawing.Size(39, 13);
            this.lblRang.TabIndex = 5;
            this.lblRang.Text = "Rang :";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(106, 157);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(59, 13);
            this.lblIdentifiant.TabIndex = 6;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // lblHMAC
            // 
            this.lblHMAC.AutoSize = true;
            this.lblHMAC.Location = new System.Drawing.Point(106, 221);
            this.lblHMAC.Name = "lblHMAC";
            this.lblHMAC.Size = new System.Drawing.Size(44, 13);
            this.lblHMAC.TabIndex = 7;
            this.lblHMAC.Text = "HMAC :";
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
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.CheckBox cbxProd;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox tbxCleHMAC;
        private System.Windows.Forms.TextBox tbxIdentifiant;
        private System.Windows.Forms.TextBox tbxRang;
        private System.Windows.Forms.TextBox tbxSite;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblHMAC;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblRang;
    }
}