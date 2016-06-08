using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavenPlusEditor.GameObject.ItemObject
{
    /// <summary>
    /// Interface of All ItemObject
    /// </summary>
    public interface IItem
    {
        /// <summary>
        /// Use that Item
        /// </summary>
        void Use(params GameObject[] gameObjects);

        /// <summary>
        /// Discard that Item
        /// </summary>
        void Discard(params GameObject[] gameObjects);

        /// <summary>
        /// Get that Item
        /// </summary>
        void Get(params GameObject[] gameObjects);
    }
}
