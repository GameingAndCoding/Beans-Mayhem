using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TurnSwitch : MonoBehaviour
{
    public int CurrentPlayer = 0;
    public GameObject[] bean;
    
    public int DeadCounter;
    void Update()
    {
        if (Input.GetKeyDown("n"))
        {
            bean[CurrentPlayer].GetComponent<movement>().Counter = 0;
            CurrentPlayer++;
            if (CurrentPlayer == 4 ) 
            {
                CurrentPlayer = 0;
            }
            
        }

        if (CurrentPlayer == 4)
        {
            DeadCounter = 0;
            CurrentPlayer = 0;
        }
        
        if (bean[CurrentPlayer] == null)
        {
            CurrentPlayer++;
            DeadCounter++;
        }
        if(DeadCounter==3)
        {
            SceneManager.LoadScene (sceneBuildIndex:0);
        }


    }
}
