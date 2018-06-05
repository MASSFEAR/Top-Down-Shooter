using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickups : MonoBehaviour {
    private PlayerController player;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "Player")
        {
            player.cur_HP += 20;
            Destroy(gameObject);
            
        }
    }
}
