using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class printhighscore : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Highest;
    void Start()
    {
        Highest.text=PlayerPrefs.GetInt("Highscore",0).ToString();
    }

  
}
