using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monstercode : MonoBehaviour
{
    public float Health;
    public Rigidbody2D rb;
    public float speed;
    public Animator animator;
    public float shoottime;
    // Start is called before the first frame update
    public float starttime;
    public GameObject bullet;
    public Transform shootposition;
    float t;
    float st;
    public ParticleSystem ps;
    
    
    void Start()
    {
        Vector2 vel=rb.velocity;
        vel.x=0;
        vel.y=-speed;
        rb.velocity=vel;

        t=Time.time;
        st=shoottime;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float t1=Time.time;
        if(Health<=0)
        {
            animator.SetBool("Isdead",true);
            Instantiate(ps,transform.position,Quaternion.identity);
            Isdead();
        }
        else
        {
            animator.SetBool("Ismoving",true);

          if(t1 >=t+st)
         {
           shoot();

           st+=2;
         }

        }
       if(transform.position.y<-10f)
       {
           Destroy(gameObject);
       }

 
    }
    void shoot()
    {
        Instantiate(bullet,shootposition.position,Quaternion.identity);
    }

    public bool Isdead()
    {
        if(Health<=0)
        {
            
            Destroy(gameObject);
            GameObject.Find("Enemyspawner").GetComponent<Spawnenemies>().number(); 
            return true;
        }
        else 
        return false;
    }
    public void TakeDamage()
    {
        Health-=10;
        Debug.Log("Monster health is reduced to "+Health);
    }
}
