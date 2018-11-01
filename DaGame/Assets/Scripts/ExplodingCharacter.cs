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
            StartCoroutine(Explode());

            
            

        }


    }
    IEnumerator Explode()
    {
        explosion.gameObject.SetActive(true);
        GameObject obj = Instantiate(explosion, transform.position, Quaternion.identity);
        //Destroy(gameObject);

        yield return new WaitForSeconds(2f);

          obj.gameObject.SetActive(false);
        
        
    }


   
    //void OnTriggerEnter2D(Collider2D other)
    //{

       // if (other.CompareTag("Enemy"))
       // {
        //    Debug.Log("träff " + other);
            
       //     GameObject gm = Instantiate(explosion, transform.position, Quaternion.identity);
        //    Debug.LogError("exp: " + gm.name);
        //    gm.gameObject.SetActive(false);




       // }
   // }

}
