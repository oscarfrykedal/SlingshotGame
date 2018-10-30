using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour
{


    public Rigidbody2D rb;
    public HookController hookController;
    public DoorController doorController;
    public SplittedPlayerController splittedController;
    public SawController sawController;
    public float releaseTime = 0.15f;
    private bool isPressed = false;
    public Rigidbody2D hook;
    public GameObject deathEffect;
    public GameObject nextPlayer;
    public GameObject enemyHit;
    public GameObject player;
    public GameObject splittedPlayer;
    public GameObject splittedPlayerTwo;
  



 

//checking if i hit an enemy
    void OnCollisionEnter2D(Collision2D colInfo)
    {
        Debug.Log(colInfo.collider.name);
        if (colInfo.collider.name == "Enemy")
        {
            Debug.Log("you hit an enemy");
            Die();

        }


        if (colInfo.collider.name == "Button")
        {
            Debug.Log("you hit the button");
            openSesame();
        }
    }


    //if i hit the button
    void openSesame()
    {
        doorController.GetComponent<Rigidbody2D>().isKinematic = false;
        
    }

    // split the player in two
    public void OnTriggerSplit()
    {
        //Debug.Log("hallå?!");
        Destroy(gameObject);
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        nextPlayer.SetActive(true);

        Instantiate(splittedPlayer, transform.position, transform.rotation);
        Instantiate(splittedPlayerTwo, transform.position, transform.rotation);

        
        //if there is no more lifes, restart level
        if (nextPlayer == null)
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        {

            nextPlayer.SetActive(true);
            
        }
      
    }


    //if i hit an enemy
    public void Die()
    {

        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);


    
        
        if (nextPlayer == null)
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            nextPlayer.SetActive(true);
        }
    }

    //the shooting part
    void Update()
    {
        if (isPressed)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (Vector3.Distance(mousePos, hook.position) > 3f)
                rb.position = hook.position + (mousePos - hook.position).normalized * 3f;
            else
                rb.position = mousePos;
        }
    }

    void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
        
    }

    void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;

        StartCoroutine(Release());
        
    }

    IEnumerator Release()
    {
        yield return new WaitForSeconds(releaseTime);

        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled = false;

        yield return new WaitForSeconds(5f);

        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        if (nextPlayer != null)
        {
            nextPlayer.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    

    }


}
  
