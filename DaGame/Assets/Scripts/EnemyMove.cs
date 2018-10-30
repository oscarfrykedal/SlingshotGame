using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    public GameObject enemy;
    public GameObject circleOne;
    public GameObject circleTwo;
    public float speed = 1.0f;


    void Start () {
        EnemyUp();
	}
	
    void EnemyUp()
    {
        LeanTween.move(enemy, circleOne.transform.position, speed)
       
       .setOnComplete(EnemyDown);
        
    }

    void EnemyDown()
    {
        LeanTween.move(enemy, circleTwo.transform.position, speed)
        .setOnComplete(EnemyUp);
    }
}
