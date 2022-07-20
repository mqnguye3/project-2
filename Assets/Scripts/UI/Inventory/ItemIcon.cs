using System.Collections;
using System.Collections.Generic;
using PN.Equipment;
using UnityEngine;
using UnityEngine.UI;


namespace PN.UI
{
    [RequireComponent(typeof(Image))]
    public class ItemIcon : MonoBehaviour
    {
        public void SetItemIcon(ItemSO itemIcon)
        {
            var imageComponent = GetComponent<Image>();
            if (itemIcon == null)
            {
                imageComponent.enabled = false;
            }
            else
            {
                imageComponent.enabled = true;
                imageComponent.sprite = itemIcon.GetSprite();
            }
        }


        public Sprite GetItemIcon()
        {
            var imageComponent = GetComponent<Image>();
            if (!imageComponent.enabled)
            {
                return null;
            }
            return imageComponent.sprite;
        }
    }

}
