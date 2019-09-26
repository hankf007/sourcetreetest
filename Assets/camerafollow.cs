using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{

    public Transform target;

    Vector3 offsetVector;
    // Start is called before the first frame update
    void Start()
    {
        offsetVector = this.transform.position - target.position; 
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.LookAt(target);

        //this.transform.position = target.position + offsetVector;


        Vector3 newpos = target.position + offsetVector;
      //  newpos.y = this.transform.position.y;//discards y
      //  newpos.z = this.transform.position.z;//discards z
        //this.transform.position = newpos; 


        this.transform.position = Vector3.Lerp(this.transform.position, newpos, 0.2f); //using lerp

        // this.transform.position = Vector3.MoveTowards(this.transform.position, newpos, 0.01f); //smoother transform

        Vector3 moveVector = this.transform.position = newpos;
        moveVector *= 0.75f;
        newpos += moveVector;
        this.transform.position = newpos;
        //smoother transform

      



    }
}
