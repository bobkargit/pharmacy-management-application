namespace Pharmacie_application_
{
    partial class Form11
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Add_butt = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Qnt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un nouveau commande:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom de fournisseur:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de livraison:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de commande:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Choisir le medicament:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantite:";
            // 
            // Add_butt
            // 
            this.Add_butt.BorderRadius = 10;
            this.Add_butt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add_butt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add_butt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add_butt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add_butt.FillColor = System.Drawing.Color.Gold;
            this.Add_butt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Add_butt.ForeColor = System.Drawing.Color.Black;
            this.Add_butt.Location = new System.Drawing.Point(904, 562);
            this.Add_butt.Name = "Add_butt";
            this.Add_butt.Size = new System.Drawing.Size(133, 45);
            this.Add_butt.TabIndex = 6;
            this.Add_butt.Text = "Ajouter";
            this.Add_butt.Click += new System.EventHandler(this.Add_butt_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox1.ItemHeight = 30;
            this.ComboBox1.Location = new System.Drawing.Point(224, 88);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(331, 36);
            this.ComboBox1.TabIndex = 7;
            // 
            // ComboBox2
            // 
            this.ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox2.ItemHeight = 30;
            this.ComboBox2.Location = new System.Drawing.Point(224, 161);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(331, 36);
            this.ComboBox2.TabIndex = 8;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Checked = true;
            this.DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker1.Location = new System.Drawing.Point(224, 245);
            this.DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(331, 36);
            this.DateTimePicker1.TabIndex = 9;
            this.DateTimePicker1.Value = new System.DateTime(2024, 5, 2, 15, 16, 10, 972);
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Checked = true;
            this.DateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker2.Location = new System.Drawing.Point(224, 340);
            this.DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(331, 36);
            this.DateTimePicker2.TabIndex = 10;
            this.DateTimePicker2.Value = new System.DateTime(2024, 5, 2, 15, 16, 10, 972);
            // 
            // Qnt
            // 
            this.Qnt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Qnt.DefaultText = "";
            this.Qnt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Qnt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Qnt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Qnt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Qnt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Qnt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Qnt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Qnt.Location = new System.Drawing.Point(224, 423);
            this.Qnt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Qnt.Name = "Qnt";
            this.Qnt.PasswordChar = '\0';
            this.Qnt.PlaceholderText = "";
            this.Qnt.SelectedText = "";
            this.Qnt.Size = new System.Drawing.Size(331, 39);
            this.Qnt.TabIndex = 11;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 636);
            this.Controls.Add(this.Qnt);
            this.Controls.Add(this.DateTimePicker2);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.ComboBox2);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Add_butt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button Add_butt;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker2;
        private Guna.UI2.WinForms.Guna2TextBox Qnt;
    }
}