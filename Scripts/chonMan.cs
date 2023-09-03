using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class chonMan : MonoBehaviour
{
    [Header("References")]
    [SerializeField]private GameObject man1;
    [SerializeField] private GameObject man2;

    [SerializeField] private Sprite noSao;
    [SerializeField] private Sprite sao;

    [SerializeField] private SpriteRenderer sao1Man1;
    [SerializeField] private SpriteRenderer sao2Man1;
    [SerializeField] private SpriteRenderer sao3Man1;

    [SerializeField] private SpriteRenderer sao1Man2;
    [SerializeField] private SpriteRenderer sao2Man2;
    [SerializeField] private SpriteRenderer sao3Man2;
    public void Start()
    {
        man1.SetActive(false);
        man2.SetActive(false);
    }
    public void Update()
    {
        int soman = saveData.GetSoMan();
        int sosao1 = saveData.GetSoSaoMan1();
        int sosao2 = saveData.GetSoSaoMan2();
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

    public void chonMan1()
    {
        man1.SetActive(true);
    }
    public void chonMan2()
    {
        man2.SetActive(true);
    }
    public void thoatMan1()
    {
        man1.SetActive(false);
    }
    public void thoatMan2()
    {
        man2.SetActive(false);
    }
}
