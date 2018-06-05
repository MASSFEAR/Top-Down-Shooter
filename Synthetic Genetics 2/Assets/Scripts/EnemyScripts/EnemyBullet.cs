using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

    Rigidbody rb;
    public float EnemyBulletSpeed;
    public PlayerController m_player;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(0, 0, EnemyBulletSpeed, ForceMode.Impulse);
        Destroy(gameObject,3f);
        m_player = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.name == "Player")
        {
            if(m_player.cur_Shield >= 0)
            {
                m_player.cur_Shield = m_player.cur_Shield - 10;
            } else
            {
                m_player.cur_HP = m_player.cur_HP - 10;
            }
            Destroy(gameObject);
        }
        if (col.tag == "Map")
        {
            Destroy(gameObject);
        }
    }
}
