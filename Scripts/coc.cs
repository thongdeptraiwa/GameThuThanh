using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class coc : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        other.gameObject.GetComponent<EnemyMovement>().dung();
    }
}
