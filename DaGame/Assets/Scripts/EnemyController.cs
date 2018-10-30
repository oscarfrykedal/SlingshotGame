using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float health = 5f;
    public GameObject EnemyDeathEffect;
    public static int enemies = 6;

    void OnCollisionEnter2D(Collision2D colInfo)
    {

        if (colInfo.relativeVelocity.magnitude > health)
        {
            
            Die();
            ScoreScript.scoreValue -= 1;
            Instantiate(EnemyDeathEffect, transform.position, Quaternion.identity);
            
        }
    }

    public void Die()
    {
       Destroy(gameObject);
       
    }




}

