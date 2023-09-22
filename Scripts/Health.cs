using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class Health : MonoBehaviour
{
    public static Health main;
    [Header("Attributes")]
    [SerializeField] private int maxHeatl;
    [SerializeField] private int currencyWorth;//tien thuong
    [SerializeField] private Animator Ani;
    //[SerializeField] private GameObject no;

    public Image fillBar;
    private int hitPoints;

    private bool isDestroyed = false;

    public void Start()
    {
      hitPoints = maxHeatl; 
    }

    public void TakeDamage(int dmg)
    {

        //if(hitPoints <= 0)
        //{
        //    no.SetActive(true);
        //}
        Ani.SetTrigger("BiBan");//animation bi ban
        hitPoints -= dmg;
        fillBar.fillAmount = (float)hitPoints / (float)maxHeatl;//thanh máu
        
        if (hitPoints <= 0 && !isDestroyed)
        {        
            EnemySpawner.onEnemyDestroy.Invoke();
            EnemySpawner2D2.onEnemyDestroy.Invoke();
            LevelManager.main.IncreaseCurrency(currencyWorth);
            isDestroyed = true;
            Destroy(gameObject);
        }
        
    }
    //public void lua()
    //{

    //    particleFire.SetActive(true);
    //    //StartCoroutine(thieuDot());
    //}

    //public IEnumerator thieuDot()
    //{
    //    yield return new WaitForSeconds(1f);
    //    hitPoints -= 2;
    //    yield return new WaitForSeconds(1f);
    //    hitPoints -= 2;
    //    yield return new WaitForSeconds(1f);
    //    hitPoints -= 2;
    //    particleFire.SetActive(false);
    //}
}
