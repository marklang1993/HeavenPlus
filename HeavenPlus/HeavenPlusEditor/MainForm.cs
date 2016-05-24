using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeavenPlusEditor
{
    public partial class MainForm : Form
    {
        private HeavenPlusEditorProject _heavenPlusEditorProject;   // Current Working Project
        public MainForm()
        {
            InitializeComponent();

            // Set MDI Layout
            LayoutMdi(MdiLayout.Cascade);
        }

        private void NewProject_File_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check Whether a Valid Project is Presented
            if (_heavenPlusEditorProject != null)
            {
                // Ask User to Confirm
                DialogResult result = MessageBox.Show(this, Constants.Msg[0], Constants.InfoMsg,
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Cancel)
                {
                    // Cancel the operation
                    return;
                }
            }
            // Create New Project Directly
            _heavenPlusEditorProject = new HeavenPlusEditorProject(this, "Blank");
            // Enable Related Buttons
            Save_File_ToolStripMenuItem.Enabled = true;
            Edit_ToolStripMenuItem.Enabled = true;
            View_ToolStripMenuItem.Enabled = true;
            Debug_ToolStripMenuItem.Enabled = true;
        }

        private void ObjectExplorer_View_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check Whether a Valid Project is Presented
            if (_heavenPlusEditorProject != null)
            {
                _heavenPlusEditorProject.ObjectExplorerForm.Show();
            }
        }
    }
}
