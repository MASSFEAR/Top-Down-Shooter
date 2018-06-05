using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public bool moving = false;
    [SerializeField]
    float speed = 10.0f;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        movement();

    }

    void movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
            moving = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
            moving = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);
            moving = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
            moving = true;
        }
        if(Input.GetKey(KeyCode.W) != true && Input.GetKey(KeyCode.A) != true && Input.GetKey(KeyCode.S) != true && Input.GetKey(KeyCode.D) != true)
        {
            moving = false;
        }
    }

}
