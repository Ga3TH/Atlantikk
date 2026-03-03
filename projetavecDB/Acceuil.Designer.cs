namespace projetavecDB
{
    partial class Acceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterSecteur = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterPort = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterLiaison = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterTarif = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterTraverse = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModifierBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModifierParametre = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAfficherTraverse = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAfficherDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAcceuil = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.afficherToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAjouterSecteur,
            this.btnAjouterPort,
            this.btnAjouterLiaison,
            this.btnAjouterTarif,
            this.btnAjouterBateau,
            this.btnAjouterTraverse});
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // btnAjouterSecteur
            // 
            this.btnAjouterSecteur.Name = "btnAjouterSecteur";
            this.btnAjouterSecteur.Size = new System.Drawing.Size(278, 22);
            this.btnAjouterSecteur.Text = " Un Secteur";
            this.btnAjouterSecteur.Click += new System.EventHandler(this.btnAjouterSecteur_Click);
            // 
            // btnAjouterPort
            // 
            this.btnAjouterPort.Name = "btnAjouterPort";
            this.btnAjouterPort.Size = new System.Drawing.Size(278, 22);
            this.btnAjouterPort.Text = "Un Port";
            this.btnAjouterPort.Click += new System.EventHandler(this.btnAjouterPort_Click);
            // 
            // btnAjouterLiaison
            // 
            this.btnAjouterLiaison.Name = "btnAjouterLiaison";
            this.btnAjouterLiaison.Size = new System.Drawing.Size(278, 22);
            this.btnAjouterLiaison.Text = "Une Liaison";
            this.btnAjouterLiaison.Click += new System.EventHandler(this.btnAjouterLiaison_Click);
            // 
            // btnAjouterTarif
            // 
            this.btnAjouterTarif.Name = "btnAjouterTarif";
            this.btnAjouterTarif.Size = new System.Drawing.Size(278, 22);
            this.btnAjouterTarif.Text = "Les Tarif pour une liaison et un periode";
            this.btnAjouterTarif.Click += new System.EventHandler(this.btnAjouterTarif_Click);
            // 
            // btnAjouterBateau
            // 
            this.btnAjouterBateau.Name = "btnAjouterBateau";
            this.btnAjouterBateau.Size = new System.Drawing.Size(278, 22);
            this.btnAjouterBateau.Text = "Un Bateau";
            this.btnAjouterBateau.Click += new System.EventHandler(this.btnAjouterBateau_Click);
            // 
            // btnAjouterTraverse
            // 
            this.btnAjouterTraverse.Name = "btnAjouterTraverse";
            this.btnAjouterTraverse.Size = new System.Drawing.Size(278, 22);
            this.btnAjouterTraverse.Text = "Une Traversée";
            this.btnAjouterTraverse.Click += new System.EventHandler(this.btnAjouterTraverse_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModifierBateau,
            this.btnModifierParametre});
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // btnModifierBateau
            // 
            this.btnModifierBateau.Name = "btnModifierBateau";
            this.btnModifierBateau.Size = new System.Drawing.Size(191, 22);
            this.btnModifierBateau.Text = "Un Bateau";
            this.btnModifierBateau.Click += new System.EventHandler(this.btnModifierBateau_Click);
            // 
            // btnModifierParametre
            // 
            this.btnModifierParametre.Name = "btnModifierParametre";
            this.btnModifierParametre.Size = new System.Drawing.Size(191, 22);
            this.btnModifierParametre.Text = "Les paramètres du site";
            this.btnModifierParametre.Click += new System.EventHandler(this.btnModifierParametre_Click);
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAfficherTraverse,
            this.btnAfficherDetails});
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.afficherToolStripMenuItem.Text = "Afficher";
            // 
            // btnAfficherTraverse
            // 
            this.btnAfficherTraverse.Name = "btnAfficherTraverse";
            this.btnAfficherTraverse.Size = new System.Drawing.Size(513, 22);
            this.btnAfficherTraverse.Text = "Les traversées pour un liaison et une date donnée avec places restante par catégo" +
    "rie";
            this.btnAfficherTraverse.Click += new System.EventHandler(this.btnAfficherTraverse_Click);
            // 
            // btnAfficherDetails
            // 
            this.btnAfficherDetails.Name = "btnAfficherDetails";
            this.btnAfficherDetails.Size = new System.Drawing.Size(513, 22);
            this.btnAfficherDetails.Text = "Details d\'une reservation pour un client";
            this.btnAfficherDetails.Click += new System.EventHandler(this.btnAfficherDetails_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aProposToolStripMenuItem.Text = "A Propos";
            // 
            // lblAcceuil
            // 
            this.lblAcceuil.AutoSize = true;
            this.lblAcceuil.Location = new System.Drawing.Point(370, 157);
            this.lblAcceuil.Name = "lblAcceuil";
            this.lblAcceuil.Size = new System.Drawing.Size(52, 13);
            this.lblAcceuil.TabIndex = 1;
            this.lblAcceuil.Text = "ACCEUIL";
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAcceuil);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Acceuil";
            this.Text = "Atlantikk";
            this.Load += new System.EventHandler(this.Acceuil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAjouterSecteur;
        private System.Windows.Forms.ToolStripMenuItem btnAjouterPort;
        private System.Windows.Forms.ToolStripMenuItem btnAjouterLiaison;
        private System.Windows.Forms.ToolStripMenuItem btnAjouterTarif;
        private System.Windows.Forms.ToolStripMenuItem btnAjouterTraverse;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAfficherTraverse;
        private System.Windows.Forms.ToolStripMenuItem btnAfficherDetails;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnModifierBateau;
        private System.Windows.Forms.ToolStripMenuItem btnModifierParametre;
        private System.Windows.Forms.ToolStripMenuItem btnAjouterBateau;
        private System.Windows.Forms.Label lblAcceuil;
    }
}

