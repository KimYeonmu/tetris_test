using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float Speed = 5;

	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    Vector3 pos = transform.position;
	    pos.x += Speed * Time.deltaTime;
	    transform.position = pos;

	    int width = Screen.width;
	    int height = Screen.height;

	    Vector2 screenSize = Camera.main.ScreenToWorldPoint(new Vector3(width, height));

	    if (transform.position.x > screenSize.x || transform.position.x < -screenSize.x ||
	        transform.position.y > screenSize.y || transform.position.y < -screenSize.y)
	    {
            Destroy(gameObject);
	    }
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("enemy"))
        {
            Destroy(collider.gameObject);
        }
    }
}
