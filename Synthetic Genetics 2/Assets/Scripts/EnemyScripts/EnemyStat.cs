using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStat : MonoBehaviour {

    public float HP;
    private PlayerController player;


    // Use this for initialization
    void Start () {
        HP = 100;
        player = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		if(HP <= 0)
        {
            player.Score += 10;
            Destroy(gameObject);
           
        }
	}
}
