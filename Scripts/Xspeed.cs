using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xspeed : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject x1;
    [SerializeField] private GameObject x2;
    [SerializeField] private GameObject x4;


    private void Start()
    {
        Time.timeScale = 1;
        x1.SetActive(true);
        x2.SetActive(false);
        x4.SetActive(false);
    }

    public void X1()
    {
        Time.timeScale = 2;
        x1.SetActive(false);
        x2.SetActive(true);
        x4.SetActive(false);
    }
    public void X2()
    {
        Time.timeScale = 4;
        x1.SetActive(false);
        x2.SetActive(false);
        x4.SetActive(true);
    }
    public void X4()
    {
        Time.timeScale = 1;
        x1.SetActive(true);
        x2.SetActive(false);
        x4.SetActive(false);
    }

}
