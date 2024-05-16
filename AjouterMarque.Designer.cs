namespace Fournisseurs_Reconnect
{
    partial class AjouterMarque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterMarque));
            this.textBoxNomMarque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boutonEnregistrer = new System.Windows.Forms.Button();
            this.boutonSupprimerMarque = new System.Windows.Forms.Button();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNomMarque
            // 
            this.textBoxNomMarque.Location = new System.Drawing.Point(191, 58);
            this.textBoxNomMarque.MaxLength = 150;
            this.textBoxNomMarque.Name = "textBoxNomMarque";
            this.textBoxNomMarque.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxNomMarque.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxNomMarque.Size = new System.Drawing.Size(312, 20);
            this.textBoxNomMarque.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Saisissez un nom de marque : \r\n";
            // 
            // boutonEnregistrer
            // 
            this.boutonEnregistrer.Location = new System.Drawing.Point(318, 121);
            this.boutonEnregistrer.Name = "boutonEnregistrer";
            this.boutonEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.boutonEnregistrer.TabIndex = 1;
            this.boutonEnregistrer.Text = "Enregistrer";
            this.boutonEnregistrer.UseVisualStyleBackColor = true;
            this.boutonEnregistrer.Click += new System.EventHandler(this.button1_Click);
            // 
            // boutonSupprimerMarque
            // 
            this.boutonSupprimerMarque.Location = new System.Drawing.Point(408, 215);
            this.boutonSupprimerMarque.Name = "boutonSupprimerMarque";
            this.boutonSupprimerMarque.Size = new System.Drawing.Size(138, 45);
            this.boutonSupprimerMarque.TabIndex = 3;
            this.boutonSupprimerMarque.Text = "Modifier/Supprimer une marque ?";
            this.boutonSupprimerMarque.UseVisualStyleBackColor = true;
            this.boutonSupprimerMarque.Click += new System.EventHandler(this.button2_Click);
            // 
            // boutonRetour
            // 
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Location = new System.Drawing.Point(12, 237);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(112, 23);
            this.boutonRetour.TabIndex = 14;
            this.boutonRetour.Text = "< Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // AjouterMarque
            // 
            this.AcceptButton = this.boutonEnregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(582, 272);
            this.ControlBox = false;
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.boutonSupprimerMarque);
            this.Controls.Add(this.boutonEnregistrer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomMarque);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AjouterMarque";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterMarque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomMarque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boutonEnregistrer;
        private System.Windows.Forms.Button boutonSupprimerMarque;
        private System.Windows.Forms.Button boutonRetour;
    }
}