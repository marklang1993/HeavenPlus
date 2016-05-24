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
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1008, 25);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "MainMenuStrip";
            // 
            // File_ToolStripMenuItem
            // 
            this.File_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewProject_File_ToolStripMenuItem,
            this.Load_File_ToolStripMenuItem,
            this.Save_File_ToolStripMenuItem,
            this.Exit_File_ToolStripMenuItem});
            this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
            this.File_ToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.File_ToolStripMenuItem.Text = "File";
            // 
            // NewProject_File_ToolStripMenuItem
            // 
            this.NewProject_File_ToolStripMenuItem.Name = "NewProject_File_ToolStripMenuItem";
            this.NewProject_File_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.NewProject_File_ToolStripMenuItem.Text = "New Project";
            this.NewProject_File_ToolStripMenuItem.Click += new System.EventHandler(this.NewProject_File_ToolStripMenuItem_Click);
            // 
            // Load_File_ToolStripMenuItem
            // 
            this.Load_File_ToolStripMenuItem.Name = "Load_File_ToolStripMenuItem";
            this.Load_File_ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.Load_File_ToolStripMenuItem.Text = "Load";
            // 
            // Save_File_ToolStripMenuItem
            // 
            this.Save_File_ToolStripMenuItem.Enabled = false;
            this.Save_File_ToolStripMenuItem.Name = "Save_File_ToolStripMenuItem";
            this.Save_File_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Save_File_ToolStripMenuItem.Text = "Save";
            // 
            // Exit_File_ToolStripMenuItem
            // 
            this.Exit_File_ToolStripMenuItem.Name = "Exit_File_ToolStripMenuItem";
            this.Exit_File_ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.Exit_File_ToolStripMenuItem.Text = "Exit";
            // 
            // Edit_ToolStripMenuItem
            // 
            this.Edit_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Copy_Edit_ToolStripMenuItem,
            this.Paste_Edit_ToolStripMenuItem});
            this.Edit_ToolStripMenuItem.Enabled = false;
            this.Edit_ToolStripMenuItem.Name = "Edit_ToolStripMenuItem";
            this.Edit_ToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.Edit_ToolStripMenuItem.Text = "Edit";
            // 
            // Copy_Edit_ToolStripMenuItem
            // 
            this.Copy_Edit_ToolStripMenuItem.Name = "Copy_Edit_ToolStripMenuItem";
            this.Copy_Edit_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Copy_Edit_ToolStripMenuItem.Text = "Copy";
            // 
            // Paste_Edit_ToolStripMenuItem
            // 
            this.Paste_Edit_ToolStripMenuItem.Name = "Paste_Edit_ToolStripMenuItem";
            this.Paste_Edit_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Paste_Edit_ToolStripMenuItem.Text = "Paste";
            // 
            // View_ToolStripMenuItem
            // 
            this.View_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ObjectExplorer_View_ToolStripMenuItem,
            this.MapExplorer_View_ToolStripMenuItem});
            this.View_ToolStripMenuItem.Enabled = false;
            this.View_ToolStripMenuItem.Name = "View_ToolStripMenuItem";
            this.View_ToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.View_ToolStripMenuItem.Text = "View";
            // 
            // ObjectExplorer_View_ToolStripMenuItem
            // 
            this.ObjectExplorer_View_ToolStripMenuItem.Name = "ObjectExplorer_View_ToolStripMenuItem";
            this.ObjectExplorer_View_ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ObjectExplorer_View_ToolStripMenuItem.Text = "Object Explorer";
            this.ObjectExplorer_View_ToolStripMenuItem.Click += new System.EventHandler(this.ObjectExplorer_View_ToolStripMenuItem_Click);
            // 
            // MapExplorer_View_ToolStripMenuItem
            // 
            this.MapExplorer_View_ToolStripMenuItem.Name = "MapExplorer_View_ToolStripMenuItem";
            this.MapExplorer_View_ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.MapExplorer_View_ToolStripMenuItem.Text = "Map Explorer";
            // 
            // Debug_ToolStripMenuItem
            // 
            this.Debug_ToolStripMenuItem.Enabled = false;
            this.Debug_ToolStripMenuItem.Name = "Debug_ToolStripMenuItem";
            this.Debug_ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.Debug_ToolStripMenuItem.Text = "Debug";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.MainMenuStrip);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Heaven Plus Data Editor";
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

