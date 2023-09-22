using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using static UnityEngine.GraphicsBuffer;
using System.Threading;

public class chieuCoc : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject canvaCoc;
    [SerializeField] private GameObject hoiChieuCoc;
    public void ClickButtonChieuCoc()
    {
        StartCoroutine(StartCoc());
        //Thread t = new Thread(() =>
        //{
        //    coc(3000);
        //});
        //t.Start();
    }
    public IEnumerator StartCoc()
    {
        canvaCoc.SetActive(true);
        hoiChieuCoc.SetActive(!hoiChieuCoc.activeSelf);
        yield return new WaitForSeconds(3f);
        canvaCoc.SetActive(false);
    }
    public void coc(int time)
    {
        canvaCoc.SetActive(true);
        hoiChieuCoc.SetActive(!hoiChieuCoc.activeSelf);
        Thread.Sleep(time);
        canvaCoc.SetActive(false);
    }

}

