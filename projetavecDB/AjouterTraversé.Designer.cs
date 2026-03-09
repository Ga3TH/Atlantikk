namespace projetavecDB
{
    partial class AjouterTraversé
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
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lblBateau = new System.Windows.Forms.Label();
            this.lblDateArrivee = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cmbBateau = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(76, 325);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaison.TabIndex = 0;
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(24, 325);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(46, 13);
            this.lblLiaison.TabIndex = 1;
            this.lblLiaison.Text = "Liaison :";
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.Location = new System.Drawing.Point(86, 13);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(128, 251);
            this.lbxSecteur.TabIndex = 2;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(15, 13);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(55, 13);
            this.lblSecteur.TabIndex = 3;
            this.lblSecteur.Text = "Secteurs :";
            // 
            // lblBateau
            // 
            this.lblBateau.AutoSize = true;
            this.lblBateau.Location = new System.Drawing.Point(392, 38);
            this.lblBateau.Name = "lblBateau";
            this.lblBateau.Size = new System.Drawing.Size(72, 13);
            this.lblBateau.TabIndex = 4;
            this.lblBateau.Text = "Nom Bateau :";
            // 
            // lblDateArrivee
            // 
            this.lblDateArrivee.AutoSize = true;
            this.lblDateArrivee.Location = new System.Drawing.Point(351, 227);
            this.lblDateArrivee.Name = "lblDateArrivee";
            this.lblDateArrivee.Size = new System.Drawing.Size(113, 13);
            this.lblDateArrivee.TabIndex = 5;
            this.lblDateArrivee.Text = "Date et heure Départ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date et heure arrivée  :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(493, 227);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(493, 296);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // cmbBateau
            // 
            this.cmbBateau.FormattingEnabled = true;
            this.cmbBateau.Location = new System.Drawing.Point(493, 35);
            this.cmbBateau.Name = "cmbBateau";
            this.cmbBateau.Size = new System.Drawing.Size(121, 21);
            this.cmbBateau.TabIndex = 9;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(459, 352);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(221, 61);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // AjouterTraversé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.cmbBateau);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDateArrivee);
            this.Controls.Add(this.lblBateau);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lbxSecteur);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.cmbLiaison);
            this.Name = "AjouterTraversé";
            this.Text = "AjouterTraversé";
            this.Load += new System.EventHandler(this.AjouterTraversé_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.Label lblBateau;
        private System.Windows.Forms.Label lblDateArrivee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cmbBateau;
        private System.Windows.Forms.Button btnValider;
    }
}