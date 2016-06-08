namespace HeavenPlusEditor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewProject_File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Load_File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy_Edit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste_Edit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.View_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ObjectExplorer_View_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MapExplorer_View_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Debug_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStripMenuItem,
            this.Edit_ToolStripMenuItem,
            this.View_ToolStripMenuItem,
            this.Debug_ToolStripMenuItem});
            resources.ApplyResources(this.MainMenuStrip, "MainMenuStrip");
            this.MainMenuStrip.Name = "MainMenuStrip";
            // 
            // File_ToolStripMenuItem
            // 
            this.File_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewProject_File_ToolStripMenuItem,
            this.Load_File_ToolStripMenuItem,
            this.Save_File_ToolStripMenuItem,
            this.Exit_File_ToolStripMenuItem});
            this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
            resources.ApplyResources(this.File_ToolStripMenuItem, "File_ToolStripMenuItem");
            // 
            // NewProject_File_ToolStripMenuItem
            // 
            this.NewProject_File_ToolStripMenuItem.Name = "NewProject_File_ToolStripMenuItem";
            resources.ApplyResources(this.NewProject_File_ToolStripMenuItem, "NewProject_File_ToolStripMenuItem");
            this.NewProject_File_ToolStripMenuItem.Click += new System.EventHandler(this.NewProject_File_ToolStripMenuItem_Click);
            // 
            // Load_File_ToolStripMenuItem
            // 
            this.Load_File_ToolStripMenuItem.Name = "Load_File_ToolStripMenuItem";
            resources.ApplyResources(this.Load_File_ToolStripMenuItem, "Load_File_ToolStripMenuItem");
            // 
            // Save_File_ToolStripMenuItem
            // 
            resources.ApplyResources(this.Save_File_ToolStripMenuItem, "Save_File_ToolStripMenuItem");
            this.Save_File_ToolStripMenuItem.Name = "Save_File_ToolStripMenuItem";
            // 
            // Exit_File_ToolStripMenuItem
            // 
            this.Exit_File_ToolStripMenuItem.Name = "Exit_File_ToolStripMenuItem";
            resources.ApplyResources(this.Exit_File_ToolStripMenuItem, "Exit_File_ToolStripMenuItem");
            this.Exit_File_ToolStripMenuItem.Click += new System.EventHandler(this.Exit_File_ToolStripMenuItem_Click);
            // 
            // Edit_ToolStripMenuItem
            // 
            this.Edit_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Copy_Edit_ToolStripMenuItem,
            this.Paste_Edit_ToolStripMenuItem});
            resources.ApplyResources(this.Edit_ToolStripMenuItem, "Edit_ToolStripMenuItem");
            this.Edit_ToolStripMenuItem.Name = "Edit_ToolStripMenuItem";
            // 
            // Copy_Edit_ToolStripMenuItem
            // 
            this.Copy_Edit_ToolStripMenuItem.Name = "Copy_Edit_ToolStripMenuItem";
            resources.ApplyResources(this.Copy_Edit_ToolStripMenuItem, "Copy_Edit_ToolStripMenuItem");
            // 
            // Paste_Edit_ToolStripMenuItem
            // 
            this.Paste_Edit_ToolStripMenuItem.Name = "Paste_Edit_ToolStripMenuItem";
            resources.ApplyResources(this.Paste_Edit_ToolStripMenuItem, "Paste_Edit_ToolStripMenuItem");
            // 
            // View_ToolStripMenuItem
            // 
            this.View_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ObjectExplorer_View_ToolStripMenuItem,
            this.MapExplorer_View_ToolStripMenuItem});
            resources.ApplyResources(this.View_ToolStripMenuItem, "View_ToolStripMenuItem");
            this.View_ToolStripMenuItem.Name = "View_ToolStripMenuItem";
            // 
            // ObjectExplorer_View_ToolStripMenuItem
            // 
            this.ObjectExplorer_View_ToolStripMenuItem.Name = "ObjectExplorer_View_ToolStripMenuItem";
            resources.ApplyResources(this.ObjectExplorer_View_ToolStripMenuItem, "ObjectExplorer_View_ToolStripMenuItem");
            this.ObjectExplorer_View_ToolStripMenuItem.Click += new System.EventHandler(this.ObjectExplorer_View_ToolStripMenuItem_Click);
            // 
            // MapExplorer_View_ToolStripMenuItem
            // 
            this.MapExplorer_View_ToolStripMenuItem.Name = "MapExplorer_View_ToolStripMenuItem";
            resources.ApplyResources(this.MapExplorer_View_ToolStripMenuItem, "MapExplorer_View_ToolStripMenuItem");
            // 
            // Debug_ToolStripMenuItem
            // 
            resources.ApplyResources(this.Debug_ToolStripMenuItem, "Debug_ToolStripMenuItem");
            this.Debug_ToolStripMenuItem.Name = "Debug_ToolStripMenuItem";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainMenuStrip);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem File_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem View_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Debug_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewProject_File_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Load_File_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save_File_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit_File_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Copy_Edit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ObjectExplorer_View_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MapExplorer_View_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Paste_Edit_ToolStripMenuItem;
    }
}

