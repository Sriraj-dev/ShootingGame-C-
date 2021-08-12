using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class printscore : MonoBehaviour
{
    public  Text Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    int x;
    void Update()
    {
         x=GameObject.Find("Enemyspawner").GetComponent<Spawnenemies>().tellscore(); 
         Score.text=GameObject.Find("Enemyspawner").GetComponent<Spawnenemies>().tellscore().ToString();

         if(x>PlayerPrefs.GetInt("HighScore",0))
         {
            PlayerPrefs.SetInt("HighScore",x);
         }
    }
}
