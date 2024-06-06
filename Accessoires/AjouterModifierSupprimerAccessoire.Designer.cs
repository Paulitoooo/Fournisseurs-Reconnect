namespace Fournisseurs_Reconnect.Accessoires
{
    partial class AjouterModifierSupprimerAccessoire
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
            this.listeMarque = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listeType = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomAccessoire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.boutonSupprimerMarque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listeMarque
            // 
            this.listeMarque.FormattingEnabled = true;
            this.listeMarque.Location = new System.Drawing.Point(272, 40);
            this.listeMarque.Name = "listeMarque";
            this.listeMarque.Size = new System.Drawing.Size(117, 56);
            this.listeMarque.Sorted = true;
            this.listeMarque.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selectionnez une marque";
            // 
            // listeType
            // 
            this.listeType.FormattingEnabled = true;
            this.listeType.Location = new System.Drawing.Point(272, 122);
            this.listeType.Name = "listeType";
            this.listeType.Size = new System.Drawing.Size(117, 56);
            this.listeType.Sorted = true;
            this.listeType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selectionnez un type";
            // 
            // textBoxNomAccessoire
            // 
            this.textBoxNomAccessoire.Location = new System.Drawing.Point(272, 204);
            this.textBoxNomAccessoire.Name = "textBoxNomAccessoire";
            this.textBoxNomAccessoire.Size = new System.Drawing.Size(117, 20);
            this.textBoxNomAccessoire.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saisissez un nom d\'accessoire";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "< Retour";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boutonSupprimerMarque
            // 
            this.boutonSupprimerMarque.Location = new System.Drawing.Point(465, 287);
            this.boutonSupprimerMarque.Name = "boutonSupprimerMarque";
            this.boutonSupprimerMarque.Size = new System.Drawing.Size(138, 45);
            this.boutonSupprimerMarque.TabIndex = 54;
            this.boutonSupprimerMarque.Text = "Modifier/Supprimer un accesoire ?";
            this.boutonSupprimerMarque.UseVisualStyleBackColor = true;
            this.boutonSupprimerMarque.Click += new System.EventHandler(this.boutonSupprimerMarque_Click);
            // 
            // AjouterModifierSupprimerAccessoire
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(615, 344);
            this.ControlBox = false;
            this.Controls.Add(this.boutonSupprimerMarque);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNomAccessoire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listeType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeMarque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AjouterModifierSupprimerAccessoire";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter/Modifier/Supprimer un accessoire";
            this.Load += new System.EventHandler(this.AjouterModifierSupprimerAccessoire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listeMarque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listeType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomAccessoire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button boutonSupprimerMarque;
    }
}