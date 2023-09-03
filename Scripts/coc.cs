using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class coc : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        other.gameObject.GetComponent<Health>().TakeDamage(5);//dame

        EnemyMovement.main.dung();
        EnemyMovementD2.main.dung();
        EnemyMovementD1.main.dung();
    }
}
