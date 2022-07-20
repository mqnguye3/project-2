using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.UI
{
    public class ToggleInventory : MonoBehaviour
    {
        [SerializeField] GameObject inventoryContainer = null;

        private void Start()
        {
            inventoryContainer.SetActive(false);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                inventoryContainer.SetActive(!inventoryContainer.activeSelf);
            }
        }
    }

}