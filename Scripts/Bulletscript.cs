using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
     public float speed=20f;
     public ParticleSystem ps2;
    void Start()
    {
        rb.velocity= transform.up*speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y>10f)
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        
        if(col.tag=="Monster")
        {
            Debug.Log("I have touched monster");
            monstercode monster=col.GetComponent<monstercode>();
            monster.TakeDamage();
            Instantiate(ps2,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }

    }
}
