using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class hoiChieuCoc : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject hoiChieu;

    public Image fillCoc;
    int max=20;//thời gian
    float hienTai;

    // Start is called before the first frame update
    void Start()
    {
        fillCoc.fillAmount = 1;
        hienTai = max;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        fillCoc.fillAmount = (float)hienTai / (float)max;
        if (fillCoc.fillAmount == 1)
        {
            StartCoroutine(StartCoc());
            
        }
        if (fillCoc.fillAmount == 0)
        {
            hoiChieu.SetActive(!hoiChieu.activeSelf);
            hienTai = max;
        }


    }
    
    public IEnumerator StartCoc()
    {
        //1
        hienTai = hienTai - (float)0.00001;
        yield return new WaitForSeconds(1f);
        hienTai = hienTai - (float)0.99999;
        yield return new WaitForSeconds(1f);
        //20
        hienTai = hienTai - 1;
        yield return new WaitForSeconds(1f);
        hienTai = hienTai - 1;
        yield return new WaitForSeconds(1f);
        hienTai = hienTai - 1;
        yield return new WaitForSeconds(1f);
        hienTai = hienTai - 1;
        yield return new WaitForSeconds(1f);
        hienTai = hienTai - 1;
        yield return new WaitForSeconds(1f);
        hienTai = hienTai - 1;
        yield return new WaitForSeconds(1f);
        hienTai = hienTai - 1;
        yield return new WaitForSeconds(1f);
        hienTai = hienTai - 1;
        yield return new WaitForSeconds(1f);
        hienTai = hienTai - 1;
        yield return new WaitForSeconds(1f);
        hienTai = hienTai - 1;
        yield return new WaitForSeconds(1f);
        hienTai = hienTai - 1;
        yield return new WaitForSeconds(1f);
        hienTai = hienTai - 1;
        yield return new WaitForSeconds(1f);
        hienTai = hienTai - 1;
        yield return new WaitForSeconds(1f);
        hienTai = hienTai - 1;
        yield return new WaitForSeconds(1f);
        hienTai = hienTai - 1;
        yield return new WaitForSeconds(1f);
        hienTai = hienTai - 1;
        yield return new WaitForSeconds(1f);
        hienTai = hienTai - 1;
        yield return new WaitForSeconds(1f);
        hienTai = hienTai - 1;
        yield return new WaitForSeconds(1f);
        hienTai = hienTai - 1;
        //30
        //yield return new WaitForSeconds(1f);
        //hienTai = hienTai - 1;
        //yield return new WaitForSeconds(1f);
        //hienTai = hienTai - 1;
        //yield return new WaitForSeconds(1f);
        //hienTai = hienTai - 1;
        //yield return new WaitForSeconds(1f);
        //hienTai = hienTai - 1;
        //yield return new WaitForSeconds(1f);
        //hienTai = hienTai - 1;
        //yield return new WaitForSeconds(1f);
        //hienTai = hienTai - 1;
        //yield return new WaitForSeconds(1f);
        //hienTai = hienTai - 1;
        //yield return new WaitForSeconds(1f);
        //hienTai = hienTai - 1;
        //yield return new WaitForSeconds(1f);
        //hienTai = hienTai - 1;
        //yield return new WaitForSeconds(1f);
        //hienTai = hienTai - 1;

    }
}
