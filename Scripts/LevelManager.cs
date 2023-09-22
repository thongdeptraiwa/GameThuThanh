using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;
    //public static LevelManager Instance { get; private set; }

    
    [Header("References")]
    [SerializeField] private TextMeshProUGUI currencyUI;
    [SerializeField] private TextMeshProUGUI textMau;

    [SerializeField] private GameObject canvaThua;
    [SerializeField] private TextMeshProUGUI textThua;
    
    [SerializeField] private Sprite noSao;
    [SerializeField] private Sprite sao;

    [SerializeField] private SpriteRenderer sao1;
    [SerializeField] private SpriteRenderer sao2;
    [SerializeField] private SpriteRenderer sao3;
    

    public Transform startPoint;
    public Transform[] path;

    public int currency;
    public int mau;
    public bool checkTieng = true;

    public int soSao = 0;

    private void Awake()
    {
        mau = 10;
        main = this;
    }
    public void Start()
    {
        canvaThua.SetActive(false);
    }

    public void Update()
    {
        textMau.text = mau.ToString();
        
        //het mau la thua
        if(mau <= 0)
        {
            textThua.text = string.Format("Thua");
            canvaThua.SetActive(true);
            Time.timeScale = 0;           
        }

        //sao
        if(mau >= 9)//10-9
        {
            sao1.sprite = sao;
            sao2.sprite = sao;
            sao3.sprite = sao;
            soSao = 3;
        }else if(mau >= 5)//8-5
        {
            sao1.sprite = sao;
            sao2.sprite = sao;
            sao3.sprite = noSao;
            soSao = 2;
        }else if (mau >= 1)//4-1
        {
            sao1.sprite = sao;
            sao2.sprite = noSao;
            sao3.sprite = noSao;
            soSao = 1;
        }else
        {
            sao1.sprite = noSao;
            sao2.sprite = noSao;
            sao3.sprite = noSao;
            soSao = 0;
        }

    }

    private void OnGUI()
    {
        currencyUI.text = currency.ToString();
    }

    public void IncreaseCurrency(int amount)//+tiền 
    {
        currency += amount;
    }
    public bool SpendCurrency(int amount)//trừ tiền
    {
        if(amount <= currency)
        {
            currency -= amount;
            return true;
        }
        else
        {
            Debug.Log("ban ko du tien!");
            return false;
        }
    }
    public void TienBanTruCung1()
    {
        currency += 20;
    }
    public void TienBanTruPhao1()
    {
        currency += 30;
    }
    public void TienBanTruCung2()
    {
        currency += 30;
    }
    public void TienBanTruPhao2()
    {
        currency += 50;
    }
    public void TienBanTruCung3_1()
    {
        currency += 50;
    }
    public void TienBanTruPhao3_1()
    {
        currency += 80;
    }
    public void TienBanTruCung3_2()
    {
        currency += 50;
    }
    public void TienBanTruPhao3_2()
    {
        currency += 80;
    }
}
