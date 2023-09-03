using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class HealthM2 : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private int maxHeatl;
    [SerializeField] private int currencyWorth;//tien thuong
    [SerializeField] private Animator Ani;

    public Image fillBar;
    private int hitPoints;

    private bool isDestroyed = false;

    public void Start()
    {
        hitPoints = maxHeatl;
    }

    public void TakeDamage(int dmg)
    {
        Ani.SetTrigger("BiBan");//animation bi ban
        hitPoints -= dmg;
        fillBar.fillAmount = (float)hitPoints / (float)maxHeatl;//thanh máu

        if (hitPoints <= 0 && !isDestroyed)
        {
            EnemySpawner2D2.onEnemyDestroy.Invoke();
            LevelManager.main.IncreaseCurrency(currencyWorth);
            isDestroyed = true;
            Destroy(gameObject);
        }

    }
}
