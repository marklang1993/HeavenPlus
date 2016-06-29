using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavenPlusEditor.GameObject.ItemObject
{
    public abstract class ItemObject : GameObject
    {
        protected int Value;       // Value of this Item
        protected bool Disposable; // Whether this item can be discarded or not
        protected bool Useable;    // Whether this item can be used or not

        /// <summary>
        /// Item constuctor
        /// </summary>
        /// <param name="name">Name of this Item Object</param>
        protected ItemObject(string name) : base(name)
        {
            ;
        }
    }
}
