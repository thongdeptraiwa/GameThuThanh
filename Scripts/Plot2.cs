using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class Plot2 : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private GameObject canva;
    //[SerializeField] private GameObject VungDat;

    private GameObject tower;  
    private Turret turret;

    private void Start()
    {
        canva.SetActive(false);
    }

    private void OnMouseDown()
    {
        if(tower == null)
        {
            canva.SetActive(!canva.activeSelf);
        }
        
    }
    public void ClickCung1()
    {
        // tạo biến trụ
        Tower towerToBuild = BuildManager.main.GetSelectedTowerCung1();
        //dk mua
        if(towerToBuild.cost > LevelManager.main.currency)
        {
            return;
        }
        //trừ tiền
        LevelManager.main.SpendCurrency(towerToBuild.cost);
        //trạo trụ
        tower = Instantiate(towerToBuild.prefab, transform.position, Quaternion.identity);
        turret = tower.GetComponent<Turret>();
        canva.SetActive(false);
        Destroy(gameObject);

    }
    public void ClickPhao1()
    {
        // tạo biến trụ
        Tower towerToBuild = BuildManager.main.GetSelectedTowerPhao1();
        //dk mua
        if (towerToBuild.cost > LevelManager.main.currency)
        {
            return;
        }
        //trừ tiền
        LevelManager.main.SpendCurrency(towerToBuild.cost);
        //trạo trụ
        tower = Instantiate(towerToBuild.prefab, transform.position, Quaternion.identity);
        turret = tower.GetComponent<Turret>();
        canva.SetActive(false);
        Destroy(gameObject);
    }
    

}
