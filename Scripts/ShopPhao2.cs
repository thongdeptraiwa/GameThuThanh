using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPhao2 : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject canvaBtnphao3_1;
    [SerializeField] private GameObject canvaBtnphao3_2;

    private void Update()
    {

        if (saveData.GetPhao3_1() == 0)
        {
            canvaBtnphao3_1.SetActive(false);
        }
        else
        {
            canvaBtnphao3_1.SetActive(true);
        }
        if (saveData.GetPhao3_2() == 0)
        {
            canvaBtnphao3_2.SetActive(false);
        }
        else
        {
            canvaBtnphao3_2.SetActive(true);
        }
    }
}
