using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamestop : MonoBehaviour
{
    public GameObject music;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Gamestop is running");
        Debug.Log("Triggered");
        if(col.collider.tag=="Monster")
        {
            Debug.Log(col.collider.name);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }

    }
    public void dieplayer()
    {
        Instantiate(music,transform.position,Quaternion.identity);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

 }

