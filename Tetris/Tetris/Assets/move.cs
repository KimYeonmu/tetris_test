using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	void Start ()
    {
		transform.position = new Vector3(1,1);
    }
	
	void Update ()
	{
	    Vector3 pos = transform.position;
		transform.position = new Vector3(pos.x,pos.y-0.1f);
	}
}
