using System.Collections;
using System.Collections.Generic;
using PN.Equipment;
using UnityEngine;

public class TestInventory : MonoBehaviour
{

    Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GetComponent<Inventory>();
        if (inventory == null)
        {
            Debug.Log("null inventory in test");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            for (int i = 0; i < inventory.GetSize(); i++)
            {
                Debug.Log(inventory.GetItemSlot(i));
            }
        }
    }
}
