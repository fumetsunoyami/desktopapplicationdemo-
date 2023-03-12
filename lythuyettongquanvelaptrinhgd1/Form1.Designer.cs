namespace lythuyettongquanvelaptrinhgd1
{
    partial class Form1
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
            this.nguyễnViệtLinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupPanelTabcontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptb = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguyễnViệtLinhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nguyễnViệtLinhToolStripMenuItem
            // 
            this.nguyễnViệtLinhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupPanelTabcontrolToolStripMenuItem,
            this.ptb,
            this.menu});
            this.nguyễnViệtLinhToolStripMenuItem.Name = "nguyễnViệtLinhToolStripMenuItem";
            this.nguyễnViệtLinhToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.nguyễnViệtLinhToolStripMenuItem.Text = "Nguyễn Việt linh ";
            // 
            // groupPanelTabcontrolToolStripMenuItem
            // 
            this.groupPanelTabcontrolToolStripMenuItem.Name = "groupPanelTabcontrolToolStripMenuItem";
            this.groupPanelTabcontrolToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupPanelTabcontrolToolStripMenuItem.Text = "group, panel ";
            this.groupPanelTabcontrolToolStripMenuItem.Click += new System.EventHandler(this.groupPanelTabcontrolToolStripMenuItem_Click);
            // 
            // ptb
            // 
            this.ptb.Name = "ptb";
            this.ptb.Size = new System.Drawing.Size(180, 22);
            this.ptb.Text = " imagelist  ";
            this.ptb.Click += new System.EventHandler(this.ptb_Click);
            // 
            // menu
            // 
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(180, 22);
            this.menu.Text = "menustrip";
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nguyễnViệtLinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupPanelTabcontrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ptb;
        private System.Windows.Forms.ToolStripMenuItem menu;
    }
}

