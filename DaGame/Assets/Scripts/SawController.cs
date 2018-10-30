using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawController : MonoBehaviour {

    public GameObject explosion;
    public CharacterController characterController;
    public CharacterController characterController2;
    public CharacterController characterController3;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Character"))
        {
            Debug.Log("träff " + other);
            characterController.OnTriggerSplit();
           
        }
        if (other.CompareTag("Character2"))
        {
            Debug.Log("träff " + other);
            characterController2.OnTriggerSplit();

        }
        if (other.CompareTag("Character3"))
        {
            Debug.Log("träff " + other);
            Destroy(gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
            Destroy(characterController3.gameObject);
            

        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
