using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class shop : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject canvaShop;

    //text tong sao
    [SerializeField] private TextMeshProUGUI TongSao;

    //btn tru
    [SerializeField] private GameObject canvaBtncung3_1;
    [SerializeField] private GameObject canvaBtncung3_2;
    [SerializeField] private GameObject canvaBtnphao3_1;
    [SerializeField] private GameObject canvaBtnphao3_2;

    //gia
    [SerializeField] private GameObject canvaSaocung3_1;
    [SerializeField] private GameObject canvaGiacung3_1;

    [SerializeField] private GameObject canvaSaocung3_2;
    [SerializeField] private GameObject canvaGiacung3_2;

    [SerializeField] private GameObject canvaSaophao3_1;
    [SerializeField] private GameObject canvaGiaphao3_1;

    [SerializeField] private GameObject canvaSaophao3_2;
    [SerializeField] private GameObject canvaGiaphao3_2;

    private void Update()
    {
        //tong sao
        TongSao.text = saveData.GetTongSao().ToString();
        //btn hang trong shop
        if(saveData.GetCung3_1() == 1)
        {
            canvaBtncung3_1.SetActive(false);
            canvaSaocung3_1.SetActive(false);
            canvaGiacung3_1.SetActive(false);
        }
        if (saveData.GetCung3_2() == 1)
        {
            canvaBtncung3_2.SetActive(false);
            canvaSaocung3_2.SetActive(false);
            canvaGiacung3_2.SetActive(false);
        }
        if (saveData.GetPhao3_1() == 1)
        {
            canvaBtnphao3_1.SetActive(false);
            canvaSaophao3_1.SetActive(false);
            canvaGiaphao3_1.SetActive(false);
        }
        if (saveData.GetPhao3_2() == 1)
        {
            canvaBtnphao3_2.SetActive(false);
            canvaSaophao3_2.SetActive(false);
            canvaGiaphao3_2.SetActive(false);
        }

    }

    public void clickShop()
    {
        canvaShop.SetActive(true);
    }
    public void thoatShop()
    {
        canvaShop.SetActive(false);
    }
    //mua tru
    public void muaCung3_1()
    {
        if(saveData.GetTongSao() < 1)
        {
            return;
        }
        //tru sao
        saveData.SetTongsao(saveData.GetTongSao() - 1);
        //mua tru
        saveData.SetCung3_1(1);     
    }
    public void muaCung3_2()
    {
        if (saveData.GetTongSao() < 1)
        {
            return;
        }
        //tru sao
        saveData.SetTongsao(saveData.GetTongSao() - 1);
        //mua tru
        saveData.SetCung3_2(1);
    }
    public void muaPhao3_1()
    {
        if (saveData.GetTongSao() < 1)
        {
            return;
        }
        //tru sao
        saveData.SetTongsao(saveData.GetTongSao() - 1);
        //mua tru
        saveData.SetPhao3_1(1);
    }
    public void muaPhao3_2()
    {
        if (saveData.GetTongSao() < 1)
        {
            return;
        }
        //tru sao
        saveData.SetTongsao(saveData.GetTongSao() - 1);
        //mua tru
        saveData.SetPhao3_2(1);
    }
}
