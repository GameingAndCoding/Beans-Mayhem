using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{

    public GameObject[] bean;
    public int[] health;

    void Update()
    {
        for (int i = 0; i < 4; i++)
        {
            if (health[i] < 0)
            {
                Destroy(bean[i]);
				
                
            }
        }
    }
}
