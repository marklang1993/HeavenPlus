using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeavenPlusEditor.GameObject.ScriptObject;

namespace HeavenPlusEditor.GameObject.ItemObject
{
    /// <summary>
    /// Define Article Type
    /// </summary>
    public enum ArticleType
    {   
        Undefine = 0,       // Undefined Article
        Consumable = 1,     // Disapper After Using
        Special = 2         // Special Items
    }

    /// <summary>
    /// Define Scenarios that Article Can Be Used
    /// </summary>
    public enum ArticleScenario
    {
        Forbid = 0,         // Forbidded from Using
        BattleOnly = 1,     // Can Be only Used during Battle
        MapOnly = 2,        // Can Be only Used during Map
        All = 3             // Can Be Used in Any Scenario
    }

    /// <summary>
    /// Define Valid Range of Article
    /// </summary>
    public enum ArticleRange
    {
        None = 0,           // No Range
        SinglePlayer = 1,   // Only Valid on a Single Player
        AllPlayers = 2,     // Valid on All Players
        SingleEnemy = 4,    // Only Valid on a Single Enemy
        AllEnemies = 8,     // Valid on All Enemies
        All = 15            // Valid on All Characters
    }

    /// <summary>
    /// Article Object Class
    /// </summary>
    public class OArticle : ItemObject
    {
        private ArticleType _type;              // Type of this Article
        private ArticleScenario _scenario;      // Scenario of this Article
        private ArticleRange _range;            // Valid Range of this Article

        private OScript _script;                // Executed Script  

        /// <summary>
        /// Article constuctor
        /// However, the modification for its fields is only done by using Reflection
        /// </summary>
        /// <param name="name">Name of this Article Object</param>
        public OArticle(string name) : base(name)
        {
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
