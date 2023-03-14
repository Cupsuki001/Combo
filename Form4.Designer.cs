namespace WinFormsApp1
{
    partial class Form4
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
            this.cOMBOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOMINAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMBOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cOMBOToolStripMenuItem
            // 
            this.cOMBOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vENTAToolStripMenuItem,
            this.nOMINAToolStripMenuItem});
            this.cOMBOToolStripMenuItem.Name = "cOMBOToolStripMenuItem";
            this.cOMBOToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.cOMBOToolStripMenuItem.Text = "COMBO";
            // 
            // vENTAToolStripMenuItem
            // 
            this.vENTAToolStripMenuItem.Name = "vENTAToolStripMenuItem";
            this.vENTAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vENTAToolStripMenuItem.Text = "VENTA";
            this.vENTAToolStripMenuItem.Click += new System.EventHandler(this.vENTAToolStripMenuItem_Click);
            // 
            // nOMINAToolStripMenuItem
            // 
            this.nOMINAToolStripMenuItem.Name = "nOMINAToolStripMenuItem";
            this.nOMINAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nOMINAToolStripMenuItem.Text = "NOMINA";
            this.nOMINAToolStripMenuItem.Click += new System.EventHandler(this.nOMINAToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cOMBOToolStripMenuItem;
        private ToolStripMenuItem vENTAToolStripMenuItem;
        private ToolStripMenuItem nOMINAToolStripMenuItem;
    }
}