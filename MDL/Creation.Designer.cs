namespace MDL
{
    partial class Creation
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AffectationStand = new System.Windows.Forms.TabPage();
            this.lbPrix = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.cbxPartenaire = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxNomStand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreationStand = new System.Windows.Forms.TabPage();
            this.btnAnnulerStand = new System.Windows.Forms.Button();
            this.btnCreationStand = new System.Windows.Forms.Button();
            this.txbNombreTables = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbNombreSiege = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbNumOrdre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbNumAlle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSurfaceStand = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNomStand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Equipements = new System.Windows.Forms.TabPage();
            this.btnValiderEquipement = new System.Windows.Forms.Button();
            this.txbPrixEquipementier = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbNomEquipement = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listeGestionEquipement = new System.Windows.Forms.DataGridView();
            this.btnValiderGestionStands = new System.Windows.Forms.Button();
            this.cbxGestionEquipement = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxGestionsNonStands = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txbPrixClubOrganisateur = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.TabPage();
            this.dgvListeStandAqui = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.AffectationStand.SuspendLayout();
            this.CreationStand.SuspendLayout();
            this.Equipements.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeGestionEquipement)).BeginInit();
            this.Liste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeStandAqui)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AffectationStand);
            this.tabControl1.Controls.Add(this.CreationStand);
            this.tabControl1.Controls.Add(this.Equipements);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Liste);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(-5, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 637);
            this.tabControl1.TabIndex = 6;
            // 
            // AffectationStand
            // 
            this.AffectationStand.Controls.Add(this.lbPrix);
            this.AffectationStand.Controls.Add(this.label10);
            this.AffectationStand.Controls.Add(this.btnValider);
            this.AffectationStand.Controls.Add(this.cbxPartenaire);
            this.AffectationStand.Controls.Add(this.label3);
            this.AffectationStand.Controls.Add(this.cbxNomStand);
            this.AffectationStand.Controls.Add(this.label2);
            this.AffectationStand.Controls.Add(this.label1);
            this.AffectationStand.Location = new System.Drawing.Point(4, 22);
            this.AffectationStand.Name = "AffectationStand";
            this.AffectationStand.Padding = new System.Windows.Forms.Padding(3);
            this.AffectationStand.Size = new System.Drawing.Size(765, 611);
            this.AffectationStand.TabIndex = 0;
            this.AffectationStand.Text = "Affectation des stands";
            this.AffectationStand.UseVisualStyleBackColor = true;
            // 
            // lbPrix
            // 
            this.lbPrix.AutoSize = true;
            this.lbPrix.Location = new System.Drawing.Point(182, 170);
            this.lbPrix.Name = "lbPrix";
            this.lbPrix.Size = new System.Drawing.Size(24, 13);
            this.lbPrix.TabIndex = 7;
            this.lbPrix.Text = "Prix";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label10.Location = new System.Drawing.Point(89, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Prix total : ";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(402, 252);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(213, 27);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // cbxPartenaire
            // 
            this.cbxPartenaire.FormattingEnabled = true;
            this.cbxPartenaire.Location = new System.Drawing.Point(185, 129);
            this.cbxPartenaire.Name = "cbxPartenaire";
            this.cbxPartenaire.Size = new System.Drawing.Size(430, 21);
            this.cbxPartenaire.TabIndex = 4;
            this.cbxPartenaire.SelectedIndexChanged += new System.EventHandler(this.cbxPrestataire_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(78, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Partenaire : ";
            // 
            // cbxNomStand
            // 
            this.cbxNomStand.FormattingEnabled = true;
            this.cbxNomStand.Location = new System.Drawing.Point(186, 81);
            this.cbxNomStand.Name = "cbxNomStand";
            this.cbxNomStand.Size = new System.Drawing.Size(429, 21);
            this.cbxNomStand.TabIndex = 2;
            this.cbxNomStand.SelectedIndexChanged += new System.EventHandler(this.cbxNomStand_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(51, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du stand : ";
            // 
            // CreationStand
            // 
            this.CreationStand.Controls.Add(this.btnAnnulerStand);
            this.CreationStand.Controls.Add(this.btnCreationStand);
            this.CreationStand.Controls.Add(this.txbNombreTables);
            this.CreationStand.Controls.Add(this.label9);
            this.CreationStand.Controls.Add(this.txbNombreSiege);
            this.CreationStand.Controls.Add(this.label8);
            this.CreationStand.Controls.Add(this.txbNumOrdre);
            this.CreationStand.Controls.Add(this.label7);
            this.CreationStand.Controls.Add(this.txbNumAlle);
            this.CreationStand.Controls.Add(this.label6);
            this.CreationStand.Controls.Add(this.txbSurfaceStand);
            this.CreationStand.Controls.Add(this.label5);
            this.CreationStand.Controls.Add(this.txbNomStand);
            this.CreationStand.Controls.Add(this.label4);
            this.CreationStand.Location = new System.Drawing.Point(4, 22);
            this.CreationStand.Name = "CreationStand";
            this.CreationStand.Padding = new System.Windows.Forms.Padding(3);
            this.CreationStand.Size = new System.Drawing.Size(765, 611);
            this.CreationStand.TabIndex = 1;
            this.CreationStand.Text = "Création stand";
            this.CreationStand.UseVisualStyleBackColor = true;
            // 
            // btnAnnulerStand
            // 
            this.btnAnnulerStand.Location = new System.Drawing.Point(457, 349);
            this.btnAnnulerStand.Name = "btnAnnulerStand";
            this.btnAnnulerStand.Size = new System.Drawing.Size(213, 27);
            this.btnAnnulerStand.TabIndex = 16;
            this.btnAnnulerStand.Text = "Annuler";
            this.btnAnnulerStand.UseVisualStyleBackColor = true;
            this.btnAnnulerStand.Click += new System.EventHandler(this.btnAnnulerStand_Click);
            // 
            // btnCreationStand
            // 
            this.btnCreationStand.Location = new System.Drawing.Point(195, 349);
            this.btnCreationStand.Name = "btnCreationStand";
            this.btnCreationStand.Size = new System.Drawing.Size(213, 27);
            this.btnCreationStand.TabIndex = 13;
            this.btnCreationStand.Text = "Valider";
            this.btnCreationStand.UseVisualStyleBackColor = true;
            this.btnCreationStand.Click += new System.EventHandler(this.btnCreationStand_Click);
            // 
            // txbNombreTables
            // 
            this.txbNombreTables.Location = new System.Drawing.Point(560, 257);
            this.txbNombreTables.Name = "txbNombreTables";
            this.txbNombreTables.Size = new System.Drawing.Size(159, 20);
            this.txbNombreTables.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.Location = new System.Drawing.Point(398, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nombre de tables : ";
            // 
            // txbNombreSiege
            // 
            this.txbNombreSiege.Location = new System.Drawing.Point(194, 257);
            this.txbNombreSiege.Name = "txbNombreSiege";
            this.txbNombreSiege.Size = new System.Drawing.Size(159, 20);
            this.txbNombreSiege.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(28, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nombre de sièges : ";
            // 
            // txbNumOrdre
            // 
            this.txbNumOrdre.Location = new System.Drawing.Point(194, 196);
            this.txbNumOrdre.Name = "txbNumOrdre";
            this.txbNumOrdre.Size = new System.Drawing.Size(383, 20);
            this.txbNumOrdre.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(48, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Numéro d\'ordre : ";
            // 
            // txbNumAlle
            // 
            this.txbNumAlle.Location = new System.Drawing.Point(194, 146);
            this.txbNumAlle.Name = "txbNumAlle";
            this.txbNumAlle.Size = new System.Drawing.Size(383, 20);
            this.txbNumAlle.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(52, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numéro d\'allée : ";
            // 
            // txbSurfaceStand
            // 
            this.txbSurfaceStand.Location = new System.Drawing.Point(194, 98);
            this.txbSurfaceStand.Name = "txbSurfaceStand";
            this.txbSurfaceStand.Size = new System.Drawing.Size(383, 20);
            this.txbSurfaceStand.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(106, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Surface : ";
            // 
            // txbNomStand
            // 
            this.txbNomStand.Location = new System.Drawing.Point(195, 47);
            this.txbNomStand.Name = "txbNomStand";
            this.txbNomStand.Size = new System.Drawing.Size(383, 20);
            this.txbNomStand.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(60, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nom du stand : ";
            // 
            // Equipements
            // 
            this.Equipements.Controls.Add(this.label15);
            this.Equipements.Controls.Add(this.txbPrixClubOrganisateur);
            this.Equipements.Controls.Add(this.btnValiderEquipement);
            this.Equipements.Controls.Add(this.txbPrixEquipementier);
            this.Equipements.Controls.Add(this.label11);
            this.Equipements.Controls.Add(this.txbNomEquipement);
            this.Equipements.Controls.Add(this.label12);
            this.Equipements.Location = new System.Drawing.Point(4, 22);
            this.Equipements.Name = "Equipements";
            this.Equipements.Padding = new System.Windows.Forms.Padding(3);
            this.Equipements.Size = new System.Drawing.Size(765, 611);
            this.Equipements.TabIndex = 2;
            this.Equipements.Text = "Equipements";
            this.Equipements.UseVisualStyleBackColor = true;
            // 
            // btnValiderEquipement
            // 
            this.btnValiderEquipement.Location = new System.Drawing.Point(272, 306);
            this.btnValiderEquipement.Name = "btnValiderEquipement";
            this.btnValiderEquipement.Size = new System.Drawing.Size(235, 27);
            this.btnValiderEquipement.TabIndex = 14;
            this.btnValiderEquipement.Text = "Valider";
            this.btnValiderEquipement.UseVisualStyleBackColor = true;
            this.btnValiderEquipement.Click += new System.EventHandler(this.btnValiderEquipement_Click);
            // 
            // txbPrixEquipementier
            // 
            this.txbPrixEquipementier.Location = new System.Drawing.Point(272, 179);
            this.txbPrixEquipementier.Name = "txbPrixEquipementier";
            this.txbPrixEquipementier.Size = new System.Drawing.Size(234, 20);
            this.txbPrixEquipementier.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label11.Location = new System.Drawing.Point(106, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Prix Equipementier :";
            // 
            // txbNomEquipement
            // 
            this.txbNomEquipement.Location = new System.Drawing.Point(273, 129);
            this.txbNomEquipement.Name = "txbNomEquipement";
            this.txbNomEquipement.Size = new System.Drawing.Size(234, 20);
            this.txbNomEquipement.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label12.Location = new System.Drawing.Point(121, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Nom équipement :";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listeGestionEquipement);
            this.tabPage1.Controls.Add(this.btnValiderGestionStands);
            this.tabPage1.Controls.Add(this.cbxGestionEquipement);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.cbxGestionsNonStands);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(765, 611);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Gestion des stands";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listeGestionEquipement
            // 
            this.listeGestionEquipement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listeGestionEquipement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeGestionEquipement.Location = new System.Drawing.Point(241, 160);
            this.listeGestionEquipement.Name = "listeGestionEquipement";
            this.listeGestionEquipement.Size = new System.Drawing.Size(429, 214);
            this.listeGestionEquipement.TabIndex = 20;
            // 
            // btnValiderGestionStands
            // 
            this.btnValiderGestionStands.Location = new System.Drawing.Point(241, 404);
            this.btnValiderGestionStands.Name = "btnValiderGestionStands";
            this.btnValiderGestionStands.Size = new System.Drawing.Size(429, 27);
            this.btnValiderGestionStands.TabIndex = 19;
            this.btnValiderGestionStands.Text = "Valider";
            this.btnValiderGestionStands.UseVisualStyleBackColor = true;
            this.btnValiderGestionStands.Click += new System.EventHandler(this.btnValiderGestionStands_Click);
            // 
            // cbxGestionEquipement
            // 
            this.cbxGestionEquipement.FormattingEnabled = true;
            this.cbxGestionEquipement.Location = new System.Drawing.Point(241, 101);
            this.cbxGestionEquipement.Name = "cbxGestionEquipement";
            this.cbxGestionEquipement.Size = new System.Drawing.Size(429, 21);
            this.cbxGestionEquipement.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label14.Location = new System.Drawing.Point(114, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Equipements : ";
            // 
            // cbxGestionsNonStands
            // 
            this.cbxGestionsNonStands.FormattingEnabled = true;
            this.cbxGestionsNonStands.Location = new System.Drawing.Point(241, 48);
            this.cbxGestionsNonStands.Name = "cbxGestionsNonStands";
            this.cbxGestionsNonStands.Size = new System.Drawing.Size(429, 21);
            this.cbxGestionsNonStands.TabIndex = 3;
            this.cbxGestionsNonStands.SelectedIndexChanged += new System.EventHandler(this.cbxGestionsNonStands_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label13.Location = new System.Drawing.Point(107, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nom du stand : ";
            // 
            // txbPrixClubOrganisateur
            // 
            this.txbPrixClubOrganisateur.Location = new System.Drawing.Point(272, 233);
            this.txbPrixClubOrganisateur.Name = "txbPrixClubOrganisateur";
            this.txbPrixClubOrganisateur.Size = new System.Drawing.Size(234, 20);
            this.txbPrixClubOrganisateur.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label15.Location = new System.Drawing.Point(77, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(189, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "Prix Club Organisateur :";
            // 
            // Liste
            // 
            this.Liste.Controls.Add(this.dgvListeStandAqui);
            this.Liste.Location = new System.Drawing.Point(4, 22);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(765, 611);
            this.Liste.TabIndex = 4;
            this.Liste.Text = "Stand aquis par un prestataire";
            this.Liste.UseVisualStyleBackColor = true;
            // 
            // dgvListeStandAqui
            // 
            this.dgvListeStandAqui.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeStandAqui.Location = new System.Drawing.Point(127, 124);
            this.dgvListeStandAqui.Name = "dgvListeStandAqui";
            this.dgvListeStandAqui.Size = new System.Drawing.Size(565, 336);
            this.dgvListeStandAqui.TabIndex = 0;
            // 
            // Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 635);
            this.Controls.Add(this.tabControl1);
            this.Name = "Creation";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Creation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.AffectationStand.ResumeLayout(false);
            this.AffectationStand.PerformLayout();
            this.CreationStand.ResumeLayout(false);
            this.CreationStand.PerformLayout();
            this.Equipements.ResumeLayout(false);
            this.Equipements.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeGestionEquipement)).EndInit();
            this.Liste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeStandAqui)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AffectationStand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage CreationStand;
        private System.Windows.Forms.TabPage Equipements;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPartenaire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxNomStand;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txbNomStand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSurfaceStand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbNumAlle;
        private System.Windows.Forms.TextBox txbNumOrdre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbNombreSiege;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbNombreTables;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCreationStand;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAnnulerStand;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnValiderEquipement;
        private System.Windows.Forms.TextBox txbPrixEquipementier;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbNomEquipement;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbxGestionsNonStands;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxGestionEquipement;
        private System.Windows.Forms.Button btnValiderGestionStands;
        private System.Windows.Forms.DataGridView listeGestionEquipement;
        private System.Windows.Forms.Label lbPrix;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbPrixClubOrganisateur;
        private System.Windows.Forms.TabPage Liste;
        private System.Windows.Forms.DataGridView dgvListeStandAqui;
    }
}

