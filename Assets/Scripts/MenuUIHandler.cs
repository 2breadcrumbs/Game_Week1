using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField playerName;
    
    public void StartNew()
    {
        if (playerName.text.Length > 0)
        {
            GameManager.Instance.playerName = playerName.text;
        }
        else
        {
            GameManager.Instance.playerName = "noname";
        }
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#endif
        Application.Quit();
    }
}
