using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PN.UI;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    void Start()
    {
        foreach (Transform child in transform)
        {
            Image image = child.gameObject.GetComponent<Image>();
            image.color = Color.red;
        }
    }

}
