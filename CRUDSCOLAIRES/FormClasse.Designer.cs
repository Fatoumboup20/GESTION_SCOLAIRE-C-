namespace CRUDSCOLAIRES
{
    partial class FormClasse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btneffacer = new System.Windows.Forms.Button();
            this.btnsupp = new System.Windows.Forms.Button();
            this.btnmodif = new System.Windows.Forms.Button();
            this.combospecialite = new System.Windows.Forms.ComboBox();
            this.comboniveau = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnclasse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataclasse = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataclasse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataclasse);
            this.panel1.Controls.Add(this.btneffacer);
            this.panel1.Controls.Add(this.btnsupp);
            this.panel1.Controls.Add(this.btnmodif);
            this.panel1.Controls.Add(this.combospecialite);
            this.panel1.Controls.Add(this.comboniveau);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnclasse);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 383);
            this.panel1.TabIndex = 0;
            // 
            // btneffacer
            // 
            this.btneffacer.BackColor = System.Drawing.Color.Gray;
            this.btneffacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneffacer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btneffacer.Location = new System.Drawing.Point(208, 283);
            this.btneffacer.Name = "btneffacer";
            this.btneffacer.Size = new System.Drawing.Size(130, 33);
            this.btneffacer.TabIndex = 44;
            this.btneffacer.Text = "Effacer";
            this.btneffacer.UseVisualStyleBackColor = false;
            this.btneffacer.Click += new System.EventHandler(this.btneffacer_Click);
            // 
            // btnsupp
            // 
            this.btnsupp.BackColor = System.Drawing.Color.Gray;
            this.btnsupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsupp.Location = new System.Drawing.Point(7, 283);
            this.btnsupp.Name = "btnsupp";
            this.btnsupp.Size = new System.Drawing.Size(130, 28);
            this.btnsupp.TabIndex = 43;
            this.btnsupp.Text = "supprimer";
            this.btnsupp.UseVisualStyleBackColor = false;
            this.btnsupp.Click += new System.EventHandler(this.btnsupp_Click);
            // 
            // btnmodif
            // 
            this.btnmodif.BackColor = System.Drawing.Color.Gray;
            this.btnmodif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodif.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnmodif.Location = new System.Drawing.Point(208, 202);
            this.btnmodif.Name = "btnmodif";
            this.btnmodif.Size = new System.Drawing.Size(125, 33);
            this.btnmodif.TabIndex = 42;
            this.btnmodif.Text = "Modifier";
            this.btnmodif.UseVisualStyleBackColor = false;
            this.btnmodif.Click += new System.EventHandler(this.button1_Click);
            // 
            // combospecialite
            // 
            this.combospecialite.FormattingEnabled = true;
            this.combospecialite.Items.AddRange(new object[] {
            "INFORMATIQUE GEGESTION",
            "RESEAUX",
            "GENIE LOGICIEL",
            "CI",
            "AD"});
            this.combospecialite.Location = new System.Drawing.Point(208, 107);
            this.combospecialite.Name = "combospecialite";
            this.combospecialite.Size = new System.Drawing.Size(137, 21);
            this.combospecialite.TabIndex = 41;
            this.combospecialite.SelectedIndexChanged += new System.EventHandler(this.combospecialite_SelectedIndexChanged);
            // 
            // comboniveau
            // 
            this.comboniveau.FormattingEnabled = true;
            this.comboniveau.Items.AddRange(new object[] {
            "L1",
            "L2",
            "L3",
            "MASTER1",
            "MASTER2"});
            this.comboniveau.Location = new System.Drawing.Point(7, 107);
            this.comboniveau.Name = "comboniveau";
            this.comboniveau.Size = new System.Drawing.Size(137, 21);
            this.comboniveau.TabIndex = 40;
            this.comboniveau.SelectedIndexChanged += new System.EventHandler(this.comboniveau_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "SPECIALITE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "NIVEAU";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnclasse
            // 
            this.btnclasse.BackColor = System.Drawing.Color.Gray;
            this.btnclasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclasse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclasse.Location = new System.Drawing.Point(7, 205);
            this.btnclasse.Name = "btnclasse";
            this.btnclasse.Size = new System.Drawing.Size(130, 30);
            this.btnclasse.TabIndex = 36;
            this.btnclasse.Text = "enregistrer";
            this.btnclasse.UseVisualStyleBackColor = false;
            this.btnclasse.Click += new System.EventHandler(this.btnclasse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "AJOUT CLASSE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataclasse
            // 
            this.dataclasse.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataclasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataclasse.Location = new System.Drawing.Point(351, 3);
            this.dataclasse.Name = "dataclasse";
            this.dataclasse.Size = new System.Drawing.Size(578, 387);
            this.dataclasse.TabIndex = 45;
            this.dataclasse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormClasse";
            this.Text = "FormClasse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataclasse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combospecialite;
        private System.Windows.Forms.ComboBox comboniveau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnclasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneffacer;
        private System.Windows.Forms.Button btnsupp;
        private System.Windows.Forms.Button btnmodif;
        private System.Windows.Forms.DataGridView dataclasse;
    }
}