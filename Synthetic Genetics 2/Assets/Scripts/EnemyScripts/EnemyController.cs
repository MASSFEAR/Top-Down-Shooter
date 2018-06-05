using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    public Rigidbody Enemyrb;
    public float moveSpeed;
    public Transform Enemy;
    public Transform Playerr;

	// Use this for initialization
	void Start () {
        Enemyrb.GetComponent<Rigidbody>();
        
	}
	// Update is called once per frame
	void Update () {
        
        Enemy.transform.LookAt(Playerr);
	}
}
