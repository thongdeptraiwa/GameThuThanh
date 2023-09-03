using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NangCaoTru : MonoBehaviour
{
    [Header("References")]
    //[SerializeField] private GameObject canva;

    private GameObject tower;
    private Turret turret;

    public void ClickCung2()
    {

        // tạo biến trụ
        Tower towerToBuild = BuildManager.main.GetSelectedTowerCung2();
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
        Destroy(gameObject);
        //canva.SetActive(false);


    }
    public void ClickPhao2()
    {

        // tạo biến trụ
        Tower towerToBuild = BuildManager.main.GetSelectedTowerPhao2();
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
        Destroy(gameObject);
        //canva.SetActive(false);
    }
    public void ClickCung3_1()
    {
        // tạo biến trụ
        Tower towerToBuild = BuildManager.main.GetSelectedTowerCung3_1();
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
        Destroy(gameObject);
        //canva.SetActive(false);


    }
    public void ClickPhao3_1()
    {
        // tạo biến trụ
        Tower towerToBuild = BuildManager.main.GetSelectedTowerPhao3_1();
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
        Destroy(gameObject);
        //canva.SetActive(false);
    }
    public void ClickCung3_2()
    {
        // tạo biến trụ
        Tower towerToBuild = BuildManager.main.GetSelectedTowerCung3_2();
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
        Destroy(gameObject);
        //canva.SetActive(false);


    }
    public void ClickPhao3_2()
    {
        // tạo biến trụ
        Tower towerToBuild = BuildManager.main.GetSelectedTowerPhao3_2();
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
        Destroy(gameObject);
        //canva.SetActive(false);
    }
    public void ClickBan_TaoPlot()
    {
        // tạo biến trụ
        Tower towerToBuild = BuildManager.main.TaoPlot();
       
        //tạo trụ
        tower = Instantiate(towerToBuild.prefab, transform.position, Quaternion.identity);
        
        //canva.SetActive(false);
    }

}
