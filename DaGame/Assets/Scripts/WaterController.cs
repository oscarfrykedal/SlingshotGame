using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterController : MonoBehaviour {



    public CharacterController characterController;
    public CharacterController characterController2;
    public CharacterController characterController3;
    public GameObject bubbles;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Character"))
        {
            Debug.Log("drowned " + other);
            Instantiate(bubbles, transform.position, Quaternion.identity);

        }
        if (other.CompareTag("Character2"))
        {
            Debug.Log("drowned " + other);
            Instantiate(bubbles, transform.position, Quaternion.identity);

        }
        if (other.CompareTag("Character3"))
        {
            Debug.Log("drowned " + other);
            Instantiate(bubbles, transform.position, Quaternion.identity);

        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
