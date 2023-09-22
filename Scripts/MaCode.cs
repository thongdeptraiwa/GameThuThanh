using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MaCode : MonoBehaviour
{
    public InputField code;
    public TextMeshProUGUI thongBao;
    public GameObject canvaCode;

    public void BtnCode()
    {
        canvaCode.SetActive(true);
    }
    public void x()
    {
        canvaCode.SetActive(false);
    }
    public void BtnNhap()
    {
        if (code.text.Equals("thongdeptrai")){
            thongBao.text = string.Format("Bạn đã nhận được 1 sao");
            saveData.SetTongsao(saveData.GetTongSao() + 1);
            code.text = string.Format("");
            StartCoroutine(xoaThongBao(2f));
        }
        else
        {
            thongBao.text = string.Format("Nhập code không thành công!");
            code.text = string.Format("");
            StartCoroutine(xoaThongBao(2f));
        }
    }
    
    public IEnumerator xoaThongBao(float time)
    {
        yield return new WaitForSeconds(time);
        thongBao.text = string.Format("");
    }
}
