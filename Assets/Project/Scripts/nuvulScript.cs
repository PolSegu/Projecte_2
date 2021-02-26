using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuvulScript : MonoBehaviour
{

    public float speed;
    public Transform startLocation;
    public Transform FinishLocation;
    public int Case = 0;



    // Update is called once per frame
    void Update()
    {

        if (Case == 0) { 
            if(transform.position.x <= FinishLocation.position.x)
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            
            }
            else
            {
                transform.position = startLocation.position;
            }
        }
        if (Case == 1)
        {
            if (transform.position.x >= FinishLocation.position.x)
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);

            }
            else
            {
                transform.position = startLocation.position;
            }
        }
    }
}
