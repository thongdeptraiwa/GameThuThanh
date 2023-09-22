using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChucNangMenu : MonoBehaviour
{

    public void DenChonMan()
    {
        saveData.LoadData();
        //saveData.ResetData();
        SceneManager.LoadScene(2);
        
    }
    public void Man1()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }
    public void DenTrangDau()
    {
        SceneManager.LoadScene(1);
    }
    public void Thoat()
    {
        Application.Quit();
    }
    public void Man2()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1;
    }
    public void VideoMan1()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1;
    }
    public void VideoMan2()
    {
        SceneManager.LoadScene(6);
        Time.timeScale = 1;
    }
}
