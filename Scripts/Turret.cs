using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.EventSystems;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine.UIElements;
//using static UnityEngine.GraphicsBuffer;


public class Turret : MonoBehaviour
{
    public static Turret main;
    [Header("References")]
    [SerializeField] private Transform turretRotatePoint;
    [SerializeField] private LayerMask LoaiQuai;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firingPoint;
    [SerializeField] private GameObject canUi;//canva
    [SerializeField] private GameObject VungDat;
    //[SerializeField] private Button btnNhac;
    //[SerializeField] private Sprite truoc;
    //[SerializeField] private Sprite sau;
    //public Slider sldTiengBan;


    [Header("Attributes")]
    [SerializeField] private float targetingRange = 1.5f;//tam ban
    [SerializeField] private float rotationSpeed = 200f;//toc do ban
    [SerializeField] private float bps = 1f; //Bullets per Second


    private Transform target;
    private float timeUntilFire;
    public AudioSource tiengBan;//tieng bắn
    

    public void Start()
    {
        tiengBan = GetComponent<AudioSource>();
        //tiengBan.volume = (float)0.25;

    }
    public void Update()
    {
        //tieng ban
        if (LevelManager.main.checkTieng == false)
        {
            tiengBan.volume = 0;
        }
        else
        {
            tiengBan.volume = (float)0.25;
        }

        //
        if (target == null)
        {
            FindTarget();
            return;
        }
        RotateTowardsTarget();
        if (!CheckTargetIsInRange())
        {
            target = null;
        }
        else
        {
            timeUntilFire += Time.deltaTime;
            if(timeUntilFire >= 1f / bps)
            {
                
                Shoot();
                timeUntilFire = 0f;
            }
        }
        
    }


    private void Shoot()
    {    
        tiengBan.Play();
        GameObject bulletObj = Instantiate(bulletPrefab, firingPoint.position, Quaternion.identity);
        Bullet bulletscript = bulletObj.GetComponent<Bullet>();
        bulletscript.SetTarget(target);
    }

    private void FindTarget()
    {
        RaycastHit2D[] hits = Physics2D.CircleCastAll(transform.position, targetingRange, (Vector2)
            transform.position, 0f, LoaiQuai);
        if (hits.Length > 0)
        {
            target = hits[0].transform;
        }
    }

    private bool CheckTargetIsInRange()
    {
        return Vector2.Distance(target.position, transform.position) <= targetingRange;
    }

    private void RotateTowardsTarget()
    {
        float angle = Mathf.Atan2(target.position.y - transform.position.y, target.position.x -
            transform.position.x) * Mathf.Rad2Deg - 135f;
        Quaternion targetRotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
        turretRotatePoint.rotation = Quaternion.RotateTowards(turretRotatePoint.rotation,
            targetRotation,rotationSpeed * Time.deltaTime);
    }
    //*Loi tam ban*
    //private void OnDrawGizmosSelected()
    //{
    //    Handles.color = Color.cyan;
    //    Handles.DrawWireDisc(transform.position, transform.forward, targetingRange);
    //}

    public void OpenCanUi()
    {
        canUi.SetActive(!canUi.activeSelf);
    }

    public void ClickBanTruCung1()
    {
        LevelManager.main.TienBanTruCung1();
    }
    public void ClickBanTruPhao1()
    {
        LevelManager.main.TienBanTruPhao1();
    }
    public void ClickBanTruCung2()
    {
        LevelManager.main.TienBanTruCung2();
    }
    public void ClickBanTruPhao2()
    {
        LevelManager.main.TienBanTruPhao2();
    }
    public void ClickBanTruCung3_1()
    {
        LevelManager.main.TienBanTruCung3_1();
    }
    public void ClickBanTruPhao3_1()
    {
        LevelManager.main.TienBanTruPhao3_1();
    }
    public void ClickBanTruCung3_2()
    {
        LevelManager.main.TienBanTruCung3_2();
    }
    public void ClickBanTruPhao3_2()
    {
        LevelManager.main.TienBanTruPhao3_2();
    }

    public void Bantru()//bán trụ(xóa)
    {
        
        canUi.SetActive(false);
        Destroy(gameObject);      
    }

   
}
