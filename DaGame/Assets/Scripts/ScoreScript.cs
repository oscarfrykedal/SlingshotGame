using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{

    public static int scoreValue = 6;
    public Text score;
    


    // Use this for initialization
    void Start()
    {
        score.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = " " + scoreValue;
        if (scoreValue == 0)
        {
            Debug.Log("no more enemies");
            StartCoroutine(LastScene());
        }
        score.text = " " + scoreValue;
        if (scoreValue == -1)
        {
            Debug.Log("no more enemies");
            StartCoroutine(LastScene());
        }
        score.text = " " + scoreValue;
        if (scoreValue == -2)
        {
            Debug.Log("no more enemies");
            StartCoroutine(LastScene());
        }
    }

    IEnumerator LastScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Level5");
    }
    
}


