﻿namespace CRUDSCOLAIRES
{
    partial class MENU
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gESTIONCLASSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTIONETUDIANTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gESTIONCLASSEToolStripMenuItem,
            this.gESTIONETUDIANTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gESTIONCLASSEToolStripMenuItem
            // 
            this.gESTIONCLASSEToolStripMenuItem.Name = "gESTIONCLASSEToolStripMenuItem";
            this.gESTIONCLASSEToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.gESTIONCLASSEToolStripMenuItem.Text = "GESTION CLASSE";
            this.gESTIONCLASSEToolStripMenuItem.Click += new System.EventHandler(this.gESTIONCLASSEToolStripMenuItem_Click);
            // 
            // gESTIONETUDIANTToolStripMenuItem
            // 
            this.gESTIONETUDIANTToolStripMenuItem.Name = "gESTIONETUDIANTToolStripMenuItem";
            this.gESTIONETUDIANTToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.gESTIONETUDIANTToolStripMenuItem.Text = "GESTION ETUDIANT";
            this.gESTIONETUDIANTToolStripMenuItem.Click += new System.EventHandler(this.gESTIONETUDIANTToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MENU";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.MENU_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gESTIONCLASSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gESTIONETUDIANTToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}