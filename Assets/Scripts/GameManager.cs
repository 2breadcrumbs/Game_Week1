using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using TMPro;
using System.IO;


public class GameManager : MonoBehaviour
{
    public float score;
    public float highScore;
    public static GameManager Instance;
    public string playerName;
    public string topPlayerName;
    public bool isGameActive = true;


    void Start()
    {
      
    }
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadPlayerData();

    }

    // Update is called once per frame
    void Update()
    {

    }


    [System.Serializable]
    
    class SaveData
    {
        public string PlayerName;
        public float HighScore;
    }

    public void SavePlayerData()
    {
        SaveData data = new SaveData();
        data.PlayerName = topPlayerName;
        data.HighScore = highScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

    }
   
    public void LoadPlayerData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            topPlayerName = data.PlayerName;
            highScore = data.HighScore;
        }
    }
}
