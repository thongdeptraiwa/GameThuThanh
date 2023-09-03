using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
public class Options : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject canvaMenu;
    [SerializeField] private GameObject ButtonNext;
    [SerializeField] private GameObject settingNhac;


    private void Start()
    {
        canvaMenu.SetActive(false);
    }

    public void ClickOptions()
    {
        canvaMenu.SetActive(!canvaMenu.activeSelf);
        if (!canvaMenu.activeSelf && !settingNhac.activeSelf)
        {
            Time.timeScale = 1;//game tiếp tục
        }
        else
        {
            Time.timeScale = 0;// dừng game
        }
        
    }

    public void ClickButtonNextWave()
    {
        ButtonNext.SetActive(false);
        //EnemySpawner.main.EndWave();
    }

    public void ClickSettingNhac()
    {
        canvaMenu.SetActive(!canvaMenu.activeSelf);
        settingNhac.SetActive(!settingNhac.activeSelf);
    }
    public void ClickBackSettingNhac()
    {
        canvaMenu.SetActive(!canvaMenu.activeSelf);
        settingNhac.SetActive(!settingNhac.activeSelf);
    }

}
