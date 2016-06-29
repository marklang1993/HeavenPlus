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
        }
        
        /// <summary>
        /// Get a List of FieldInfo of GameObject
        /// </summary>
        /// <returns></returns>
        private List<FieldInfo> _getMemberGameObject()
        {
            return _getFieldInfo(typeof(GameObject.GameObject), false);
        }

        /// <summary>
        /// Get a List of FieldInfo of ItemObject
        /// </summary>
        /// <returns></returns>
        private List<FieldInfo> _getMemberItemObject()
        {
            return _getFieldInfo(typeof(ItemObject), false);
        }

        /// <summary>
        /// Get FieldInfo of OEquipment
        /// </summary>
        /// <returns></returns>
        private List<FieldInfo> _getMemberOEquipment()
        {
            List<FieldInfo> equipmentObject_FieldInfo = _getFieldInfo(typeof(OEquipment), false).Where(FieldInfo => FieldInfo.FieldType != typeof(EquipmentAttributes)).ToList();
            List<FieldInfo> equipmentAttribute_FieldInfo = _getFieldInfo(typeof(EquipmentAttributes), true);
            
            return equipmentObject_FieldInfo.Concat(equipmentAttribute_FieldInfo).ToList();
        }

        /// <summary>
        /// Initialize DataGridView in EquipmentTab
        /// </summary>
        private void _initEquipmentTab()
        {
            // Get the complete information of OEquipment
            List<FieldInfo> gameObject_FieldInfo = _getMemberGameObject();
            List<FieldInfo> itemObject_FieldInfo = _getMemberItemObject();
            List<FieldInfo> equipment_FieldInfo = _getMemberOEquipment();

            List<FieldInfo> OEquipment_FieldInfo =
                (gameObject_FieldInfo.Concat(itemObject_FieldInfo)
                    .Concat(equipment_FieldInfo))
                    .ToList();

            // Processing the name of each field
            List<string> OEquipment_Name = _processingString(OEquipment_FieldInfo);


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
    }
}
