namespace VoitureOnLine
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.GBType = new System.Windows.Forms.GroupBox();
            this.RBLimousine = new System.Windows.Forms.RadioButton();
            this.RBFamiliale = new System.Windows.Forms.RadioButton();
            this.RBCompacte = new System.Windows.Forms.RadioButton();
            this.RBCitadine = new System.Windows.Forms.RadioButton();
            this.checkB4portes = new System.Windows.Forms.CheckBox();
            this.checkBCabriolet = new System.Windows.Forms.CheckBox();
            this.BTValider = new System.Windows.Forms.Button();
            this.BTAnnuler = new System.Windows.Forms.Button();
            this.BTQuitter = new System.Windows.Forms.Button();
            this.TBClient = new System.Windows.Forms.TextBox();
            this.CBFinitionInter = new System.Windows.Forms.ComboBox();
            this.CBFinitionExter = new System.Windows.Forms.ComboBox();
            this.CBCouleur = new System.Windows.Forms.ComboBox();
            this.CBMotorisation = new System.Windows.Forms.ComboBox();
            this.LBSelection = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMAfficher = new System.Windows.Forms.ToolStripMenuItem();
            this.AfficheSimu = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GBType.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Coolvetica Rg", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(263, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "VOITURE ON LINE";
            // 
            // GBType
            // 
            this.GBType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GBType.Controls.Add(this.RBLimousine);
            this.GBType.Controls.Add(this.RBFamiliale);
            this.GBType.Controls.Add(this.RBCompacte);
            this.GBType.Controls.Add(this.RBCitadine);
            this.GBType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBType.Location = new System.Drawing.Point(33, 80);
            this.GBType.Name = "GBType";
            this.GBType.Size = new System.Drawing.Size(123, 146);
            this.GBType.TabIndex = 3;
            this.GBType.TabStop = false;
            this.GBType.Text = "Type";
            // 
            // RBLimousine
            // 
            this.RBLimousine.AutoSize = true;
            this.RBLimousine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBLimousine.Location = new System.Drawing.Point(19, 107);
            this.RBLimousine.Name = "RBLimousine";
            this.RBLimousine.Size = new System.Drawing.Size(81, 17);
            this.RBLimousine.TabIndex = 3;
            this.RBLimousine.TabStop = true;
            this.RBLimousine.Text = "Limousine";
            this.RBLimousine.UseVisualStyleBackColor = true;
            this.RBLimousine.CheckedChanged += new System.EventHandler(this.RBLimousine_CheckedChanged);
            // 
            // RBFamiliale
            // 
            this.RBFamiliale.AutoSize = true;
            this.RBFamiliale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBFamiliale.Location = new System.Drawing.Point(19, 84);
            this.RBFamiliale.Name = "RBFamiliale";
            this.RBFamiliale.Size = new System.Drawing.Size(74, 17);
            this.RBFamiliale.TabIndex = 2;
            this.RBFamiliale.TabStop = true;
            this.RBFamiliale.Text = "Familiale";
            this.RBFamiliale.UseVisualStyleBackColor = true;
            this.RBFamiliale.CheckedChanged += new System.EventHandler(this.RBFamiliale_CheckedChanged);
            // 
            // RBCompacte
            // 
            this.RBCompacte.AutoSize = true;
            this.RBCompacte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBCompacte.Location = new System.Drawing.Point(19, 59);
            this.RBCompacte.Name = "RBCompacte";
            this.RBCompacte.Size = new System.Drawing.Size(81, 17);
            this.RBCompacte.TabIndex = 1;
            this.RBCompacte.TabStop = true;
            this.RBCompacte.Text = "Compacte";
            this.RBCompacte.UseVisualStyleBackColor = true;
            this.RBCompacte.CheckedChanged += new System.EventHandler(this.RBCompacte_CheckedChanged);
            // 
            // RBCitadine
            // 
            this.RBCitadine.AutoSize = true;
            this.RBCitadine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBCitadine.Location = new System.Drawing.Point(19, 35);
            this.RBCitadine.Name = "RBCitadine";
            this.RBCitadine.Size = new System.Drawing.Size(71, 17);
            this.RBCitadine.TabIndex = 0;
            this.RBCitadine.TabStop = true;
            this.RBCitadine.Text = "Citadine";
            this.RBCitadine.UseVisualStyleBackColor = true;
            this.RBCitadine.CheckedChanged += new System.EventHandler(this.RBCitadine_CheckedChanged);
            // 
            // checkB4portes
            // 
            this.checkB4portes.AutoSize = true;
            this.checkB4portes.Location = new System.Drawing.Point(51, 267);
            this.checkB4portes.Name = "checkB4portes";
            this.checkB4portes.Size = new System.Drawing.Size(73, 17);
            this.checkB4portes.TabIndex = 4;
            this.checkB4portes.Text = "4 Portes";
            this.checkB4portes.UseVisualStyleBackColor = true;
            // 
            // checkBCabriolet
            // 
            this.checkBCabriolet.AutoSize = true;
            this.checkBCabriolet.Location = new System.Drawing.Point(51, 291);
            this.checkBCabriolet.Name = "checkBCabriolet";
            this.checkBCabriolet.Size = new System.Drawing.Size(76, 17);
            this.checkBCabriolet.TabIndex = 5;
            this.checkBCabriolet.Text = "Cabriolet";
            this.checkBCabriolet.UseVisualStyleBackColor = true;
            // 
            // BTValider
            // 
            this.BTValider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BTValider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BTValider.Location = new System.Drawing.Point(102, 385);
            this.BTValider.Name = "BTValider";
            this.BTValider.Size = new System.Drawing.Size(87, 23);
            this.BTValider.TabIndex = 11;
            this.BTValider.Text = "&Valider";
            this.BTValider.UseVisualStyleBackColor = true;
            this.BTValider.Click += new System.EventHandler(this.BTValider_Click);
            // 
            // BTAnnuler
            // 
            this.BTAnnuler.Location = new System.Drawing.Point(324, 385);
            this.BTAnnuler.Name = "BTAnnuler";
            this.BTAnnuler.Size = new System.Drawing.Size(87, 23);
            this.BTAnnuler.TabIndex = 12;
            this.BTAnnuler.Text = "&Annuler";
            this.BTAnnuler.UseVisualStyleBackColor = true;
            this.BTAnnuler.Click += new System.EventHandler(this.BTAnnuler_Click);
            // 
            // BTQuitter
            // 
            this.BTQuitter.Location = new System.Drawing.Point(562, 385);
            this.BTQuitter.Name = "BTQuitter";
            this.BTQuitter.Size = new System.Drawing.Size(87, 23);
            this.BTQuitter.TabIndex = 13;
            this.BTQuitter.Text = "&Quitter";
            this.BTQuitter.UseVisualStyleBackColor = true;
            this.BTQuitter.Click += new System.EventHandler(this.BTQuitter_Click);
            // 
            // TBClient
            // 
            this.TBClient.Location = new System.Drawing.Point(593, 41);
            this.TBClient.Name = "TBClient";
            this.TBClient.Size = new System.Drawing.Size(116, 20);
            this.TBClient.TabIndex = 9;
            this.TBClient.TabStop = false;
            // 
            // CBFinitionInter
            // 
            this.CBFinitionInter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBFinitionInter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFinitionInter.FormattingEnabled = true;
            this.CBFinitionInter.Items.AddRange(new object[] {
            "Young",
            "Luxe",
            "Sport"});
            this.CBFinitionInter.Location = new System.Drawing.Point(593, 108);
            this.CBFinitionInter.Name = "CBFinitionInter";
            this.CBFinitionInter.Size = new System.Drawing.Size(140, 21);
            this.CBFinitionInter.TabIndex = 7;
            // 
            // CBFinitionExter
            // 
            this.CBFinitionExter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBFinitionExter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFinitionExter.FormattingEnabled = true;
            this.CBFinitionExter.Items.AddRange(new object[] {
            "Urban",
            "Pack",
            "Ambition"});
            this.CBFinitionExter.Location = new System.Drawing.Point(593, 159);
            this.CBFinitionExter.Name = "CBFinitionExter";
            this.CBFinitionExter.Size = new System.Drawing.Size(140, 21);
            this.CBFinitionExter.TabIndex = 8;
            // 
            // CBCouleur
            // 
            this.CBCouleur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCouleur.FormattingEnabled = true;
            this.CBCouleur.Items.AddRange(new object[] {
            "Métallisé",
            "Vernie",
            "Brillante",
            "Mate"});
            this.CBCouleur.Location = new System.Drawing.Point(593, 203);
            this.CBCouleur.Name = "CBCouleur";
            this.CBCouleur.Size = new System.Drawing.Size(140, 21);
            this.CBCouleur.TabIndex = 9;
            // 
            // CBMotorisation
            // 
            this.CBMotorisation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBMotorisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMotorisation.FormattingEnabled = true;
            this.CBMotorisation.Items.AddRange(new object[] {
            "Essence",
            "Gasoil",
            "Hybride"});
            this.CBMotorisation.Location = new System.Drawing.Point(593, 250);
            this.CBMotorisation.Name = "CBMotorisation";
            this.CBMotorisation.Size = new System.Drawing.Size(140, 21);
            this.CBMotorisation.TabIndex = 10;
            // 
            // LBSelection
            // 
            this.LBSelection.AutoSize = true;
            this.LBSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBSelection.ForeColor = System.Drawing.Color.Green;
            this.LBSelection.Location = new System.Drawing.Point(184, 340);
            this.LBSelection.Name = "LBSelection";
            this.LBSelection.Size = new System.Drawing.Size(47, 15);
            this.LBSelection.TabIndex = 14;
            this.LBSelection.Text = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMAfficher});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(767, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMAfficher
            // 
            this.TSMAfficher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AfficheSimu});
            this.TSMAfficher.Name = "TSMAfficher";
            this.TSMAfficher.Size = new System.Drawing.Size(61, 20);
            this.TSMAfficher.Text = "Afficher";
            // 
            // AfficheSimu
            // 
            this.AfficheSimu.Name = "AfficheSimu";
            this.AfficheSimu.Size = new System.Drawing.Size(197, 22);
            this.AfficheSimu.Text = "Afficher les simulations";
            this.AfficheSimu.Click += new System.EventHandler(this.AfficheSimu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Client :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Finition Intérieur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Finition Extérieur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Couleur";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(593, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Motorisation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VoitureOnLine.Properties.Resources.banner1;
            this.pictureBox1.Location = new System.Drawing.Point(187, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 265);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 433);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBSelection);
            this.Controls.Add(this.CBMotorisation);
            this.Controls.Add(this.CBCouleur);
            this.Controls.Add(this.CBFinitionExter);
            this.Controls.Add(this.CBFinitionInter);
            this.Controls.Add(this.TBClient);
            this.Controls.Add(this.BTQuitter);
            this.Controls.Add(this.BTAnnuler);
            this.Controls.Add(this.BTValider);
            this.Controls.Add(this.checkBCabriolet);
            this.Controls.Add(this.checkB4portes);
            this.Controls.Add(this.GBType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Choisissez votre voiture";
            this.GBType.ResumeLayout(false);
            this.GBType.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBType;
        private System.Windows.Forms.RadioButton RBLimousine;
        private System.Windows.Forms.RadioButton RBFamiliale;
        private System.Windows.Forms.RadioButton RBCompacte;
        private System.Windows.Forms.RadioButton RBCitadine;
        private System.Windows.Forms.CheckBox checkB4portes;
        private System.Windows.Forms.CheckBox checkBCabriolet;
        private System.Windows.Forms.Button BTValider;
        private System.Windows.Forms.Button BTAnnuler;
        private System.Windows.Forms.Button BTQuitter;
        private System.Windows.Forms.TextBox TBClient;
        private System.Windows.Forms.ComboBox CBFinitionExter;
        private System.Windows.Forms.ComboBox CBCouleur;
        private System.Windows.Forms.ComboBox CBMotorisation;
        private System.Windows.Forms.Label LBSelection;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMAfficher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem AfficheSimu;
        private System.Windows.Forms.ComboBox CBFinitionInter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

