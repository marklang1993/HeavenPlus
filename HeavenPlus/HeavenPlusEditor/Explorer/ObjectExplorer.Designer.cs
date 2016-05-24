namespace HeavenPlusEditor.Explorer
{
    partial class ObjectExplorer
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
            this.ObjectExplorer_TabControl = new System.Windows.Forms.TabControl();
            this.Character_ObjectExplorer_TabPage = new System.Windows.Forms.TabPage();
            this.Enemy_ObjectExplorer_TabPage = new System.Windows.Forms.TabPage();
            this.Equipment_ObjectExplorer_TabPage = new System.Windows.Forms.TabPage();
            this.Item_ObjectExplorer_TabPage = new System.Windows.Forms.TabPage();
            this.Occupation_ObjectExplorer_TabPage = new System.Windows.Forms.TabPage();
            this.Skill_ObjectExplorer_TabPage = new System.Windows.Forms.TabPage();
            this.ObjectExplorer_TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ObjectExplorer_TabControl
            // 
            this.ObjectExplorer_TabControl.Controls.Add(this.Character_ObjectExplorer_TabPage);
            this.ObjectExplorer_TabControl.Controls.Add(this.Enemy_ObjectExplorer_TabPage);
            this.ObjectExplorer_TabControl.Controls.Add(this.Equipment_ObjectExplorer_TabPage);
            this.ObjectExplorer_TabControl.Controls.Add(this.Item_ObjectExplorer_TabPage);
            this.ObjectExplorer_TabControl.Controls.Add(this.Occupation_ObjectExplorer_TabPage);
            this.ObjectExplorer_TabControl.Controls.Add(this.Skill_ObjectExplorer_TabPage);
            this.ObjectExplorer_TabControl.Location = new System.Drawing.Point(4, 4);
            this.ObjectExplorer_TabControl.Name = "ObjectExplorer_TabControl";
            this.ObjectExplorer_TabControl.SelectedIndex = 0;
            this.ObjectExplorer_TabControl.Size = new System.Drawing.Size(775, 555);
            this.ObjectExplorer_TabControl.TabIndex = 0;
            // 
            // Character_ObjectExplorer_TabPage
            // 
            this.Character_ObjectExplorer_TabPage.Location = new System.Drawing.Point(4, 22);
            this.Character_ObjectExplorer_TabPage.Name = "Character_ObjectExplorer_TabPage";
            this.Character_ObjectExplorer_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Character_ObjectExplorer_TabPage.Size = new System.Drawing.Size(752, 512);
            this.Character_ObjectExplorer_TabPage.TabIndex = 0;
            this.Character_ObjectExplorer_TabPage.Text = "Character";
            this.Character_ObjectExplorer_TabPage.UseVisualStyleBackColor = true;
            // 
            // Enemy_ObjectExplorer_TabPage
            // 
            this.Enemy_ObjectExplorer_TabPage.Location = new System.Drawing.Point(4, 22);
            this.Enemy_ObjectExplorer_TabPage.Name = "Enemy_ObjectExplorer_TabPage";
            this.Enemy_ObjectExplorer_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Enemy_ObjectExplorer_TabPage.Size = new System.Drawing.Size(752, 512);
            this.Enemy_ObjectExplorer_TabPage.TabIndex = 1;
            this.Enemy_ObjectExplorer_TabPage.Text = "Enemy";
            this.Enemy_ObjectExplorer_TabPage.UseVisualStyleBackColor = true;
            // 
            // Equipment_ObjectExplorer_TabPage
            // 
            this.Equipment_ObjectExplorer_TabPage.Location = new System.Drawing.Point(4, 22);
            this.Equipment_ObjectExplorer_TabPage.Name = "Equipment_ObjectExplorer_TabPage";
            this.Equipment_ObjectExplorer_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Equipment_ObjectExplorer_TabPage.Size = new System.Drawing.Size(752, 512);
            this.Equipment_ObjectExplorer_TabPage.TabIndex = 2;
            this.Equipment_ObjectExplorer_TabPage.Text = "Equipment";
            this.Equipment_ObjectExplorer_TabPage.UseVisualStyleBackColor = true;
            // 
            // Item_ObjectExplorer_TabPage
            // 
            this.Item_ObjectExplorer_TabPage.Location = new System.Drawing.Point(4, 22);
            this.Item_ObjectExplorer_TabPage.Name = "Item_ObjectExplorer_TabPage";
            this.Item_ObjectExplorer_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Item_ObjectExplorer_TabPage.Size = new System.Drawing.Size(752, 491);
            this.Item_ObjectExplorer_TabPage.TabIndex = 3;
            this.Item_ObjectExplorer_TabPage.Text = "Item";
            this.Item_ObjectExplorer_TabPage.UseVisualStyleBackColor = true;
            // 
            // Occupation_ObjectExplorer_TabPage
            // 
            this.Occupation_ObjectExplorer_TabPage.Location = new System.Drawing.Point(4, 22);
            this.Occupation_ObjectExplorer_TabPage.Name = "Occupation_ObjectExplorer_TabPage";
            this.Occupation_ObjectExplorer_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Occupation_ObjectExplorer_TabPage.Size = new System.Drawing.Size(752, 491);
            this.Occupation_ObjectExplorer_TabPage.TabIndex = 4;
            this.Occupation_ObjectExplorer_TabPage.Text = "Occupation";
            this.Occupation_ObjectExplorer_TabPage.UseVisualStyleBackColor = true;
            // 
            // Skill_ObjectExplorer_TabPage
            // 
            this.Skill_ObjectExplorer_TabPage.Location = new System.Drawing.Point(4, 22);
            this.Skill_ObjectExplorer_TabPage.Name = "Skill_ObjectExplorer_TabPage";
            this.Skill_ObjectExplorer_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Skill_ObjectExplorer_TabPage.Size = new System.Drawing.Size(767, 529);
            this.Skill_ObjectExplorer_TabPage.TabIndex = 5;
            this.Skill_ObjectExplorer_TabPage.Text = "Skill";
            this.Skill_ObjectExplorer_TabPage.UseVisualStyleBackColor = true;
            // 
            // ObjectExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.ObjectExplorer_TabControl);
            this.Name = "ObjectExplorer";
            this.Text = "Object Explorer";
            this.ObjectExplorer_TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ObjectExplorer_TabControl;
        private System.Windows.Forms.TabPage Character_ObjectExplorer_TabPage;
        private System.Windows.Forms.TabPage Enemy_ObjectExplorer_TabPage;
        private System.Windows.Forms.TabPage Equipment_ObjectExplorer_TabPage;
        private System.Windows.Forms.TabPage Item_ObjectExplorer_TabPage;
        private System.Windows.Forms.TabPage Occupation_ObjectExplorer_TabPage;
        private System.Windows.Forms.TabPage Skill_ObjectExplorer_TabPage;
    }
}