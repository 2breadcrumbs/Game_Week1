using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public GameUIHandler gameUIHandler;
    // Start is called before the first frame update
    void Start()
    {
        gameUIHandler = GameObject.Find("Canvas").GetComponent<GameUIHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        
        if (gameObject.CompareTag("Enemy"))
            {
            gameUIHandler.UpdateScore(5);
            }
        }
    }

