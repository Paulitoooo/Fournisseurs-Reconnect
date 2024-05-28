namespace Fournisseurs_Reconnect
{
    partial class ModifierSupprimerPieceDetachee
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
            this.listeAppareil = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listeType = new System.Windows.Forms.ListBox();
            this.listePieces = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boutonRetour
            // 
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Location = new System.Drawing.Point(12, 401);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(103, 37);
            this.boutonRetour.TabIndex = 1;
            this.boutonRetour.Text = "<Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // listeAppareil
            // 
            this.listeAppareil.FormattingEnabled = true;
            this.listeAppareil.Location = new System.Drawing.Point(414, 85);
            this.listeAppareil.Name = "listeAppareil";
            this.listeAppareil.Size = new System.Drawing.Size(120, 69);
            this.listeAppareil.TabIndex = 2;
            this.listeAppareil.Click += new System.EventHandler(this.listeAppareil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selectionnez un appareil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selectionnez un type de piece détachée";
            // 
            // listeType
            // 
            this.listeType.Enabled = false;
            this.listeType.FormattingEnabled = true;
            this.listeType.Location = new System.Drawing.Point(414, 186);
            this.listeType.Name = "listeType";
            this.listeType.Size = new System.Drawing.Size(120, 43);
            this.listeType.TabIndex = 5;
            this.listeType.Click += new System.EventHandler(this.listeType_Click);
            // 
            // listePieces
            // 
            this.listePieces.Enabled = false;
            this.listePieces.FormattingEnabled = true;
            this.listePieces.Location = new System.Drawing.Point(414, 265);
            this.listePieces.Name = "listePieces";
            this.listePieces.Size = new System.Drawing.Size(120, 56);
            this.listePieces.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selectionnez une piece détachée\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ModifierSupprimerPieceDetachee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listePieces);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listeType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeAppareil);
            this.Controls.Add(this.boutonRetour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifierSupprimerPieceDetachee";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier ou supprimer une piece détachée";
            this.Load += new System.EventHandler(this.ModifierSupprimerPieceDetachee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.ListBox listeAppareil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listeType;
        private System.Windows.Forms.ListBox listePieces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}