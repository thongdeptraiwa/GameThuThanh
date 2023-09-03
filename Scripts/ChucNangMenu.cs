using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChucNangMenu : MonoBehaviour
{

    public void DenChonMan()
    {
        saveData.LoadData();
        SceneManager.LoadScene(1);
        
    }
    public void Man1()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
    public void DenTrangDau()
    {
        SceneManager.LoadScene(0);
    }
    public void Thoat()
    {
        Application.Quit();
    }
    public void Man2()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }
    
}
