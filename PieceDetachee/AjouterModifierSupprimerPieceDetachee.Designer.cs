namespace Fournisseurs_Reconnect
{
    partial class AjouterModifierSupprimerPieceDetachee
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
            this.boutonRetour = new System.Windows.Forms.Button();
            this.textBoxNomPiece = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listeType = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listeAppareil = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boutonAjouter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boutonRetour
            // 
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Location = new System.Drawing.Point(12, 401);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(103, 37);
            this.boutonRetour.TabIndex = 0;
            this.boutonRetour.Text = "<Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // textBoxNomPiece
            // 
            this.textBoxNomPiece.Location = new System.Drawing.Point(221, 102);
            this.textBoxNomPiece.Name = "textBoxNomPiece";
            this.textBoxNomPiece.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomPiece.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saisissez un nom de piece détachée";
            // 
            // listeType
            // 
            this.listeType.FormattingEnabled = true;
            this.listeType.Location = new System.Drawing.Point(221, 163);
            this.listeType.Name = "listeType";
            this.listeType.Size = new System.Drawing.Size(120, 43);
            this.listeType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selectionnez un type de piece détachée";
            // 
            // listeAppareil
            // 
            this.listeAppareil.FormattingEnabled = true;
            this.listeAppareil.Location = new System.Drawing.Point(221, 231);
            this.listeAppareil.Name = "listeAppareil";
            this.listeAppareil.Size = new System.Drawing.Size(120, 82);
            this.listeAppareil.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selectionnez un appareil";
            // 
            // boutonAjouter
            // 
            this.boutonAjouter.Location = new System.Drawing.Point(402, 408);
            this.boutonAjouter.Name = "boutonAjouter";
            this.boutonAjouter.Size = new System.Drawing.Size(75, 23);
            this.boutonAjouter.TabIndex = 7;
            this.boutonAjouter.Text = "Ajouter";
            this.boutonAjouter.UseVisualStyleBackColor = true;
            this.boutonAjouter.Click += new System.EventHandler(this.boutonAjouter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Modifier/Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AjouterModifierSupprimerPieceDetachee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boutonAjouter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listeAppareil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listeType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomPiece);
            this.Controls.Add(this.boutonRetour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AjouterModifierSupprimerPieceDetachee";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter/Modifier/Supprimer une pièce détachée";
            this.Load += new System.EventHandler(this.AjouterModifierSupprimerPieceDetachee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.TextBox textBoxNomPiece;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listeType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listeAppareil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button boutonAjouter;
        private System.Windows.Forms.Button button1;
    }
}