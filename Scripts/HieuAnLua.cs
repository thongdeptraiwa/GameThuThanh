using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HieuAnLua : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        other.gameObject.GetComponent<EnemyMovement>().Lua();
    }
}
