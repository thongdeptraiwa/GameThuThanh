using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cocM2D1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        other.gameObject.GetComponent<EnemyMovementD1>().dung();
    }
}
