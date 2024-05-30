namespace Fournisseurs_Reconnect.PieceDetachee
{
    partial class ModifierTypePieceDetachee
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boutonModifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boutonRetour
            // 
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Location = new System.Drawing.Point(12, 223);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(75, 23);
            this.boutonRetour.TabIndex = 4;
            this.boutonRetour.Text = "< Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(318, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Saisissez un nouveau nom de type de pièce détachée";
            // 
            // boutonModifier
            // 
            this.boutonModifier.Location = new System.Drawing.Point(295, 174);
            this.boutonModifier.Name = "boutonModifier";
            this.boutonModifier.Size = new System.Drawing.Size(75, 23);
            this.boutonModifier.TabIndex = 7;
            this.boutonModifier.Text = "Modifier";
            this.boutonModifier.UseVisualStyleBackColor = true;
            this.boutonModifier.Click += new System.EventHandler(this.boutonModifier_Click);
            // 
            // ModifierTypePieceDetachee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(613, 258);
            this.ControlBox = false;
            this.Controls.Add(this.boutonModifier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.boutonRetour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifierTypePieceDetachee";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifierTypePieceDetachee";
            this.Load += new System.EventHandler(this.ModifierTypePieceDetachee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boutonModifier;
    }
}