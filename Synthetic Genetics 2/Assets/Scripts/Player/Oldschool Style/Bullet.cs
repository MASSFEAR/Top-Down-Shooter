using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed;
    public float LifeTime;
    [SerializeField]
    private EnemyStat enemy;
    


    // Use this for initialization
    void Start () {
        enemy = FindObjectOfType<EnemyStat>();
	}
	
	// Update is called once per frame
	void Update () {
        LifeTime -= Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if(LifeTime <= 0)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Enemy")
        {
            enemy.HP -= 10;
            Destroy(gameObject);
        }
    }
}
