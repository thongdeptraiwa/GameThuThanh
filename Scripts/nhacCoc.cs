using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nhacCoc : MonoBehaviour
{
    public static nhacCoc main;

    public AudioSource tiengCoc;//tieng coc

    // Start is called before the first frame update
    void Start()
    {
        tiengCoc = GetComponent<AudioSource>();
        tiengCoc.Play();
    }
    private void Update()
    {
        if (LevelManager.main.checkTieng == false)
        {
            tiengCoc.volume = 0;
        }
        else
        {
            tiengCoc.volume = (float)0.25;
        }
    }
    public void btnTiengCoc()
    {
            tiengCoc.Play();
    }
}
