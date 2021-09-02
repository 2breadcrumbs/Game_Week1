using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameManager gameManager;
    public float speed = 5;
    public float horizontalInput;
    public float verticalInput;
    public GameObject projectilePrefab;
    public float xRange =5;
    public float yRange = 5;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        if (gameManager.isGameActive == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Launch a projectile from the player
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            }
        }
       
    }

    private void LateUpdate()
    {
        if (gameManager.isGameActive == true)
        {
            transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
            transform.Translate(Vector3.up * speed * verticalInput * Time.deltaTime);

            if (transform.position.x < -xRange)
            {
                transform.position = new Vector2(-xRange, transform.position.y);
            }

            if (transform.position.x > xRange)
            {
                transform.position = new Vector2(xRange, transform.position.y);
            }
            if (transform.position.y < -yRange)
            {
                transform.position = new Vector2(transform.position.x, -yRange);
            }

            if (transform.position.y > yRange)
            {
                transform.position = new Vector2(transform.position.x, yRange);
            }
        }
        
    }
}
