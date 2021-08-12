using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemybullet : MonoBehaviour
{
    // Start is called before the first frame update
     public Rigidbody2D rb;

     public float speed=20f;
     public ParticleSystem ps2;
    void Start()
    {
        rb.velocity= transform.up*-speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.y<-10f)
        {
            Destroy(gameObject);
        }
        
    }
    //GameObject collider;
    public void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("I have entered");
        if(col.tag=="Player")
        {
            movement movement=col.GetComponent<movement>();
            movement.TakeDamage();
            Instantiate(ps2,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }

    }
}
