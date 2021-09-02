using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    /*
    public List<GameObject> enemies;
    private GameManager gameManager;
    private float spawnRate = 1.0f;
    public static GameObject Instance;
    */

    public GameManager gameManager;
    public GameObject[] enemyPrefabs;
    private float spawnRangeX = 2;
    private float startDelay = 2;
    private float spawnInterval = .5f;


     //Start is called before the first frame update
      void Start()
      {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
       
            InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
       
            
      
         


      }
    
     void SpawnRandomEnemy()
      {
        if (gameManager.isGameActive == true)
        {
        int enemyIndex = Random.Range( 0 , enemyPrefabs.Length);
        Vector2 spawnPos = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), 2.5f);
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
        }
    }
   /*
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();   
    }

    IEnumerator SpawnTarget()
    {
        while (gameManager.isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, enemies.Count);
            Instantiate(enemies[index]);

        }
    }
   */

}
