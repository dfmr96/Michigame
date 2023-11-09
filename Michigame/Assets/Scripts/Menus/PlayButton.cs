using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class PlayButton : MonoBehaviour
{
    public void Initial_Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Play_Level_1()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Application.Quit();
        #if UNITY_EDITOR
		    EditorApplication.ExitPlaymode();
        #endif 
    }
}
