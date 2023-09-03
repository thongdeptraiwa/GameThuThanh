using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager main;
    [Header("References")]
    [SerializeField] private Tower[] towers;

    private int selectedTower;

    private void Awake()
    {
        main = this;
    }
    public Tower GetSelectedTowerPhao1()
    {
        selectedTower = 4;
        return towers[selectedTower];
    }
    public Tower GetSelectedTowerCung1()
    {
        selectedTower = 0;
        return towers[selectedTower];
    }
    public Tower GetSelectedTowerPhao2()
    {
        selectedTower = 5;
        return towers[selectedTower];
    }
    public Tower GetSelectedTowerCung2()
    {
        selectedTower = 1;
        return towers[selectedTower];
    }
    public Tower GetSelectedTowerPhao3_1()
    {
        selectedTower = 6;
        return towers[selectedTower];
    }
    public Tower GetSelectedTowerCung3_1()
    {
        selectedTower = 2;
        return towers[selectedTower];
    }
    public Tower GetSelectedTowerPhao3_2()
    {
        selectedTower = 7;
        return towers[selectedTower];
    }
    public Tower GetSelectedTowerCung3_2()
    {
        selectedTower = 3;
        return towers[selectedTower];
    }
    public Tower TaoPlot()
    {
        selectedTower = 8;
        return towers[selectedTower];
    }
}

