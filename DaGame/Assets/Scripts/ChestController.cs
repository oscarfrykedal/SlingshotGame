using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour {

    public float health = 10f;

    void OnCollisionEnter2D(Collision2D colInfo)
    {

        if (colInfo.relativeVelocity.magnitude > health)
        {
            ChestOpen();
        }
    }

    void ChestOpen()
    {
        Destroy(gameObject);
    }

    
}
