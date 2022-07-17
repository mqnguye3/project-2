using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PN.UI
{
    public interface IDroppables
    {
        public void AddItem(Sprite item);

        public Sprite GetItem();


        public void RemoveItem();

    }
}

