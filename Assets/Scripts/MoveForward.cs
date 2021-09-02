using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private GameManager gameManager;
    public float speed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
       if (gameManager.isGameActive == true)
       { 
            transform.Translate(Vector2.up * Time.deltaTime * speed);
       }

    }
}
