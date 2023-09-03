using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager2 : MonoBehaviour
{
    public static LevelManager2 main;

    public Transform startPoint;
    public Transform[] path;

    private void Awake()
    {
        main = this;
    }
}
