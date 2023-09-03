using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class saveMan : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject canvaMan1;
    [SerializeField] private GameObject canvaMan2;

    [SerializeField] private Sprite noSao;
    [SerializeField] private Sprite sao;

    [SerializeField] private SpriteRenderer sao1Man1;
    [SerializeField] private SpriteRenderer sao2Man1;
    [SerializeField] private SpriteRenderer sao3Man1;

    [SerializeField] private SpriteRenderer sao1Man2;
    [SerializeField] private SpriteRenderer sao2Man2;
    [SerializeField] private SpriteRenderer sao3Man2;


    public void Update()
    {
        int soman = saveData.GetSoMan();
        int sosao1 = saveData.GetSoSaoMan1();
        int sosao2 = saveData.GetSoSaoMan2();
        //1
        if (soman == 1)
        {
            canvaMan1.SetActive(true);
            canvaMan2.SetActive(false);
        }
        //2
        if (soman == 2)
        {
            canvaMan1.SetActive(true);
            canvaMan2.SetActive(true);
        }
        //Man1
        if (soman >= 1)
        {
            if (sosao1 >= 1)
            {
                sao1Man1.sprite = sao;
            }
            if (sosao1 >= 2)
            {
                sao2Man1.sprite = sao;
            }
            if (sosao1 >= 3)
            {
                sao3Man1.sprite = sao;
            }
        }

        //Man2
        if (soman >= 2)
        {
            if (sosao2 >= 1)
            {
                sao1Man2.sprite = sao;
            }
            if (sosao2 >= 2)
            {
                sao2Man2.sprite = sao;
            }
            if (sosao2 >= 3)
            {
                sao3Man2.sprite = sao;
            }
        }
        
    }
}
