using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;

public class EnemyMovementD1 : MonoBehaviour
{
    public static EnemyMovementD1 main;
    [Header("References")]
    [SerializeField] private Rigidbody2D rd;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Animator Ani;
    [SerializeField] private GameObject imgLamCham;

    private Transform target;
    private int pathIndex = 0;
    private float baseSpeed;

    private void Awake()
    {
        main = this;
    }
    private void Start()
    {

        baseSpeed = moveSpeed;
        target = LevelManager.main.path[pathIndex];
    }


    private void Update()
    {
        
        if (Vector2.Distance(target.position, transform.position) <= 0.1f)
        {

            //LevelManager.main.mau--;
            pathIndex++;


            //sau truoc chuyển đổi ANM
            if (pathIndex == 6 || pathIndex == 8 || pathIndex == 9)
            {
                Ani.SetBool("Btruoc", true);  
            }else if(pathIndex == 7)
            {
                Ani.SetBool("Btrai", true);
            }
            else
            {
                Ani.SetBool("Btruoc", false);
                Ani.SetBool("Btrai", false);
            }

            //khi quai den thành
            if (pathIndex == LevelManager.main.path.Length)
            {
                EnemySpawner2D2.onEnemyDestroy.Invoke();
                LevelManager.main.mau--;
                Destroy(gameObject);
                return;
            }
            else
            {
                target = LevelManager.main.path[pathIndex];
            }
        }
        
    }

    private void FixedUpdate()
    {
        Vector2 direction = (target.position - transform.position).normalized;
        rd.velocity = direction * moveSpeed;
    }

    public void UpdataSpeed(float newSpeed)
    {
        moveSpeed = baseSpeed / newSpeed;
        if (moveSpeed != 0)
        {
            imgLamCham.SetActive(true);
        }
        StartCoroutine(ResetSpeed());
    }
    public void dung()
    {
        moveSpeed = 0;
        StartCoroutine(ResetSpeed());
    }
    public IEnumerator ResetSpeed()
    {
        yield return new WaitForSeconds(3f);
        moveSpeed = baseSpeed;
        imgLamCham.SetActive(false);
    }
}
