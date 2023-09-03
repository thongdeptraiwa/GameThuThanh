using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextWave : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject nextwave;
    [SerializeField] private GameObject nextwave2;

    private void Update()
    {
        if (nextwave.activeSelf == true)
        {
            nextwave2.SetActive(true);
        }
        else
        {
            nextwave2.SetActive(false);
        }
    }

    public void ClickButtonNextWave()
    {
        nextwave.SetActive(false);
        nextwave2.SetActive(false);
        //EnemySpawner.main.EndWave();
    }
}
