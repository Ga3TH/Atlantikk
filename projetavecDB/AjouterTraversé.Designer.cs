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
            this.lblDateDepart = new System.Windows.Forms.Label();
            this.lblDateArrivee = new System.Windows.Forms.Label();
            this.dtpDepartHeure = new System.Windows.Forms.DateTimePicker();
            this.cmbBateau = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.dtpDepartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpArriveeDate = new System.Windows.Forms.DateTimePicker();
            this.dtpArriveeHeure = new System.Windows.Forms.DateTimePicker();
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
            // lblDateDepart
            // 
            this.lblDateDepart.AutoSize = true;
            this.lblDateDepart.Location = new System.Drawing.Point(351, 227);
            this.lblDateDepart.Name = "lblDateDepart";
            this.lblDateDepart.Size = new System.Drawing.Size(113, 13);
            this.lblDateDepart.TabIndex = 5;
            this.lblDateDepart.Text = "Date et heure Départ :";
            // 
            // lblDateArrivee
            // 
            this.lblDateArrivee.AutoSize = true;
            this.lblDateArrivee.Location = new System.Drawing.Point(348, 296);
            this.lblDateArrivee.Name = "lblDateArrivee";
            this.lblDateArrivee.Size = new System.Drawing.Size(116, 13);
            this.lblDateArrivee.TabIndex = 6;
            this.lblDateArrivee.Text = "Date et heure arrivée  :";
            // 
            // dtpDepartHeure
            // 
            this.dtpDepartHeure.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDepartHeure.Location = new System.Drawing.Point(660, 227);
            this.dtpDepartHeure.Name = "dtpDepartHeure";
            this.dtpDepartHeure.ShowUpDown = true;
            this.dtpDepartHeure.Size = new System.Drawing.Size(85, 20);
            this.dtpDepartHeure.TabIndex = 7;
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
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // dtpDepartDate
            // 
            this.dtpDepartDate.Location = new System.Drawing.Point(470, 227);
            this.dtpDepartDate.Name = "dtpDepartDate";
            this.dtpDepartDate.Size = new System.Drawing.Size(184, 20);
            this.dtpDepartDate.TabIndex = 11;
            // 
            // dtpArriveeDate
            // 
            this.dtpArriveeDate.Location = new System.Drawing.Point(470, 296);
            this.dtpArriveeDate.Name = "dtpArriveeDate";
            this.dtpArriveeDate.Size = new System.Drawing.Size(184, 20);
            this.dtpArriveeDate.TabIndex = 13;
            this.dtpArriveeDate.ValueChanged += new System.EventHandler(this.dtpArriveDate_ValueChanged);
            // 
            // dtpArriveeHeure
            // 
            this.dtpArriveeHeure.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpArriveeHeure.Location = new System.Drawing.Point(660, 296);
            this.dtpArriveeHeure.Name = "dtpArriveeHeure";
            this.dtpArriveeHeure.ShowUpDown = true;
            this.dtpArriveeHeure.Size = new System.Drawing.Size(85, 20);
            this.dtpArriveeHeure.TabIndex = 12;
            this.dtpArriveeHeure.ValueChanged += new System.EventHandler(this.dtpArriveeHeure_ValueChanged);
            // 
            // AjouterTraversé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpArriveeDate);
            this.Controls.Add(this.dtpArriveeHeure);
            this.Controls.Add(this.dtpDepartDate);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.cmbBateau);
            this.Controls.Add(this.dtpDepartHeure);
            this.Controls.Add(this.lblDateArrivee);
            this.Controls.Add(this.lblDateDepart);
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
        private System.Windows.Forms.Label lblDateDepart;
        private System.Windows.Forms.Label lblDateArrivee;
        private System.Windows.Forms.DateTimePicker dtpDepartHeure;
        private System.Windows.Forms.ComboBox cmbBateau;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DateTimePicker dtpDepartDate;
        private System.Windows.Forms.DateTimePicker dtpArriveeDate;
        private System.Windows.Forms.DateTimePicker dtpArriveeHeure;
    }
}