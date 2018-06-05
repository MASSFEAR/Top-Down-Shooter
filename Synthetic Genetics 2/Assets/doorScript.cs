using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour {

    [SerializeField]
    private Animator anim;
    private bool dooropen;

	// Use this for initialization
	void Start () {
        dooropen = false;
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            dooropen = true;
            Doors("Open");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(dooropen == true)
        {
            dooropen = false;
            Doors("Close");
        }
    }

    void Doors(string direction)
    {
        anim.SetTrigger(direction);
    }
}
