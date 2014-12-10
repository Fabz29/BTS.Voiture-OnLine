namespace VoitureOnLine
{
    partial class listeCommandes
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
            this.lbCommandes = new System.Windows.Forms.ListBox();
            this.lbNbCommande = new System.Windows.Forms.Label();
            this.lbTotalCommandes = new System.Windows.Forms.Label();
            this.btFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCommandes
            // 
            this.lbCommandes.FormattingEnabled = true;
            this.lbCommandes.Location = new System.Drawing.Point(13, 13);
            this.lbCommandes.Name = "lbCommandes";
            this.lbCommandes.Size = new System.Drawing.Size(881, 225);
            this.lbCommandes.TabIndex = 0;
            // 
            // lbNbCommande
            // 
            this.lbNbCommande.AutoSize = true;
            this.lbNbCommande.Location = new System.Drawing.Point(133, 277);
            this.lbNbCommande.Name = "lbNbCommande";
            this.lbNbCommande.Size = new System.Drawing.Size(82, 13);
            this.lbNbCommande.TabIndex = 1;
            this.lbNbCommande.Text = "lbNbCommande";
            // 
            // lbTotalCommandes
            // 
            this.lbTotalCommandes.AutoSize = true;
            this.lbTotalCommandes.Location = new System.Drawing.Point(760, 277);
            this.lbTotalCommandes.Name = "lbTotalCommandes";
            this.lbTotalCommandes.Size = new System.Drawing.Size(92, 13);
            this.lbTotalCommandes.TabIndex = 2;
            this.lbTotalCommandes.Text = "lbTotalCommande";
            // 
            // btFermer
            // 
            this.btFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFermer.Location = new System.Drawing.Point(419, 333);
            this.btFermer.Name = "btFermer";
            this.btFermer.Size = new System.Drawing.Size(75, 23);
            this.btFermer.TabIndex = 3;
            this.btFermer.Text = "&Fermer";
            this.btFermer.UseVisualStyleBackColor = true;
            this.btFermer.Click += new System.EventHandler(this.btFermer_Click);
            // 
            // listeCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 368);
            this.Controls.Add(this.btFermer);
            this.Controls.Add(this.lbTotalCommandes);
            this.Controls.Add(this.lbNbCommande);
            this.Controls.Add(this.lbCommandes);
            this.Name = "listeCommandes";
            this.Text = "listeCommandes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCommandes;
        private System.Windows.Forms.Label lbNbCommande;
        private System.Windows.Forms.Label lbTotalCommandes;
        private System.Windows.Forms.Button btFermer;
    }
}