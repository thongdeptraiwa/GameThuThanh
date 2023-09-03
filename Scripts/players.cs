using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class players : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject canvaPlayers;

    [SerializeField] private GameObject bNew1;
    [SerializeField] private GameObject bNew2;
    [SerializeField] private GameObject bNew3;

    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    [SerializeField] private GameObject player3;


    [SerializeField] private TextMeshProUGUI soMan1;
    [SerializeField] private TextMeshProUGUI soSao1;

    [SerializeField] private TextMeshProUGUI soMan2;
    [SerializeField] private TextMeshProUGUI soSao2;

    [SerializeField] private TextMeshProUGUI soMan3;
    [SerializeField] private TextMeshProUGUI soSao3;
    public void ClickPlay()
    {
        canvaPlayers.SetActive(!canvaPlayers.activeSelf);      
    }

    private void Update()
    {
        
        ////0
        //if (saveData.list == null)
        //{
        //    bNew1.SetActive(true);
        //    bNew2.SetActive(true);
        //    bNew3.SetActive(true);
        //    player1.SetActive(false);
        //    player2.SetActive(false);
        //    player3.SetActive(false);
        //}
        ////1
        //if (saveData.list.Count > 0)
        //{
        //    bNew1.SetActive(false);
        //    player1.SetActive(true);
        //    soMan1.text = string.Format("" + saveData.list[0].soMan);
        //    soSao1.text = string.Format("" + saveData.list[0].soSao);
        //}
        ////2
        //if (saveData.list.Count > 1)
        //{
        //    bNew2.SetActive(false);
        //    player2.SetActive(true);
        //    soMan2.text = string.Format("" + saveData.list[1].soMan);
        //    soSao2.text = string.Format("" + saveData.list[1].soSao);          
        //}
        ////3
        //if (saveData.list.Count > 2)
        //{
        //    bNew3.SetActive(false);
        //    player3.SetActive(true);
        //    soMan3.text = string.Format("" + saveData.list[2].soMan);
        //    soSao3.text = string.Format("" + saveData.list[2].soSao);
        //}
    }
}
