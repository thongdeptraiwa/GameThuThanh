using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class btnNhac : MonoBehaviour
{
    
    [Header("References")]
    [SerializeField] private Sprite anhTruoc;
    [SerializeField] private Sprite anhSau;
    public bool checkNhac = true;
    public bool checkTieng = true;


    public void NhacNen(Button button)
    {
        
        checkNhac = !checkNhac;
        if (checkNhac == true)
        {
            button.GetComponent<Image>().sprite = anhTruoc;
            //saveData.SetNhac(true);
        }
        else
        {
            button.GetComponent<Image>().sprite = anhSau;
            //saveData.SetNhac(false);
        }
    }

    

    public void TiengBan(Button button)
    {
        checkTieng = !checkTieng;
        if (checkTieng == true)
        {
            button.GetComponent<Image>().sprite = anhTruoc;
            LevelManager.main.checkTieng = true;
            //saveData.SetTieng(true);

        }
        else
        {
            button.GetComponent<Image>().sprite = anhSau;
            LevelManager.main.checkTieng = false;
            //saveData.SetTieng(false);
        }
        

    }
}
