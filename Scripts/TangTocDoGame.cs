using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangTocDoGame : MonoBehaviour
{
    public static TangTocDoGame main;

    public float tocDo = 2f;

    private void Awake()
    {
        main = this;
        EnemyMovement.main.moveSpeed *= tocDo; 
    }
    private void Start()
    {
        EnemyMovement.main.moveSpeed *= tocDo;
    }
    public void x1()
    {
        tocDo = 1f;
        
    }

    public void x2()
    {
        tocDo = 2f;
    }

    public void x4()
    {
        tocDo = 4f;
    }
}
