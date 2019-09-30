using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour
{
    public BoxCollider2D Collider;

	void Start ()
	{
	    Collider = GetComponent<BoxCollider2D>();
	}
	
	void Update ()
	{
		
	}

    public void OnCollisionEnter2D(Collision2D collider)
    {
        Debug.Log("enter");
    }

    public void OnCollisionStay2D(Collision2D collider)
    {
        Debug.Log("stay");
    }

    public void OnCollisionExit2D(Collision2D collider)
    {
        Debug.Log("exit");
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag != "team")
            Destroy(col.gameObject);
    }

    public void OnTriggerStay2D(Collider2D collider)
    { 
        Debug.Log("trigger stay");
    }

    public void OnTriggerExit2D(Collider2D collider)
    {
        Debug.Log("trigger exit");
    }
}