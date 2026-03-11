namespace projetavecDB
{
    partial class AfficherTraversé
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
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.lvTraversee = new System.Windows.Forms.ListView();
            this.dtpDepartDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAfficher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(13, 36);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(55, 13);
            this.lblSecteur.TabIndex = 7;
            this.lblSecteur.Text = "Secteurs :";
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.Location = new System.Drawing.Point(84, 36);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(128, 251);
            this.lbxSecteur.TabIndex = 6;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(22, 348);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(46, 13);
            this.lblLiaison.TabIndex = 5;
            this.lblLiaison.Text = "Liaison :";
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(74, 348);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaison.TabIndex = 4;
            // 
            // lvTraversee
            // 
            this.lvTraversee.HideSelection = false;
            this.lvTraversee.Location = new System.Drawing.Point(263, 124);
            this.lvTraversee.Name = "lvTraversee";
            this.lvTraversee.Size = new System.Drawing.Size(510, 245);
            this.lvTraversee.TabIndex = 8;
            this.lvTraversee.UseCompatibleStateImageBehavior = false;
            // 
            // dtpDepartDate
            // 
            this.dtpDepartDate.Location = new System.Drawing.Point(399, 36);
            this.dtpDepartDate.Name = "dtpDepartDate";
            this.dtpDepartDate.Size = new System.Drawing.Size(184, 20);
            this.dtpDepartDate.TabIndex = 14;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(244, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(152, 13);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date (par défaut date du jour) :";
            // 
            // lblAfficher
            // 
            this.lblAfficher.Location = new System.Drawing.Point(305, 83);
            this.lblAfficher.Name = "lblAfficher";
            this.lblAfficher.Size = new System.Drawing.Size(438, 35);
            this.lblAfficher.TabIndex = 15;
            this.lblAfficher.Text = "Afficher les traversées";
            this.lblAfficher.UseVisualStyleBackColor = true;
            this.lblAfficher.Click += new System.EventHandler(this.lblAfficher_Click);
            // 
            // AfficherTraversé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAfficher);
            this.Controls.Add(this.dtpDepartDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lvTraversee);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lbxSecteur);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.cmbLiaison);
            this.Name = "AfficherTraversé";
            this.Text = "AfficherTraversé";
            this.Load += new System.EventHandler(this.AfficherTraversé_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.ListView lvTraversee;
        private System.Windows.Forms.DateTimePicker dtpDepartDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button lblAfficher;
    }
}