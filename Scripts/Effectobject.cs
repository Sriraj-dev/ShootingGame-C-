using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effectobject : MonoBehaviour
{
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("stop",time);
    }
    void stop()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
