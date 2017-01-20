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

    /// <summary>
    /// Equipment Object Class
    /// </summary>
    public class OEquipment : ItemObject
    {
        private EquipmentType _type;    // Type of this Equipment

        // Attributes of this Equipments
        // Basic attributes
        private int _physicalDamage;    // Physical Damage
        private int _magicDamage;       // Magic Damage
        private int _physicalDefence;   // Defensive Power for Physical Damage
        private int _magicDefence;      // Defensive Power for Magic Damage
        // Extensive attributes
        private int _power;
        private int _wisdom;
        private int _agility;
        private int _luck;
        
        /// <summary>
        /// Equipment constuctor
        /// However, the modification for its fields is only done by using Reflection
        /// </summary>
        /// <param name="name">Name of this Equipment Object</param>
        public OEquipment(string name) : base(name)
        {
            // Initialization
            _type = EquipmentType.Undefine;

            _physicalDamage = 0;
            _magicDamage = 0;
            _physicalDefence = 0;
            _magicDefence = 0;
            _power = 0;
            _wisdom = 0;
            _agility = 0;
            _luck = 0;
        }
        public override void Use(params GameObject[] gameObjects)
        {
            // Equip this equipment
            if (Useable)
            {
                
            }
        }

        public override void Discard(params GameObject[] gameObjects)
        {
            // Discard this equipment
            if (Disposable)
            {
                
            }
        }

        public override void Get(params GameObject[] gameObjects)
        {
            // Get this equipment
        }
    }
}
