using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using static UnityEngine.GraphicsBuffer;

public class chieuCoc : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject canvaCoc;
    [SerializeField] private GameObject hoiChieuCoc;
    public void ClickButtonChieuCoc()
    {
        
        StartCoroutine(StartCoc());
    }
    public IEnumerator StartCoc()
    {
        canvaCoc.SetActive(true);
        hoiChieuCoc.SetActive(!hoiChieuCoc.activeSelf);
        yield return new WaitForSeconds(3f);
        canvaCoc.SetActive(false);
    }

    
}

