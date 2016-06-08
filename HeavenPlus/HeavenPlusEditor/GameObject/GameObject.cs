using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavenPlusEditor.GameObject
{
    /// Naming Notation For GameObject
    /// 
    /// Abstract Class: *Object
    /// Interface Class: I*
    /// Class: O*
    

    /// <summary>
    /// Base Class For All Objects Used in HeavenPlus Engine 
    /// </summary>
    public abstract class GameObject
    {
        private static int _count = 0;  // Total Count of created GameObject
        private readonly string _name;     // Name of this GameObject


        /// <summary>
        /// Get total count of created GameObject
        /// </summary>
        public int TotalCount { get { return _count; } }

        /// <summary>
        /// Get name of this GameObject
        /// </summary>
        public string Name { get { return _name; } }

        /// <summary>
        /// Constructor - GameObject
        /// </summary>
        /// <param name="name">Name of this GameObject</param>
        protected GameObject(string name)
        {
            _name = name;
            _count++;
        }

        ~GameObject()
        {
            _count--;
        }
    }
}
