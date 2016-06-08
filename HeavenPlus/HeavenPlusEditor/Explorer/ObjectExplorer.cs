using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private BindingSource equipmentBindingSource;   // BindingSource for Equipment

        public ObjectExplorer()
        {
            InitializeComponent();
        }

        private void ObjectExplorer_Load(object sender, EventArgs e)
        {
            _initEquipmentTab();
        }


        private void _getMemberGameObject()
        {
            
        }

        private void _getMemberItemObject()
        {
            
        }

        private string[] _getMemberOEquipment()
        {
            // Getting all attributes by Reflection
            Assembly asm = Assembly.GetExecutingAssembly();

            // Get specific Attributes
            Type equipmentType = typeof(EquipmentAttributes);
            MemberInfo[] equipmentMemberInfo = equipmentType.GetMembers(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
            List<string> equipmentAttributes = new List<string>(equipmentMemberInfo.Length);

            foreach (MemberInfo memberInfo in equipmentMemberInfo)
            {
                equipmentAttributes.Add(memberInfo.Name);
            }

            return equipmentAttributes.ToArray();
        }

        private void _initEquipmentTab()
        {
            string[] equipmentAttributes = _getMemberOEquipment();
        }
    }
}
