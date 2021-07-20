
namespace Gitacations
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
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendTestNotificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAPIStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testAPIParserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendTestNotificationToolStripMenuItem,
            this.checkAPIStatusToolStripMenuItem,
            this.testAPIParserToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // sendTestNotificationToolStripMenuItem
            // 
            this.sendTestNotificationToolStripMenuItem.Name = "sendTestNotificationToolStripMenuItem";
            this.sendTestNotificationToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.sendTestNotificationToolStripMenuItem.Text = "Send Test Notification";
            this.sendTestNotificationToolStripMenuItem.Click += new System.EventHandler(this.sendTestNotificationToolStripMenuItem_Click);
            // 
            // checkAPIStatusToolStripMenuItem
            // 
            this.checkAPIStatusToolStripMenuItem.Name = "checkAPIStatusToolStripMenuItem";
            this.checkAPIStatusToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.checkAPIStatusToolStripMenuItem.Text = "Check API Status";
            this.checkAPIStatusToolStripMenuItem.Click += new System.EventHandler(this.checkAPIStatusToolStripMenuItem_Click);
            // 
            // testAPIParserToolStripMenuItem
            // 
            this.testAPIParserToolStripMenuItem.Name = "testAPIParserToolStripMenuItem";
            this.testAPIParserToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.testAPIParserToolStripMenuItem.Text = "Test API Parser";
            this.testAPIParserToolStripMenuItem.Click += new System.EventHandler(this.testAPIParserToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gitacations";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendTestNotificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAPIStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testAPIParserToolStripMenuItem;
    }
}

