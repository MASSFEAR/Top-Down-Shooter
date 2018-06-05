using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycardDoor1 : MonoBehaviour {


    public bool keyCard1 = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnColliderStay(Collision other)
    {
        if (keyCard1 == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(gameObject);
            }
        }
    }
}
