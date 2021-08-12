using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosscode : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float Health;
    public Transform[] shootpos;
    public GameObject bullet;

    public Animator animator;
    public float speed;
    public float shoottime;
    float st;
    
    Vector2 vel;
    float t;
    void Start()
    {
        st=shoottime;
        vel=rb.velocity;
        vel.x=0;
        vel.y=-speed;
        rb.velocity=vel;
        t=Time.time;
    }

    // Update is called once per frame
    int flag=0;
    void FixedUpdate()
    {
        float t1=Time.time;
        if(Health<=0)
        {
            vel.y=0;
            rb.velocity=vel;

            animator.SetBool("Isdead",true);
            Invoke("Isdead",1f);
        }
        else
        {
            if(t1>=t+st)
        {
            vel.y=0;
            rb.velocity=vel;
            if(flag==0)
            {
            animator.SetBool("Ishitting",true);
            shoot();
            Invoke("shoot",0.5f);

            Invoke("stopshoot",1f);
            flag=1;

            }
            else if(flag==1)
            {
                animator.SetBool("Ishardhitting",true);
                hardhit();
                Invoke("stophardhit",0.5f);
                flag=0;
            }
           
            st+=2f;
            
        }

        }
        
        

    }
    void shoot()
    {
        Instantiate(bullet,shootpos[0].position,Quaternion.identity);

        
    }
    void stopshoot()
    {
        animator.SetBool("Ishitting",false);
        vel.y=-speed;
        rb.velocity=vel;
    }
    void hardhit()
    {
        Instantiate(bullet,shootpos[0].position,Quaternion.identity);
        Instantiate(bullet,shootpos[1].position,Quaternion.identity);
        Instantiate(bullet,shootpos[2].position,Quaternion.identity);
        Instantiate(bullet,shootpos[3].position,Quaternion.identity);
        Instantiate(bullet,shootpos[4].position,Quaternion.identity);
    }
    void stophardhit()
    {
         animator.SetBool("Ishardhitting",false);
        Debug.Log("Stophitting");
         vel.y=-speed;
          rb.velocity=vel;
          
    }
    
    bool Isdead()
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
}
