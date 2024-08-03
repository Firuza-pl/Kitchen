namespace UNIKITCHEN.WINFORM
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.depozitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gününYeməyiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeməklərToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yemekQiymetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıxışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depozitToolStripMenuItem,
            this.gününYeməyiToolStripMenuItem,
            this.yeməklərToolStripMenuItem,
            this.yemekQiymetiToolStripMenuItem,
            this.çıxışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // depozitToolStripMenuItem
            // 
            this.depozitToolStripMenuItem.Name = "depozitToolStripMenuItem";
            this.depozitToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.depozitToolStripMenuItem.Text = "Depozit";
            this.depozitToolStripMenuItem.Click += new System.EventHandler(this.depozitToolStripMenuItem_Click);
            // 
            // gününYeməyiToolStripMenuItem
            // 
            this.gününYeməyiToolStripMenuItem.Name = "gününYeməyiToolStripMenuItem";
            this.gününYeməyiToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.gününYeməyiToolStripMenuItem.Text = "Günün Yeməyi";
            this.gününYeməyiToolStripMenuItem.Click += new System.EventHandler(this.gününYeməyiToolStripMenuItem_Click);
            // 
            // yeməklərToolStripMenuItem
            // 
            this.yeməklərToolStripMenuItem.Name = "yeməklərToolStripMenuItem";
            this.yeməklərToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.yeməklərToolStripMenuItem.Text = "Yeməklər";
            this.yeməklərToolStripMenuItem.Click += new System.EventHandler(this.yeməklərToolStripMenuItem_Click);
            // 
            // yemekQiymetiToolStripMenuItem
            // 
            this.yemekQiymetiToolStripMenuItem.Name = "yemekQiymetiToolStripMenuItem";
            this.yemekQiymetiToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.yemekQiymetiToolStripMenuItem.Text = "Yemek Qiymeti";
            this.yemekQiymetiToolStripMenuItem.Click += new System.EventHandler(this.yemekQiymetiToolStripMenuItem_Click);
            // 
            // çıxışToolStripMenuItem
            // 
            this.çıxışToolStripMenuItem.Name = "çıxışToolStripMenuItem";
            this.çıxışToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.çıxışToolStripMenuItem.Text = "Çıxış";
            this.çıxışToolStripMenuItem.Click += new System.EventHandler(this.ÇıxışToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem depozitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gününYeməyiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeməklərToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yemekQiymetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıxışToolStripMenuItem;
    }
}