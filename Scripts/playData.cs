using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playData : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject canvaPlay;

    public void play()
    {
        if(saveData.checkData() == false)
        {
            canvaPlay.SetActive(false);
            choiTiep();
            return;
        }
        canvaPlay.SetActive(true);
    }
    public void choiTiep()
    {
        saveData.LoadData();
        SceneManager.LoadScene(2);

    }
    public void clickNew()
    {
        saveData.ResetData();
        saveData.LoadData();
        SceneManager.LoadScene(2);
    }


}
