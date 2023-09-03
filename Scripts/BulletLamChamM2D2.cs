using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLamChamM2D2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        other.gameObject.GetComponent<EnemyMovementD2>().UpdataSpeed(2f);

    }
}
