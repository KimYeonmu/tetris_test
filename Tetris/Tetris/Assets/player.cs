using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Transform BulletTransform;

    public GameObject BulletPrefab;

	// Use this for initialization
	void Start ()
	{
	    	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetKeyDown(KeyCode.A))
	    {
	        GameObject bulletObj = Instantiate(BulletPrefab);
	        bulletObj.transform.position = transform.position;
	    }
	}
}
