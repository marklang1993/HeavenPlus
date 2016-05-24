using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeavenPlusEditor.Explorer;

namespace HeavenPlusEditor
{
    // Project File Extension: .hpp(Heaven Plus Project)
    public class HeavenPlusEditorProject
    {
        // System Value
        public static readonly Version VersionValue = new Version(1, 0, 0 ,0);   //Editor Version
        
        // Variables
        private MainForm _mainForm;                         // Reference to MainForm of Editor
        private string _projectName;                        // Project Name
        //Explorer
        private ObjectExplorer _objectExplorer;             // Object Explorer

        // Accessors
        public ObjectExplorer ObjectExplorerForm
        {
            get { return _objectExplorer; }
        }           


        // Constructor
        public HeavenPlusEditorProject(MainForm mainForm, string projectName)
        {
            // Initialize Variables
            _mainForm = mainForm;
            _projectName = projectName;

            // Initialize Explorer
            _objectExplorer = new ObjectExplorer();
            _objectExplorer.MdiParent = _mainForm;
        }

        // Save Project in Configuration File
        public void SaveProject(string path)
        {

        }

        // Load Project by Configuration File
        public void LoadProject(string path)
        {

        }
    }
}
