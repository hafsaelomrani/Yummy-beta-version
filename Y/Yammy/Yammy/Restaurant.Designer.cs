﻿namespace Yammy
{
    partial class Restaurant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restaurant));
            this.dataGridViewRestaurant = new System.Windows.Forms.DataGridView();
            this.Dérniere = new System.Windows.Forms.Button();
            this.Suivant = new System.Windows.Forms.Button();
            this.Précedent = new System.Windows.Forms.Button();
            this.Premier = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Rechercher = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.textBoxaddersse = new System.Windows.Forms.TextBox();
            this.textBoxtel = new System.Windows.Forms.TextBox();
            this.textBoxnom = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurant)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRestaurant
            // 
            this.dataGridViewRestaurant.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataGridViewRestaurant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRestaurant.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dataGridViewRestaurant.Location = new System.Drawing.Point(29, 257);
            this.dataGridViewRestaurant.Name = "dataGridViewRestaurant";
            this.dataGridViewRestaurant.Size = new System.Drawing.Size(607, 150);
            this.dataGridViewRestaurant.TabIndex = 45;
            // 
            // Dérniere
            // 
            this.Dérniere.BackColor = System.Drawing.Color.Khaki;
            this.Dérniere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dérniere.Location = new System.Drawing.Point(548, 228);
            this.Dérniere.Name = "Dérniere";
            this.Dérniere.Size = new System.Drawing.Size(75, 23);
            this.Dérniere.TabIndex = 44;
            this.Dérniere.Text = "Dérniere";
            this.Dérniere.UseVisualStyleBackColor = false;
            this.Dérniere.Click += new System.EventHandler(this.Dérniere_Click);
            // 
            // Suivant
            // 
            this.Suivant.BackColor = System.Drawing.Color.Khaki;
            this.Suivant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Suivant.Location = new System.Drawing.Point(420, 228);
            this.Suivant.Name = "Suivant";
            this.Suivant.Size = new System.Drawing.Size(75, 23);
            this.Suivant.TabIndex = 43;
            this.Suivant.Text = "Suivant";
            this.Suivant.UseVisualStyleBackColor = false;
            this.Suivant.Click += new System.EventHandler(this.Suivant_Click);
            // 
            // Précedent
            // 
            this.Précedent.BackColor = System.Drawing.Color.Khaki;
            this.Précedent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Précedent.Location = new System.Drawing.Point(177, 228);
            this.Précedent.Name = "Précedent";
            this.Précedent.Size = new System.Drawing.Size(75, 23);
            this.Précedent.TabIndex = 42;
            this.Précedent.Text = "Précedent";
            this.Précedent.UseVisualStyleBackColor = false;
            this.Précedent.Click += new System.EventHandler(this.Précedent_Click);
            // 
            // Premier
            // 
            this.Premier.BackColor = System.Drawing.Color.Khaki;
            this.Premier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Premier.Location = new System.Drawing.Point(45, 230);
            this.Premier.Name = "Premier";
            this.Premier.Size = new System.Drawing.Size(75, 23);
            this.Premier.TabIndex = 41;
            this.Premier.Text = "Premier";
            this.Premier.UseVisualStyleBackColor = false;
            this.Premier.Click += new System.EventHandler(this.Premier_Click);
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.Khaki;
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifier.Location = new System.Drawing.Point(374, 165);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 23);
            this.Modifier.TabIndex = 40;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Rechercher
            // 
            this.Rechercher.BackColor = System.Drawing.Color.Khaki;
            this.Rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Rechercher.Location = new System.Drawing.Point(548, 165);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(75, 23);
            this.Rechercher.TabIndex = 39;
            this.Rechercher.Text = "Rechercher";
            this.Rechercher.UseVisualStyleBackColor = false;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.BackColor = System.Drawing.Color.Khaki;
            this.Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Supprimer.Location = new System.Drawing.Point(201, 165);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Supprimer.TabIndex = 38;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.Khaki;
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ajouter.Location = new System.Drawing.Point(44, 165);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 37;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // textBoxaddersse
            // 
            this.textBoxaddersse.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxaddersse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxaddersse.Location = new System.Drawing.Point(435, 70);
            this.textBoxaddersse.Name = "textBoxaddersse";
            this.textBoxaddersse.Size = new System.Drawing.Size(158, 24);
            this.textBoxaddersse.TabIndex = 36;
            this.textBoxaddersse.TextChanged += new System.EventHandler(this.textBoxaddersse_TextChanged);
            // 
            // textBoxtel
            // 
            this.textBoxtel.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtel.Location = new System.Drawing.Point(435, 35);
            this.textBoxtel.Name = "textBoxtel";
            this.textBoxtel.Size = new System.Drawing.Size(158, 24);
            this.textBoxtel.TabIndex = 34;
            this.textBoxtel.TextChanged += new System.EventHandler(this.textBoxtel_TextChanged);
            // 
            // textBoxnom
            // 
            this.textBoxnom.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnom.Location = new System.Drawing.Point(94, 70);
            this.textBoxnom.Name = "textBoxnom";
            this.textBoxnom.Size = new System.Drawing.Size(158, 24);
            this.textBoxnom.TabIndex = 32;
            this.textBoxnom.TextChanged += new System.EventHandler(this.textBoxnom_TextChanged);
            // 
            // textBoxN
            // 
            this.textBoxN.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxN.Location = new System.Drawing.Point(94, 38);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(158, 24);
            this.textBoxN.TabIndex = 31;
            this.textBoxN.TextChanged += new System.EventHandler(this.textBoxN_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(13, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(327, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(327, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Addresse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "N°";
            // 
            // Retour
            // 
            this.Retour.BackColor = System.Drawing.Color.Khaki;
            this.Retour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Retour.BackgroundImage")));
            this.Retour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Retour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Retour.Location = new System.Drawing.Point(597, 408);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(39, 27);
            this.Retour.TabIndex = 46;
            this.Retour.UseVisualStyleBackColor = false;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // Restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(664, 442);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.dataGridViewRestaurant);
            this.Controls.Add(this.Dérniere);
            this.Controls.Add(this.Suivant);
            this.Controls.Add(this.Précedent);
            this.Controls.Add(this.Premier);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.textBoxaddersse);
            this.Controls.Add(this.textBoxtel);
            this.Controls.Add(this.textBoxnom);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Restaurant";
            this.Text = "Restaurant";
            this.Load += new System.EventHandler(this.Restaurant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRestaurant;
        private System.Windows.Forms.Button Dérniere;
        private System.Windows.Forms.Button Suivant;
        private System.Windows.Forms.Button Précedent;
        private System.Windows.Forms.Button Premier;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.TextBox textBoxaddersse;
        private System.Windows.Forms.TextBox textBoxtel;
        private System.Windows.Forms.TextBox textBoxnom;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Retour;
    }
}