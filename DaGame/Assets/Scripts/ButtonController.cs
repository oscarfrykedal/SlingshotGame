using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {


    public GameObject button;
    public GameObject door;
    public Rigidbody2D rb;
    public DoorController doorController;
    //checking if the Button is hit

    
    void OnCollisionEnter2D(Collision2D colInfo)
    {
        Debug.Log(colInfo.collider.name);
        if (colInfo.collider.name == "Button")
        {
            Debug.Log("you hit the button");
            OpenSesame();

        }
    }

    void OpenSesame()
    {
        GetComponent<Rigidbody2D>().isKinematic = false;

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
