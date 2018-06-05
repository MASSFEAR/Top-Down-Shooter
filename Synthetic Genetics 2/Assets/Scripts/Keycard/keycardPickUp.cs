using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keycardPickUp : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {            
            Destroy(gameObject);
        }
    }
}
