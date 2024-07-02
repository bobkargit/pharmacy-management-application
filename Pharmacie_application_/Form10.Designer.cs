namespace Pharmacie_application_
{
    partial class Form10
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Add_button = new Guna.UI2.WinForms.Guna2Button();
            this.cours_button = new Guna.UI2.WinForms.Guna2Button();
            this.terminne_butt = new Guna.UI2.WinForms.Guna2Button();
            this.Livree_butt = new Guna.UI2.WinForms.Guna2Button();
            this.Delete = new Guna.UI2.WinForms.Guna2Button();
            this.Modifier = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "La liste de commandes:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 30;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.Location = new System.Drawing.Point(39, 125);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1376, 462);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridView.ThemeStyle.ReadOnly = false;
            this.dataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Add_button
            // 
            this.Add_button.BorderRadius = 10;
            this.Add_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add_button.FillColor = System.Drawing.Color.Gold;
            this.Add_button.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Add_button.ForeColor = System.Drawing.Color.Black;
            this.Add_button.Location = new System.Drawing.Point(1319, 75);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(96, 35);
            this.Add_button.TabIndex = 2;
            this.Add_button.Text = "Ajouter";
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // cours_button
            // 
            this.cours_button.BorderRadius = 10;
            this.cours_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cours_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cours_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cours_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cours_button.FillColor = System.Drawing.Color.Gold;
            this.cours_button.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.cours_button.ForeColor = System.Drawing.Color.Black;
            this.cours_button.Location = new System.Drawing.Point(39, 65);
            this.cours_button.Name = "cours_button";
            this.cours_button.Size = new System.Drawing.Size(108, 45);
            this.cours_button.TabIndex = 3;
            this.cours_button.Text = "en cours";
            this.cours_button.Click += new System.EventHandler(this.cours_button_Click);
            // 
            // terminne_butt
            // 
            this.terminne_butt.BorderRadius = 10;
            this.terminne_butt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.terminne_butt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.terminne_butt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.terminne_butt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.terminne_butt.FillColor = System.Drawing.Color.Gold;
            this.terminne_butt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.terminne_butt.ForeColor = System.Drawing.Color.Black;
            this.terminne_butt.Location = new System.Drawing.Point(164, 65);
            this.terminne_butt.Name = "terminne_butt";
            this.terminne_butt.Size = new System.Drawing.Size(110, 45);
            this.terminne_butt.TabIndex = 4;
            this.terminne_butt.Text = "terminée";
            this.terminne_butt.Click += new System.EventHandler(this.terminne_butt_Click);
            // 
            // Livree_butt
            // 
            this.Livree_butt.BorderRadius = 10;
            this.Livree_butt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Livree_butt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Livree_butt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Livree_butt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Livree_butt.FillColor = System.Drawing.Color.Gold;
            this.Livree_butt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Livree_butt.ForeColor = System.Drawing.Color.Black;
            this.Livree_butt.Location = new System.Drawing.Point(1333, 612);
            this.Livree_butt.Name = "Livree_butt";
            this.Livree_butt.Size = new System.Drawing.Size(92, 36);
            this.Livree_butt.TabIndex = 5;
            this.Livree_butt.Text = "Livrée";
            this.Livree_butt.Click += new System.EventHandler(this.Livree_butt_Click);
            // 
            // Delete
            // 
            this.Delete.BorderRadius = 10;
            this.Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete.FillColor = System.Drawing.Color.Gold;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Location = new System.Drawing.Point(1210, 75);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(92, 36);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Modifier
            // 
            this.Modifier.BorderRadius = 10;
            this.Modifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Modifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Modifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Modifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Modifier.FillColor = System.Drawing.Color.Gold;
            this.Modifier.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Modifier.ForeColor = System.Drawing.Color.Black;
            this.Modifier.Location = new System.Drawing.Point(1088, 74);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(106, 36);
            this.Modifier.TabIndex = 7;
            this.Modifier.Text = "Modifier";
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1450, 694);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Livree_butt);
            this.Controls.Add(this.terminne_butt);
            this.Controls.Add(this.cours_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "Form10";
            this.Text = "Form10";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView;
        private Guna.UI2.WinForms.Guna2Button Add_button;
        private Guna.UI2.WinForms.Guna2Button cours_button;
        private Guna.UI2.WinForms.Guna2Button terminne_butt;
        private Guna.UI2.WinForms.Guna2Button Livree_butt;
        private Guna.UI2.WinForms.Guna2Button Delete;
        private Guna.UI2.WinForms.Guna2Button Modifier;
    }
}