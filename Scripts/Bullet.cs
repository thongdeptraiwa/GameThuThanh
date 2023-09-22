using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    

    [Header("References")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform turretRotatePoint;

    [Header("Attributes")]
    [SerializeField] private float bulletSpeed = 5f;
    [SerializeField] private int bulletDamage = 1;
    [SerializeField] private float rotationSpeed = 5f;

    private Transform target;
    public float angle;


    public void SetTarget(Transform _target)
    {
        target = _target;
        
    }
    public void Start()
    {
        
    }
    private void Update()
    {
        if (!target)
        {
            Destroy(gameObject);
            return;
        }

       


        // Calculate the direction to the target
        Vector2 dir = (target.position - transform.position).normalized;

        // Calculate the angle in radians

        angle = Mathf.Atan2(dir.y, dir.x);

        // Calculate the velocity components based on the angle and speed

        //float angle = Mathf.Atan2(dir.y, dir.x);
        float vy1 = bulletSpeed * Mathf.Sin(angle);

        //float vx = bulletSpeed * Mathf.Cos(angle);
        //float vy = bulletSpeed * Mathf.Sin(angle);
        float vx = bulletSpeed * Mathf.Cos(angle);
        float vy = bulletSpeed * Mathf.Sin(angle);

        rb.velocity = new Vector2(vx, vy);

            // Update the rotation of the bullet to face the target
            float rotationAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rotationAngle);

        //if (vy1 > 1)
        //{
        //    angle += Time.deltaTime * rotationSpeed;
        //    Debug.Log(angle);
        //}
        //else
        //{

           

        //}
        


    }

    private void OnCollisionEnter2D(Collision2D other)
    {    
        other.gameObject.GetComponent<Health>().TakeDamage(bulletDamage);
        Destroy(gameObject);
    }
    
}
//if (angle == 45f)
//{
//     vy = bulletSpeed * Mathf.Sin(angle);
//    angle = angle - 1;

//}
//else if (angle != 0)
//{
//     vy = bulletSpeed * Mathf.Sin(angle)-1;
//    angle =angle- 1;
//}
//else
//{
//     vy = bulletSpeed * Mathf.Sin(angle);

//}
// Update the velocity of the Rigidbody2D
//float vx = bulletSpeed * Mathf.Cos(angle);
//float vy = bulletSpeed * Mathf.Sin(angle);
//Debug.Log(vx);
//else if ((angle > 90f && angle < 180) || (angle > 180f && angle < 270f))
//{
//    angle = 135f;
//}
//transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * bulletSpeed);
//Vector2 direction = (target.position - transform.position).normalized;
//rb.velocity = direction * bulletSpeed;
//Vector2 dir = target.transform.position - transform.position;
//float angle = Mathf.Atan2(chieuCao.y, direction.x) * Mathf.Rad2Deg;
//transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
