using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Plot : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Sprite dau;
    [SerializeField] private Sprite nham;
    //[SerializeField] private GameObject canUi;//canva
    //[SerializeField] private Color hoverColor;

    private GameObject tower;
    private Turret turret;

    
    private void OnMouseEnter()
    {
        sr.sprite = nham;
    }

    private void OnMouseExit()
    {
        sr.sprite = dau;      
    }

    private void OnMouseDown()
    {
        if (tower != null)
        {
            //turret.OpenCanUi();
            return;
        }      
        Tower towerToBuild = BuildManager.main.GetSelectedTowerPhao1();
        tower = Instantiate(towerToBuild.prefab, transform.position, Quaternion.identity);
        turret = tower.GetComponent<Turret>();
    }
    
}
