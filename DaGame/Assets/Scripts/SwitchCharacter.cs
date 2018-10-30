using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacter : MonoBehaviour {

    public GameObject character1, character2, character3;

 


	// Use this for initialization
	void Start () {
        //character1.gameObject.SetActive(true);

    }

    public void SwitchToYellowChar()
    {

        character1.gameObject.SetActive(true);
        character2.gameObject.SetActive(false);
        character3.gameObject.SetActive(false);
    }
    public void SwitchToBlueChar()
    {
        
        character1.gameObject.SetActive(false);
        character2.gameObject.SetActive(true);
        character3.gameObject.SetActive(false);
    }
    public void SwitchToWhiteChar()
    {

        character1.gameObject.SetActive(false);
        character2.gameObject.SetActive(false);
        character3.gameObject.SetActive(true);
    }
        
 
}
