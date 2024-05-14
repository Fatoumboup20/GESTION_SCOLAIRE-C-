namespace CRUDSCOLAIRES
{
    partial class FormEtudiant
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnrecherhce = new System.Windows.Forms.Button();
            this.btnefface = new System.Windows.Forms.Button();
            this.btnsupp = new System.Windows.Forms.Button();
            this.btnmodif = new System.Windows.Forms.Button();
            this.comboCLASSE = new System.Windows.Forms.ComboBox();
            this.dataetudiant = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnetudiant = new System.Windows.Forms.Button();
            this.txtannee = new System.Windows.Forms.TextBox();
            this.txtreglement = new System.Windows.Forms.TextBox();
            this.txtcredit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataetudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnrecherhce);
            this.panel1.Controls.Add(this.btnefface);
            this.panel1.Controls.Add(this.btnsupp);
            this.panel1.Controls.Add(this.btnmodif);
            this.panel1.Controls.Add(this.comboCLASSE);
            this.panel1.Controls.Add(this.dataetudiant);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnetudiant);
            this.panel1.Controls.Add(this.txtannee);
            this.panel1.Controls.Add(this.txtreglement);
            this.panel1.Controls.Add(this.txtcredit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtprenom);
            this.panel1.Controls.Add(this.txtnom);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 426);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "ANNEE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "CLASSE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 29);
            this.textBox1.TabIndex = 62;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnrecherhce
            // 
            this.btnrecherhce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnrecherhce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecherhce.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnrecherhce.Location = new System.Drawing.Point(160, 123);
            this.btnrecherhce.Name = "btnrecherhce";
            this.btnrecherhce.Size = new System.Drawing.Size(104, 32);
            this.btnrecherhce.TabIndex = 61;
            this.btnrecherhce.Text = "Recherche";
            this.btnrecherhce.UseVisualStyleBackColor = false;
            this.btnrecherhce.Click += new System.EventHandler(this.btnrecherhce_Click);
            // 
            // btnefface
            // 
            this.btnefface.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnefface.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnefface.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnefface.Location = new System.Drawing.Point(160, 318);
            this.btnefface.Name = "btnefface";
            this.btnefface.Size = new System.Drawing.Size(104, 31);
            this.btnefface.TabIndex = 60;
            this.btnefface.Text = "Effacer";
            this.btnefface.UseVisualStyleBackColor = false;
            this.btnefface.Click += new System.EventHandler(this.btnefface_Click);
            // 
            // btnsupp
            // 
            this.btnsupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsupp.Location = new System.Drawing.Point(160, 380);
            this.btnsupp.Name = "btnsupp";
            this.btnsupp.Size = new System.Drawing.Size(104, 31);
            this.btnsupp.TabIndex = 59;
            this.btnsupp.Text = "Supprimer";
            this.btnsupp.UseVisualStyleBackColor = false;
            this.btnsupp.Click += new System.EventHandler(this.btnsupp_Click);
            // 
            // btnmodif
            // 
            this.btnmodif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnmodif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodif.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnmodif.Location = new System.Drawing.Point(160, 248);
            this.btnmodif.Name = "btnmodif";
            this.btnmodif.Size = new System.Drawing.Size(104, 33);
            this.btnmodif.TabIndex = 58;
            this.btnmodif.Text = "Modifier";
            this.btnmodif.UseVisualStyleBackColor = false;
            this.btnmodif.Click += new System.EventHandler(this.btnmodif_Click);
            // 
            // comboCLASSE
            // 
            this.comboCLASSE.FormattingEnabled = true;
            this.comboCLASSE.Items.AddRange(new object[] {
            "L1",
            "L2",
            "L3",
            "MASTER1",
            "MASTER2"});
            this.comboCLASSE.Location = new System.Drawing.Point(137, 71);
            this.comboCLASSE.Name = "comboCLASSE";
            this.comboCLASSE.Size = new System.Drawing.Size(147, 21);
            this.comboCLASSE.TabIndex = 57;
            // 
            // dataetudiant
            // 
            this.dataetudiant.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataetudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataetudiant.Location = new System.Drawing.Point(290, 3);
            this.dataetudiant.Name = "dataetudiant";
            this.dataetudiant.Size = new System.Drawing.Size(450, 420);
            this.dataetudiant.TabIndex = 56;
            this.dataetudiant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataetudiant_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "ANNEE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "CREDIT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "PRENOM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "REGLEMENT";
            // 
            // btnetudiant
            // 
            this.btnetudiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnetudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnetudiant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnetudiant.Location = new System.Drawing.Point(160, 183);
            this.btnetudiant.Name = "btnetudiant";
            this.btnetudiant.Size = new System.Drawing.Size(104, 33);
            this.btnetudiant.TabIndex = 51;
            this.btnetudiant.Text = "enregistrer";
            this.btnetudiant.UseVisualStyleBackColor = false;
            this.btnetudiant.Click += new System.EventHandler(this.btnetudiant_Click);
            // 
            // txtannee
            // 
            this.txtannee.Location = new System.Drawing.Point(4, 309);
            this.txtannee.Multiline = true;
            this.txtannee.Name = "txtannee";
            this.txtannee.Size = new System.Drawing.Size(124, 29);
            this.txtannee.TabIndex = 50;
            // 
            // txtreglement
            // 
            this.txtreglement.Location = new System.Drawing.Point(3, 367);
            this.txtreglement.Multiline = true;
            this.txtreglement.Name = "txtreglement";
            this.txtreglement.Size = new System.Drawing.Size(124, 34);
            this.txtreglement.TabIndex = 49;
            // 
            // txtcredit
            // 
            this.txtcredit.Location = new System.Drawing.Point(6, 248);
            this.txtcredit.Multiline = true;
            this.txtcredit.Name = "txtcredit";
            this.txtcredit.Size = new System.Drawing.Size(121, 31);
            this.txtcredit.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "NOM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 46;
            this.label4.Text = "AJOUT ETUDIANT";
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(4, 190);
            this.txtprenom.Multiline = true;
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(118, 32);
            this.txtprenom.TabIndex = 45;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(6, 130);
            this.txtnom.Multiline = true;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(121, 30);
            this.txtnom.TabIndex = 44;
            // 
            // FormEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormEtudiant";
            this.Text = "FormEtudiant";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataetudiant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboCLASSE;
        private System.Windows.Forms.DataGridView dataetudiant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnetudiant;
        private System.Windows.Forms.TextBox txtannee;
        private System.Windows.Forms.TextBox txtreglement;
        private System.Windows.Forms.TextBox txtcredit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Button btnefface;
        private System.Windows.Forms.Button btnsupp;
        private System.Windows.Forms.Button btnmodif;
        private System.Windows.Forms.Button btnrecherhce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}