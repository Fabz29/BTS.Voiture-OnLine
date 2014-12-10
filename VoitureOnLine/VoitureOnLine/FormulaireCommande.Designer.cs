namespace VoitureOnLine
{
    partial class FormulaireCommande
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
            this.rbLimousine = new System.Windows.Forms.RadioButton();
            this.rbFamiliale = new System.Windows.Forms.RadioButton();
            this.rbCompacte = new System.Windows.Forms.RadioButton();
            this.rbCitadine = new System.Windows.Forms.RadioButton();
            this.checkB4portes = new System.Windows.Forms.CheckBox();
            this.checkBCabriolet = new System.Windows.Forms.CheckBox();
            this.BTValider = new System.Windows.Forms.Button();
            this.BTAnnuler = new System.Windows.Forms.Button();
            this.BTQuitter = new System.Windows.Forms.Button();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.cbFinitionInter = new System.Windows.Forms.ComboBox();
            this.cbFinitionExter = new System.Windows.Forms.ComboBox();
            this.cbCouleur = new System.Windows.Forms.ComboBox();
            this.cbMotorisation = new System.Windows.Forms.ComboBox();
            this.lbSelection = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMAfficher = new System.Windows.Forms.ToolStripMenuItem();
            this.AfficheSimu = new System.Windows.Forms.ToolStripMenuItem();
            this.lbClient = new System.Windows.Forms.Label();
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
            this.GBType.Controls.Add(this.rbLimousine);
            this.GBType.Controls.Add(this.rbFamiliale);
            this.GBType.Controls.Add(this.rbCompacte);
            this.GBType.Controls.Add(this.rbCitadine);
            this.GBType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBType.Location = new System.Drawing.Point(33, 80);
            this.GBType.Name = "GBType";
            this.GBType.Size = new System.Drawing.Size(123, 146);
            this.GBType.TabIndex = 3;
            this.GBType.TabStop = false;
            this.GBType.Text = "Type";
            // 
            // rbLimousine
            // 
            this.rbLimousine.AutoSize = true;
            this.rbLimousine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLimousine.Location = new System.Drawing.Point(19, 107);
            this.rbLimousine.Name = "rbLimousine";
            this.rbLimousine.Size = new System.Drawing.Size(81, 17);
            this.rbLimousine.TabIndex = 3;
            this.rbLimousine.TabStop = true;
            this.rbLimousine.Text = "Limousine";
            this.rbLimousine.UseVisualStyleBackColor = true;
            this.rbLimousine.CheckedChanged += new System.EventHandler(this.RBLimousine_CheckedChanged);
            // 
            // rbFamiliale
            // 
            this.rbFamiliale.AutoSize = true;
            this.rbFamiliale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFamiliale.Location = new System.Drawing.Point(19, 84);
            this.rbFamiliale.Name = "rbFamiliale";
            this.rbFamiliale.Size = new System.Drawing.Size(74, 17);
            this.rbFamiliale.TabIndex = 2;
            this.rbFamiliale.TabStop = true;
            this.rbFamiliale.Text = "Familiale";
            this.rbFamiliale.UseVisualStyleBackColor = true;
            this.rbFamiliale.CheckedChanged += new System.EventHandler(this.RBFamiliale_CheckedChanged);
            // 
            // rbCompacte
            // 
            this.rbCompacte.AutoSize = true;
            this.rbCompacte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCompacte.Location = new System.Drawing.Point(19, 59);
            this.rbCompacte.Name = "rbCompacte";
            this.rbCompacte.Size = new System.Drawing.Size(81, 17);
            this.rbCompacte.TabIndex = 1;
            this.rbCompacte.TabStop = true;
            this.rbCompacte.Text = "Compacte";
            this.rbCompacte.UseVisualStyleBackColor = true;
            this.rbCompacte.CheckedChanged += new System.EventHandler(this.RBCompacte_CheckedChanged);
            // 
            // rbCitadine
            // 
            this.rbCitadine.AutoSize = true;
            this.rbCitadine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCitadine.Location = new System.Drawing.Point(19, 35);
            this.rbCitadine.Name = "rbCitadine";
            this.rbCitadine.Size = new System.Drawing.Size(71, 17);
            this.rbCitadine.TabIndex = 0;
            this.rbCitadine.TabStop = true;
            this.rbCitadine.Text = "Citadine";
            this.rbCitadine.UseVisualStyleBackColor = true;
            this.rbCitadine.CheckedChanged += new System.EventHandler(this.RBCitadine_CheckedChanged);
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
            // tbClient
            // 
            this.tbClient.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbClient.Location = new System.Drawing.Point(593, 41);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(116, 20);
            this.tbClient.TabIndex = 9;
            this.tbClient.TabStop = false;
            // 
            // cbFinitionInter
            // 
            this.cbFinitionInter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFinitionInter.FormattingEnabled = true;
            this.cbFinitionInter.Items.AddRange(new object[] {
            "Young",
            "Luxe",
            "Sport"});
            this.cbFinitionInter.Location = new System.Drawing.Point(593, 108);
            this.cbFinitionInter.Name = "cbFinitionInter";
            this.cbFinitionInter.Size = new System.Drawing.Size(140, 21);
            this.cbFinitionInter.TabIndex = 7;
            // 
            // cbFinitionExter
            // 
            this.cbFinitionExter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFinitionExter.FormattingEnabled = true;
            this.cbFinitionExter.Items.AddRange(new object[] {
            "Urban",
            "Pack",
            "Ambition"});
            this.cbFinitionExter.Location = new System.Drawing.Point(593, 159);
            this.cbFinitionExter.Name = "cbFinitionExter";
            this.cbFinitionExter.Size = new System.Drawing.Size(140, 21);
            this.cbFinitionExter.TabIndex = 8;
            // 
            // cbCouleur
            // 
            this.cbCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCouleur.FormattingEnabled = true;
            this.cbCouleur.Items.AddRange(new object[] {
            "Métallisé",
            "Vernie",
            "Brillante",
            "Mate"});
            this.cbCouleur.Location = new System.Drawing.Point(593, 203);
            this.cbCouleur.Name = "cbCouleur";
            this.cbCouleur.Size = new System.Drawing.Size(140, 21);
            this.cbCouleur.TabIndex = 9;
            // 
            // cbMotorisation
            // 
            this.cbMotorisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMotorisation.FormattingEnabled = true;
            this.cbMotorisation.Items.AddRange(new object[] {
            "Essence",
            "Gasoil",
            "Hybride"});
            this.cbMotorisation.Location = new System.Drawing.Point(593, 250);
            this.cbMotorisation.Name = "cbMotorisation";
            this.cbMotorisation.Size = new System.Drawing.Size(140, 21);
            this.cbMotorisation.TabIndex = 10;
            // 
            // lbSelection
            // 
            this.lbSelection.AutoSize = true;
            this.lbSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelection.ForeColor = System.Drawing.Color.Green;
            this.lbSelection.Location = new System.Drawing.Point(184, 340);
            this.lbSelection.Name = "lbSelection";
            this.lbSelection.Size = new System.Drawing.Size(47, 15);
            this.lbSelection.TabIndex = 14;
            this.lbSelection.Text = "label2";
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
            // lbClient
            // 
            this.lbClient.AutoSize = true;
            this.lbClient.Location = new System.Drawing.Point(540, 44);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(47, 13);
            this.lbClient.TabIndex = 16;
            this.lbClient.Text = "Client :";
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
            // FormulaireCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 433);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbClient);
            this.Controls.Add(this.lbSelection);
            this.Controls.Add(this.cbMotorisation);
            this.Controls.Add(this.cbCouleur);
            this.Controls.Add(this.cbFinitionExter);
            this.Controls.Add(this.cbFinitionInter);
            this.Controls.Add(this.tbClient);
            this.Controls.Add(this.BTQuitter);
            this.Controls.Add(this.BTAnnuler);
            this.Controls.Add(this.BTValider);
            this.Controls.Add(this.checkBCabriolet);
            this.Controls.Add(this.checkB4portes);
            this.Controls.Add(this.GBType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormulaireCommande";
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
        private System.Windows.Forms.RadioButton rbLimousine;
        private System.Windows.Forms.RadioButton rbFamiliale;
        private System.Windows.Forms.RadioButton rbCompacte;
        private System.Windows.Forms.RadioButton rbCitadine;
        private System.Windows.Forms.CheckBox checkB4portes;
        private System.Windows.Forms.CheckBox checkBCabriolet;
        private System.Windows.Forms.Button BTValider;
        private System.Windows.Forms.Button BTAnnuler;
        private System.Windows.Forms.Button BTQuitter;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.ComboBox cbFinitionExter;
        private System.Windows.Forms.ComboBox cbCouleur;
        private System.Windows.Forms.ComboBox cbMotorisation;
        private System.Windows.Forms.Label lbSelection;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMAfficher;
        private System.Windows.Forms.Label lbClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem AfficheSimu;
        private System.Windows.Forms.ComboBox cbFinitionInter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

