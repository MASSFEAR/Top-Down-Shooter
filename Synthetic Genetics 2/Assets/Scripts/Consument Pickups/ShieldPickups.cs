using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPickups : MonoBehaviour {
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
        if (col.gameObject.tag == "Player")
        {
            player.cur_Shield += 50;
            Destroy(gameObject);
            
        }
    }
}
