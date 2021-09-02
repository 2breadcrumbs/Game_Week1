using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public GameUIHandler gameUIHandler;
    public float topBound = 2.0f;
    public float lowerBound = -2.0f;
    // Start is called before the first frame update
    void Start()
    {
        gameUIHandler = GameObject.Find("Canvas").GetComponent<GameUIHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y > topBound)
            {
                Destroy(gameObject);
            }

        if (transform.position.y < -topBound)
        {
            Destroy(gameObject);
            gameUIHandler.GameOver();
        }


    }
}
