using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolPickupGun : MonoBehaviour {

    private GunBool gunBool;
    
	// Use this for initialization
	void Start () {

        gunBool = FindObjectOfType<GunBool>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            gunBool.m_Pistol = true;
            Destroy(gameObject);
        }
    }
}
