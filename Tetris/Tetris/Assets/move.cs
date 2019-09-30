using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	void Start ()
    {
    }
	
	void Update ()
	{
	    //Vector3 pos = transform.position;
		// transform.position = new Vector3(pos.x,pos.y-0.1f);

        //Debug.Log(transform.position);

        //var pos = transform.position;

        //transform.position = new Vector3(pos.x+0.1f,0,0);

        //transform.Translate(new Vector3(0.1f,0,0));

        //transform.

	    //var rotate = transform.localEulerAngles;
        //transform.localEulerAngles = new Vector3(0,0,rotate.z+3);

	    var pos = transform.position;

	    if (Input.GetKey(KeyCode.LeftArrow))
	        pos.x -= 0.1f;

	    if (Input.GetKey(KeyCode.UpArrow))
	        pos.y += 0.1f;

	    if (Input.GetKey(KeyCode.RightArrow))
	        pos.x += 0.1f;

	    if (Input.GetKey(KeyCode.DownArrow))
	        pos.y -= 0.1f;

	    transform.position = pos;
	    //transorm.Rotate(new Vector3(0,0,3));
	    /*
        if (Input.GetKey(KeyCode.UpArrow))
            transform.position 

        if (Input.GetKeyDown(KeyCode.DownArrow))
            

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        */


	}
}
