using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float inc;
    public int minpos;
    public int maxpos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
   void move ()
    {
       if (Input .GetKeyDown (KeyCode.A ))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, minpos, maxpos), transform.position.y, transform.position.z);

        }
       else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, minpos, maxpos), transform.position.y, transform.position.z);
                }


    }


}
