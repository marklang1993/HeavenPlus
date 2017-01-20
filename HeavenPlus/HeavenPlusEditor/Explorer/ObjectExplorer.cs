using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeavenPlusEditor.GameObject.ItemObject;
using HeavenPlusEditor.GameObject.ScriptObject;

namespace HeavenPlusEditor.Explorer
{
    public partial class ObjectExplorer : Form
    {
        public ObjectExplorer()
        {
            InitializeComponent();
        }

        private void ObjectExplorer_Load(object sender, EventArgs e)
        {
            _initEquipmentTab();
            _initArticleTab();
        }  

        /// <summary>
        /// Initialize DataGridView in EquipmentTab
        /// </summary>
        private void _initEquipmentTab()
        {
            // Get the each information of OEquipment
            List<FieldInfo> gameObject_FieldInfo = _getFieldInfo(typeof(GameObject.GameObject), false);
            List<FieldInfo> itemObject_FieldInfo = _getFieldInfo(typeof(ItemObject), false);
            List<FieldInfo> equipment_FieldInfo = _getFieldInfo(typeof(OEquipment), false);

            // Compose
            List<FieldInfo> OEquipment_FieldInfo =
                (gameObject_FieldInfo.Concat(itemObject_FieldInfo)
                    .Concat(equipment_FieldInfo))
                    .ToList();

            _setDataGridView(DataGridView_Equipment, OEquipment_FieldInfo);
        }

        /// <summary>
        /// Initialize DataGridView in EquipmentTab
        /// </summary>
        private void _initArticleTab()
        {
            // Get the each information of OArticle
            List<FieldInfo> gameObject_FieldInfo = _getFieldInfo(typeof(GameObject.GameObject), false);
            List<FieldInfo> itemObject_FieldInfo = _getFieldInfo(typeof(ItemObject), false);
            List<FieldInfo> article_FieldInfo = _getFieldInfo(typeof(OArticle), false);

            // Compose
            List<FieldInfo> OArticle_FieldInfo =
                (gameObject_FieldInfo.Concat(itemObject_FieldInfo)
                    .Concat(article_FieldInfo))
                    .ToList();

            _setDataGridView(DataGridView_Article, OArticle_FieldInfo);
        }

        //######################################Common Processing Functions######################################
        /// <summary>
        /// Get FieldInfo of a Class/Struct
        /// </summary>
        /// <param name="classType">Class/Struct Type</param>
        /// <param name="isPublic">Public = True</param>
        /// <returns></returns>
        private List<FieldInfo> _getFieldInfo(Type classType, bool isPublic)
        {
            // Getting all attributes by Reflection
            Assembly asm = Assembly.GetExecutingAssembly();

            // Get specific Attributes
            FieldInfo[] classFieldInfo = classType.GetFields(
                BindingFlags.Instance |
                (isPublic ? BindingFlags.Public : BindingFlags.NonPublic)| 
                BindingFlags.DeclaredOnly);

            return classFieldInfo.ToList();
        }

        /// <summary>
        /// Processing the name of each FieldInfo
        /// The first character of the output string must be capital, and it should not be a dash line.
        /// </summary>
        /// <param name="stringList">Input FieldInfo list</param>
        /// <returns></returns>
        private List<string> _processingString(List<FieldInfo> fieldInfoList)
        {
            List<string> outputString = new List<string>(fieldInfoList.Count);

            // Processing
            foreach (FieldInfo fieldInfo in fieldInfoList)
            {
                string name = fieldInfo.Name;
                StringBuilder sb = new StringBuilder(name.Length);

                // First Character is a letter
                int startIndex; 
                if (char.IsLetter(name.ElementAt(0)))
                {
                    // Check and Convert the 1st character into a capital character
                    startIndex = 0;
                }
                else
                {
                    // The 1st character is a symbol

                    // Remove the 1st character, and check the 2nd character
                    startIndex = 1;
                }
                sb.Append(char.IsLower(name.ElementAt(startIndex)) ? char.ToUpper(name.ElementAt(startIndex)) : name.ElementAt(startIndex));
                sb.Append(name.Substring(startIndex + 1));
                
                // Add this processed string into output string list
                outputString.Add(sb.ToString());
            }

            return outputString;
        }

        /// <summary>
        /// Initialize DataGirdView
        /// </summary>
        /// <param name="dgv">DataGirdView</param>
        /// <param name="fieldInfo">FieldInfo List</param>
        private void _setDataGridView(DataGridView dgv, List<FieldInfo> fieldInfo)
        {
            // Processing the name of each field
            List<string> fieldInfo_Name = _processingString(fieldInfo);

            // Initialize the DataGirdView in corresponding tab
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.RowHeadersVisible = false;
            dgv.MultiSelect = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = Constants.LanguageResourceManager.GetString("ObjectExplorer0");
            nameColumn.ReadOnly = true;
            nameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            nameColumn.DefaultCellStyle.BackColor = Color.LightGray;
            nameColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            nameColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            nameColumn.Width = 100;

            DataGridViewTextBoxColumn valueColumn = new DataGridViewTextBoxColumn();
            valueColumn.HeaderText = Constants.LanguageResourceManager.GetString("ObjectExplorer1");
            valueColumn.ReadOnly = false;
            valueColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            valueColumn.DefaultCellStyle.BackColor = Color.White;
            valueColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            valueColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            valueColumn.Width = 100;

            dgv.Columns.Add(nameColumn);
            dgv.Columns.Add(valueColumn);
            dgv.RowCount = fieldInfo.Count; // Need to set twice


            // Set the cells in valueColumn differently based on the data type of corresponding field
            for (int index = 0; index < fieldInfo.Count; index++)
            {
                // 1. Set field's name in nameColumn
                dgv[0, index].Value = fieldInfo_Name[index];

                // 2. Set proper Cell in valueColumn.
                if (fieldInfo[index].FieldType.IsEnum)                      // # Enum
                {
                    // Enum Type => ComboBox
                    DataGridViewComboBoxCell enumComboxCell = new DataGridViewComboBoxCell();

                    // Populate all enum values, and add them into this ComboxCell
                    FieldInfo[] enumValues =
                        fieldInfo[index].FieldType.GetFields(BindingFlags.Public | BindingFlags.Static); // For Enum, using Public | Static

                    foreach (FieldInfo enumValue in enumValues)
                    {
                        enumComboxCell.Items.Add(enumValue.Name);
                    }

                    // # Set initial value
                    enumComboxCell.Value = enumValues[0].Name;

                    dgv[1, index] = enumComboxCell;
                }
                else if (fieldInfo[index].FieldType == typeof(bool))        // # Boolean
                {
                    // Bool Type => CheckBox
                    DataGridViewCheckBoxCell boolCheckBoxCell = new DataGridViewCheckBoxCell();

                    // # Set initial value
                    boolCheckBoxCell.Value = false;

                    dgv[1, index] = boolCheckBoxCell;
                }
                else if (fieldInfo[index].FieldType.IsValueType)            // # Numeric Type
                {
                    // Numeric Type(int, short, byte...) => TextBox (NOT CHANGE)

                    // # Set initial value
                    dgv[1, index].Value = 0;
                }
                else if (fieldInfo[index].FieldType == typeof(string))      // # String
                {
                    // String Type => TextBox (NOT CHANGE)

                    // # Set initial value
                    dgv[1, index].Value = "NULL";
                }
                else
                {
                    // TODO : Use Button to Pop up Another Window?
                    // Type cannot be processed
                    throw new ArgumentException(Constants.LanguageResourceManager.GetString("ExceptionMsg0") + fieldInfo[index].Name);
                }  
            } 
        }
    }
}
