using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;
using System.Threading;
public class EnemyMovement : MonoBehaviour
{
    public static EnemyMovement main;
    [Header("References")]
    [SerializeField]private Rigidbody2D rd;
    [SerializeField]public float moveSpeed;//toc do chay hien tai
    [SerializeField]private Animator Ani;
    [SerializeField]private GameObject imgLamCham;
    [SerializeField]private GameObject lua;

    private Transform target;
    private int pathIndex = 0;
    public float baseSpeed;//toc do chay goc

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
        if (Vector2.Distance(target.position,transform.position) <= 0.1f)
        {

            //LevelManager.main.mau--;
            pathIndex++;


            //sau truoc chuyển đổi ANM
            if(pathIndex == 1 || pathIndex == 5)
            {               
                Ani.SetBool("Bsau", true);
            }else if(pathIndex == 3)
            {
                Ani.SetBool("Btruoc", true);
            }
            else
            {
                Ani.SetBool("Bsau", false);
                Ani.SetBool("Btruoc", false);
            }

            //khi quai den thành
            if (pathIndex == LevelManager.main.path.Length)
            {
                EnemySpawner.onEnemyDestroy.Invoke();
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
        if(moveSpeed != 0)
        {
            imgLamCham.SetActive(true);
        }
        //Thread t = new Thread(() =>
        //{
        //    stop(3000);
        //});
        //t.Start();
        StartCoroutine(ResetSpeed(3f));
    }

    public void dung()
    {
        moveSpeed = 0;
        //Thread t = new Thread(() =>
        //{      
        //        stop(3000);
        //});
        //t.Start();
        StartCoroutine(ResetSpeed(1f));
    }
    public IEnumerator ResetSpeed(float time)
    {
        yield return new WaitForSeconds(time);
        moveSpeed = baseSpeed;
        imgLamCham.SetActive(false);
    }
    public void stop(int time)
    {
        Thread.Sleep(time);
        moveSpeed = baseSpeed;
        imgLamCham.SetActive(false);
    }
    //lua
    public void Lua()
    {
        lua.SetActive(true);
        StartCoroutine(tacLua());
    }
    public IEnumerator tacLua()
    {
        yield return new WaitForSeconds(2f);
        lua.SetActive(false);
    }
}
