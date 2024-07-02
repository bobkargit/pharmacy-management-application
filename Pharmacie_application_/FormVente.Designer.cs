namespace Pharmacie_application_
{
    partial class FormVente
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuantite = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonOK = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter la quantite de pieces a vendre:";
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxQuantite.DefaultText = "";
            this.textBoxQuantite.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxQuantite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxQuantite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxQuantite.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxQuantite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxQuantite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxQuantite.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxQuantite.Location = new System.Drawing.Point(110, 106);
            this.textBoxQuantite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.PasswordChar = '\0';
            this.textBoxQuantite.PlaceholderText = "";
            this.textBoxQuantite.SelectedText = "";
            this.textBoxQuantite.Size = new System.Drawing.Size(306, 35);
            this.textBoxQuantite.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.BorderRadius = 10;
            this.buttonOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonOK.FillColor = System.Drawing.Color.Gold;
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonOK.ForeColor = System.Drawing.Color.Black;
            this.buttonOK.Location = new System.Drawing.Point(314, 171);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(102, 36);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "Vendre";
            // 
            // FormVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 296);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxQuantite);
            this.Controls.Add(this.label1);
            this.Name = "FormVente";
            this.Text = "FormVente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox textBoxQuantite;
        private Guna.UI2.WinForms.Guna2Button buttonOK;
    }
}