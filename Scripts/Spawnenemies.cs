using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnenemies : MonoBehaviour
{
    
    float time;
    // Update is called once per frame
    public Transform[] SpawnLocations;

    public GameObject[] Monsters;
    public float timegap=10f;
    public float firstwave=1f;
    private int n=1;
     int r2;
   int n1=0;
   int count=0;
     int flag=0;
     int dead=0;
      int score;
     
    void Start()
    {
        score=0;
       
    }
  
  /*  void FixedUpdate()
    {
        if(Time . time >time+3*timegap && flag==1)
        {
            Instantiate(Monsters[3],SpawnLocations[2].position,Quaternion.identity);
            time+=3*timegap;
        }
        else if(Time.time>=firstwave)
        {
            int r=Random.Range(0,5);
            int r3=Random.Range(0,5);
            for(int i=0;i<5;i++)
            {
                if(i!=r && i!=r3)
                {
                   
                    int r2=Random.Range(n1,n);
                    Instantiate(Monsters[r2],SpawnLocations[i].position, Quaternion.identity);

                }
               
            }
           firstwave+=timegap;
        }
        if(Time.time>time+3*timegap &&n<3)
        {
            
            n+=1;
            time+=3*timegap;
            if(n==3)
            {
                flag=1;
            }
          //  time=time+30f;
        }

        
    }*/

    GameObject[] enemy1=new GameObject[4];

    int k=0;
   int[] check=new int[4] {0,0,0,0}; 
    void FixedUpdate()
    {
        if(Isalldead()==true && count<9)
        {
            int r=Random.Range(0,5);
            int r3=Random.Range(0,5);
            Debug.Log(r);
            Debug.Log(r3);
            Invoke("donothing",3f);
            k=0;
            dead=0;
            for(int i=0;i<5;i++)
            {
                if(i!=r && i!=r3)
                {
                   
                    int r2=Random.Range(n1,n);
                    Debug.Log(r2);
                    enemy1[k] = Instantiate(Monsters[r2],SpawnLocations[i].position, Quaternion.identity);
                    k++;
                }               
            }
            for(int i=0;i<4;i++)
            {
            check[i]=0;
            }
            
            count+=1;
            if(count==3)
            {
                n1=0;
                n+=1;
            }
            if(count==6)
            {
                n1=1;
                n+=1;
            }

        }
        if(Isalldead()==true && count==9)
        {
            k=0;
            dead=0;
            Instantiate(Monsters[3],SpawnLocations[1].position,Quaternion.identity);
            Instantiate(Monsters[3],SpawnLocations[3].position,Quaternion.identity);
            k=2;
            count=0;
        }
        
       
       

    }
    void donothing()
    {
        Debug.Log("Doing nothing");
    }
    /*bool Isalldead()
    {
        if(flag==0)
        {
            flag=1;
            return true;
        }
        for(int i=0;i<k;i++)
        {
            if(check[i]==0)
            {
                Debug.Log("Problem is here!!");
                if(enemy1[i].GetComponent<monstercode>().Isdead()==false)
                {
                return false;
                }
                else
                {
                    check[i]=1;
                }
            }
            
        }

        k=0;
       
        return true;
    }*/
    bool Isalldead()
    {
        if(flag==0)
        {
            flag=1;
            return true;
        }
        if(dead==k)
        {
            
            return true;
        }
        else
        {
            return false;
        }

    }
    
    public void number()
    {
        score+=5;

        dead+=1;
    }
    public int tellscore()
    {
        return score;
    }
}
