using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class LuaDauGame : MonoBehaviour
{

    [Header("References")]
    [SerializeField]private Rigidbody2D rdLua;
    [SerializeField]public float SpeedLua;

    private Transform target;
    private int pathIndex = 0;


    void Start()
    {
        target = LevelManager2.main.path[pathIndex];
        pathIndex++;
    }


    void Update()
    {
        //lien tuc
        if (Vector2.Distance(target.position, transform.position) <= 0.1f)
        {
            target = LevelManager2.main.path[pathIndex];

            if (pathIndex == 1)
            {
                pathIndex--;
            }
            else
            {
                pathIndex++;
            }
        }

            
        
    }
    private void FixedUpdate()
    {
        Vector2 direction = (target.position - transform.position).normalized;
        rdLua.velocity = direction * SpeedLua;
    }
}
