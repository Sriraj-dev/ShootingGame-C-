using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Youlost : MonoBehaviour
{
    public GameObject music;
    
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="Monster")
        {
        Instantiate(music,transform.position,Quaternion.identity);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }

       
    }
    public void PlayerDead()
    {
        Instantiate(music,transform.position,Quaternion.identity);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
