using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopCung2 : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject canvaBtncung3_1;
    [SerializeField] private GameObject canvaBtncung3_2;

    private void Update()
    {

        if (saveData.GetCung3_1() == 0)
        {
            canvaBtncung3_1.SetActive(false);
        }
        else
        {
            canvaBtncung3_1.SetActive(true);
        }
        if (saveData.GetCung3_2() == 0)
        {
            canvaBtncung3_2.SetActive(false);
        }
        else
        {
            canvaBtncung3_2.SetActive(true);
        }
    }
}
