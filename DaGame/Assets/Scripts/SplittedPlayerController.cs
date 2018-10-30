using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplittedPlayerController : MonoBehaviour {

    public GameObject splittedOne;
    public GameObject splittedTwo;
    public Rigidbody2D rb;
    public CharacterController characterController;
    public float addForce;

    public void Start()
    {
        Debug.Log("splitted");
        rb.AddForce(new Vector2(addForce, addForce));
            
    }

}
