using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavenPlusEditor.GameObject.ItemObject
{
    /// <summary>
    /// Define Equipment Type
    /// </summary>
    public enum EquipmentType
    {
        Undefine = 0,       // Undefined Equipment
        Head = 1,           // Helmet...
        Body = 2,           // Armor...
        Foot = 4,           // Shoes...
        Hand = 8,           // Weapon...
        Accessary = 16      // Rings, Ear rings, Pendant...
    }

    public struct EquipmentAttributes
    {
        // Basic attributes
        public int PhysicalDamage;    // Physical Damage
        public int MagicDamage;       // Magic Damage
        public int PhysicalDefence;   // Defensive Power for Physical Damage
        public int MagicDefence;      // Defensive Power for Magic Damage

        // Extensive attributes
        public int Power;
        public int Wisdom;
        public int Agility;
        public int Luck;
    }

    public class OEquipment : ItemObject, IItem
    {
        private EquipmentType _type;                // Type of this Equipment
        private EquipmentAttributes _attributes;    // Attributes of this Equipments
        
        /// <summary>
        /// Equipment constuctor
        /// </summary>
        /// <param name="name">Name of this Equipment Object</param>
        public OEquipment(string name, EquipmentType type, EquipmentAttributes attributes) : base(name)
        {
            // Initialization
            _type = type;
            _attributes = attributes;
        }
        public void Use(params GameObject[] gameObjects)
        {
            // Equip this equipment
            if (_useable)
            {
                
            }
        }

        public void Discard(params GameObject[] gameObjects)
        {
            // Discard this equipment
            if (_disposable)
            {
                
            }
        }

        public void Get(params GameObject[] gameObjects)
        {
            // Get this equipment
        }
    }
}
