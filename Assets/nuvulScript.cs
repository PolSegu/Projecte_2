using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuvulScript : MonoBehaviour
{

    public float speed;
    public Transform startLocation;
    public Transform FinishLocation;


    // Update is called once per frame
    void Update()
    {
        

        if(transform.position.x <= FinishLocation.position.x)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            
        }
        else
        {
            transform.position = startLocation.position;
        }



    }
}
