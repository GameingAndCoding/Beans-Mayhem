using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SwitchScene : MonoBehaviour
{
    [SerializeField] private int SceneIndex;
    public void NextScene()
    {
        SceneManager.LoadScene(SceneIndex);
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
