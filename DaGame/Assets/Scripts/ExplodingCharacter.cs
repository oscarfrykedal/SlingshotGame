using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingCharacter : MonoBehaviour
{

    public GameObject explosion;
    public CharacterController characterController;

    void OnCollisionEnter2D(Collision2D colInfo)
    {
        Debug.Log(colInfo.collider.name);
        if (colInfo.collider.tag == "Enemy")
        {
            Debug.Log("you hit an enemy");
            Explode();

            
            //StartCoroutine(NotActive());

        }


    }
    void Explode()
    {
        explosion.gameObject.SetActive(true);
        Instantiate(explosion, transform.position, Quaternion.identity);
        explosion.gameObject.SetActive(false);
        Destroy(gameObject);
    }


    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Enemy"))
        {
            Debug.Log("träff " + other);
            
            Instantiate(explosion, transform.position, Quaternion.identity);
            //explosion.gameObject.SetActive(false);




        }
    }

}
