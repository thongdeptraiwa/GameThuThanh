using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cocDame : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        other.gameObject.GetComponent<Health>().TakeDamage(5);//dame
    }
}
