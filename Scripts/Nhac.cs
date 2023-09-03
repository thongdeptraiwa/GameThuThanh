using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nhac : MonoBehaviour
{
    
    public AudioSource nhacNen;
    //public Slider sldNhac;

    public bool t = true;
    
    

    //void Update()
    //{
    //    nhacNen.volume = sldNhac.value;
    //}

    //public void settingTiengBan(AudioSource tieng)
    //{
    //    tieng.volume = sldTiengBan.value;
    //}

    public void nhac() {
        t = !t;
        if (t == true)
        {
            nhacNen.volume = (float)0.25;
            //saveData.SetNhac(true);
        }
        else
        {
            nhacNen.volume = 0;
            //saveData.SetNhac(false);
        }

    }
    
    
}
