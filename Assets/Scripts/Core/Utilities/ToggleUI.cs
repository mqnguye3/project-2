using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.UI
{
    public class ToggleUI : MonoBehaviour
    {
        [SerializeField] GameObject inventoryContainer = null;
        [SerializeField] KeyCode toggleKey;

        private void Start()
        {
            inventoryContainer.SetActive(false);
        }

        private void Update()
        {
            if (Input.GetKeyDown(toggleKey))
            {
                inventoryContainer.SetActive(!inventoryContainer.activeSelf);
            }
        }
    }

}