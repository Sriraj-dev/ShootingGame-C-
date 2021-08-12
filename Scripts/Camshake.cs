using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camshake : MonoBehaviour
{
   
   float elapsed=0;
    // Update is called once per frame
    public IEnumerator Shake(float duration,float magnitude)
    {
        Vector3 campos=transform.localPosition;

        while(elapsed<duration)
        {
            float x=Random.Range(-1f,1f)*magnitude;
            float y=Random.Range(-1f,1f)*magnitude;

            transform.localPosition = new Vector3(x,y,campos.z);

            elapsed +=Time.deltaTime;

            yield return null;

        }
        transform.localPosition=campos;
    }
}
