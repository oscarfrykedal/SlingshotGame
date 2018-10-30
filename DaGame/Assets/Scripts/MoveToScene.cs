using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToScene : MonoBehaviour
{
    public string newLevel;



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Character"))
        {
            SceneManager.LoadScene(newLevel);
        }
        if (other.CompareTag("Character2"))
        {
            SceneManager.LoadScene(newLevel);
        }
        if (other.CompareTag("Character3"))
        {
            SceneManager.LoadScene(newLevel);
        }
    }

 
    

}
