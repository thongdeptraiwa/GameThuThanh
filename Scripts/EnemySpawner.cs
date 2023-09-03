using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner main;
    [Header("References")]
    [SerializeField] private GameObject[] enemyPrefabs;

    [Header("Attributes")]
    //[SerializeField] private float enemiesPerSecond = 0.5f;
    [SerializeField] private float timeBetweenWaves = 5f;
    [SerializeField] private float difficultyScalingFactor = 0.75f;
    [SerializeField] private TextMeshProUGUI textVong;
    [SerializeField] private GameObject MenuEnd;
    [SerializeField] private TextMeshProUGUI textThang;
    [SerializeField] public GameObject ButtonNext;
    [SerializeField] public int man;//Số Màn


    [Header("Events")]
    public static UnityEvent onEnemyDestroy = new UnityEvent();

    private int currentWave = 100;
    private float timeSinceLastSpawn;
    private float enemiesAlive;
    private float enemiesLeftToSpawn;
    private bool isSpawning = false;
    private int vong = 0;
    private int soLuongQuai;
    private float enemiesPerSecond;
    private bool checkWave = true;//kiem tra de next wave

    public void Awake()
    {
        onEnemyDestroy.AddListener(EnemyDestroyed);
    }

    private void Start()
    {
        ButtonNext.SetActive(true);
    }

    private void OnGUI()
    {
        textVong.text = vong.ToString();
    }

    
    private void Update()
    {

        if (vong == 0 && ButtonNext.activeSelf == false)
        {
            vong++;
            StartCoroutine(StartWave(0.5f));
            
            return;
        }

        

        //goc
        if (!isSpawning)
        {
            return;
        }

        timeSinceLastSpawn += Time.deltaTime;

        //ket thuc game
        if (vong != 11)
        {
            //dieu kien tạo quai
            if (timeSinceLastSpawn >= (1f / enemiesPerSecond) && enemiesLeftToSpawn > 0)
            {
                
                SpawnEnemy();
                enemiesLeftToSpawn--;
                enemiesAlive++;
                timeSinceLastSpawn = 0f;
            }
            if (enemiesAlive == 0 && enemiesLeftToSpawn == 0 && ButtonNext.activeSelf == false && checkWave == true)
            {
                ButtonNext.SetActive(true);
                checkWave = false;
                LevelManager.main.IncreaseCurrency(100);
                if (vong == 10)
                {
                    //thang
                    textThang.text = string.Format("Thắng");
                    MenuEnd.SetActive(true);

                    saveData.Save(man,LevelManager.main.soSao);

                    Time.timeScale = 0;
                }

            }
            if (enemiesAlive == 0 && enemiesLeftToSpawn == 0 && ButtonNext.activeSelf == false && checkWave == false) 
            {
                EndWave();
                LevelManager.main.IncreaseCurrency(currentWave);
                vong++;
                checkWave = true;
                
            }
        }

    }

    private void EnemyDestroyed()
    {
        enemiesAlive--;
    }

    public IEnumerator StartWave(float TimeWave)
    {
        yield return new WaitForSeconds(TimeWave);
        isSpawning = true;
        enemiesLeftToSpawn = EnemiesPreWave();
    }



    public void EndWave()
    {
        
        isSpawning = false;
        timeSinceLastSpawn = 0f;
        StartCoroutine(StartWave(0.5f));
       
    }

    private void SpawnEnemy()
    {

        //Loai quai
        switch (vong)
        {
            case 1:
            case 2:
                {
                    GameObject prefabToSpawn = enemyPrefabs[0];
                    Instantiate(prefabToSpawn, LevelManager.main.startPoint.position, Quaternion.identity);
                    break;
                }
            case 3:
                {
                    GameObject prefabToSpawn = enemyPrefabs[1];
                    Instantiate(prefabToSpawn, LevelManager.main.startPoint.position, Quaternion.identity);
                    break;
                }
            case 4:
            case 5:
                {
                    int index = Random.Range(0, enemyPrefabs.Length - 1);
                    GameObject prefabToSpawn = enemyPrefabs[index];
                    Instantiate(prefabToSpawn, LevelManager.main.startPoint.position, Quaternion.identity);
                    break;
                }
            case 6:
                {
                    GameObject prefabToSpawn = enemyPrefabs[1];
                    Instantiate(prefabToSpawn, LevelManager.main.startPoint.position, Quaternion.identity);
                    break;
                }
            case 7:
            case 8:
            case 9:
                {
                    int index = Random.Range(0, enemyPrefabs.Length - 1);
                    GameObject prefabToSpawn = enemyPrefabs[index];
                    Instantiate(prefabToSpawn, LevelManager.main.startPoint.position, Quaternion.identity);
                    break;
                }
            default:
                {//vong cuoi
                    //boss
                    GameObject prefabToSpawn = enemyPrefabs[5];
                    Instantiate(prefabToSpawn, LevelManager.main.startPoint.position, Quaternion.identity);
                    break;
                }
        }

    }

    private int EnemiesPreWave()
    {
        //so luong quai
        switch (vong)
        {
            case 1:
                {
                    soLuongQuai = 2;
                    enemiesPerSecond = 0.5f;
                    break;
                }
            case 2:
                {
                    soLuongQuai = 4;
                    enemiesPerSecond = 0.5f;
                    break;
                }
            case 3:
                {
                    soLuongQuai = 2;
                    enemiesPerSecond = 0.5f;
                    break;
                }
            case 4:
                {
                    soLuongQuai = 8;
                    enemiesPerSecond = 0.75f;
                    break;
                }
            case 5:
                {
                    soLuongQuai = 15;
                    enemiesPerSecond = 1f;
                    break;
                }
            case 6:
                {
                    soLuongQuai = 10;
                    enemiesPerSecond = 1f;
                    break;
                }
            case 7:
                {
                    soLuongQuai = 25;
                    enemiesPerSecond = 1.5f;
                    break;
                }
            case 8:
                {
                    soLuongQuai = 40;
                    enemiesPerSecond = 1.5f;
                    break;
                }
            case 9:
                {
                    soLuongQuai = 60;
                    enemiesPerSecond = 2f;
                    break;
                }
            default:
                {//vong cuoi boss
                    soLuongQuai = 1;
                    break;
                }
        }
        return Mathf.RoundToInt(soLuongQuai * Mathf.Pow(1, difficultyScalingFactor));
        //cũ
        //return Mathf.RoundToInt(soLuongQuai * Mathf.Pow(currentWave, difficultyScalingFactor));
    }

}


