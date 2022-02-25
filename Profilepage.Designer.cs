namespace MeetApp
{
    partial class Profilepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profilepage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meetingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meetAndChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.meetingsToolStripMenuItem,
            this.meetAndChatToolStripMenuItem,
            this.contactsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // meetingsToolStripMenuItem
            // 
            this.meetingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("meetingsToolStripMenuItem.Image")));
            this.meetingsToolStripMenuItem.Name = "meetingsToolStripMenuItem";
            this.meetingsToolStripMenuItem.Size = new System.Drawing.Size(121, 29);
            this.meetingsToolStripMenuItem.Text = "Meetings";
            // 
            // meetAndChatToolStripMenuItem
            // 
            this.meetAndChatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("meetAndChatToolStripMenuItem.Image")));
            this.meetAndChatToolStripMenuItem.Name = "meetAndChatToolStripMenuItem";
            this.meetAndChatToolStripMenuItem.Size = new System.Drawing.Size(164, 29);
            this.meetAndChatToolStripMenuItem.Text = "Meet and Chat";
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contactsToolStripMenuItem.Image")));
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.contactsToolStripMenuItem.Text = "Contacts";
            // 
            // Profilepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Profilepage";
            this.Text = "Profilepage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meetingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meetAndChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
    }
}