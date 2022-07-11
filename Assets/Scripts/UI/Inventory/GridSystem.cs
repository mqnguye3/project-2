using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PN.UI
{
    public class GridSystem : MonoBehaviour
    {
        [SerializeField] int width;
        [SerializeField] int height;

        [SerializeField] GameObject cell;

        [SerializeField] private int[,] arr;

        private void Start()
        {
            // RectTransform rect = GetComponent<RectTransform>();
            // rect.sizeDelta = new Vector3((width * 27) + 10, (height * 27) + 10);
            // arr = new int[width, height];
            // for (int x = 0; x < arr.GetLength(0); x++)
            // {
            //     for (int y = 0; y < arr.GetLength(1); y++)
            //     {
            //         GameObject temp = Instantiate(cell, new Vector3(x, y), Quaternion.identity);
            //         temp.transform.SetParent(this.transform);

            //     }
            // }
            Debug.Log(transform.position);
        }

        private void Update()
        {
        }



    }

}
