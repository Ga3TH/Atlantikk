namespace projetavecDB
{
    partial class AjouterTarif
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxSecteurs = new System.Windows.Forms.ListBox();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(543, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(389, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 273);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lbxSecteurs
            // 
            this.lbxSecteurs.FormattingEnabled = true;
            this.lbxSecteurs.Location = new System.Drawing.Point(53, 38);
            this.lbxSecteurs.Name = "lbxSecteurs";
            this.lbxSecteurs.Size = new System.Drawing.Size(170, 199);
            this.lbxSecteurs.TabIndex = 3;
            this.lbxSecteurs.SelectedIndexChanged += new System.EventHandler(this.lbxSecteurs_SelectedIndexChanged);
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(50, 22);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(44, 13);
            this.lblSecteur.TabIndex = 4;
            this.lblSecteur.Text = "Secteur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Liaison";
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(53, 283);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaison.TabIndex = 6;
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.Location = new System.Drawing.Point(53, 340);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(49, 13);
            this.lblPeriode.TabIndex = 7;
            this.lblPeriode.Text = "Periode :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 337);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // AjouterTarif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPeriode);
            this.Controls.Add(this.cmbLiaison);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lbxSecteurs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Name = "AjouterTarif";
            this.Text = "AjouterTarif";
            this.Load += new System.EventHandler(this.AjouterTarif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxSecteurs;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}