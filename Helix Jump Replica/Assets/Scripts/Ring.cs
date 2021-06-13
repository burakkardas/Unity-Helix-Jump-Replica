using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public Transform ball;
    public int ringCount;
    private GameManager gm;
    
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    
    void Update()
    {
        if(transform.position.y + 12.5f >= ball.position.y) {
            Destroy(gameObject);
            gm.gameScore(25);
        }    
    }
}
