namespace projetavecDB
{
    partial class AjouterLiaison
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
            this.lbxSecteurs = new System.Windows.Forms.ListBox();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.cmbDepart = new System.Windows.Forms.ComboBox();
            this.cmbArrivée = new System.Windows.Forms.ComboBox();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblArrivée = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.tbxDistance = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxSecteurs
            // 
            this.lbxSecteurs.FormattingEnabled = true;
            this.lbxSecteurs.Location = new System.Drawing.Point(28, 76);
            this.lbxSecteurs.Name = "lbxSecteurs";
            this.lbxSecteurs.Size = new System.Drawing.Size(161, 329);
            this.lbxSecteurs.TabIndex = 0;
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(28, 37);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(55, 13);
            this.lblSecteur.TabIndex = 1;
            this.lblSecteur.Text = "Secteurs :";
            // 
            // cmbDepart
            // 
            this.cmbDepart.FormattingEnabled = true;
            this.cmbDepart.Location = new System.Drawing.Point(350, 89);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Size = new System.Drawing.Size(121, 21);
            this.cmbDepart.TabIndex = 2;
            // 
            // cmbArrivée
            // 
            this.cmbArrivée.FormattingEnabled = true;
            this.cmbArrivée.Location = new System.Drawing.Point(654, 88);
            this.cmbArrivée.Name = "cmbArrivée";
            this.cmbArrivée.Size = new System.Drawing.Size(121, 21);
            this.cmbArrivée.TabIndex = 3;
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(250, 92);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(45, 13);
            this.lblDepart.TabIndex = 4;
            this.lblDepart.Text = "Depart :";
            // 
            // lblArrivée
            // 
            this.lblArrivée.AutoSize = true;
            this.lblArrivée.Location = new System.Drawing.Point(568, 92);
            this.lblArrivée.Name = "lblArrivée";
            this.lblArrivée.Size = new System.Drawing.Size(46, 13);
            this.lblArrivée.TabIndex = 5;
            this.lblArrivée.Text = "Arrivée :";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(545, 249);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(49, 13);
            this.lblDistance.TabIndex = 6;
            this.lblDistance.Text = "Distance";
            // 
            // tbxDistance
            // 
            this.tbxDistance.Location = new System.Drawing.Point(625, 242);
            this.tbxDistance.Name = "tbxDistance";
            this.tbxDistance.Size = new System.Drawing.Size(115, 20);
            this.tbxDistance.TabIndex = 7;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(504, 307);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(196, 56);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // AjouterLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.tbxDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblArrivée);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.cmbArrivée);
            this.Controls.Add(this.cmbDepart);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lbxSecteurs);
            this.Name = "AjouterLiaison";
            this.Text = "AjouterLiaison";
            this.Load += new System.EventHandler(this.AjouterLiaison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSecteurs;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.ComboBox cmbDepart;
        private System.Windows.Forms.ComboBox cmbArrivée;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblArrivée;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox tbxDistance;
        private System.Windows.Forms.Button btnValider;
    }
}