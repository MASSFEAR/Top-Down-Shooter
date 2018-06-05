using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolGunController : MonoBehaviour {

    public bool IsFiring;
    public Bullet bullet;
    public float BulletSpeed;
    public float FiringCD;
    private float ShotCounter;
    public Transform BulletPoint;
    [SerializeField]
    public int cur_pistolAmmo;
    

	// Use this for initialization
	void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {
        if (cur_pistolAmmo > 0)
        {
            if (IsFiring)
            {
                ShotCounter -= Time.deltaTime;
                if (ShotCounter <= 0)
                {
                    ShotCounter = FiringCD;
                    Bullet newbullet = Instantiate(bullet, BulletPoint.position, BulletPoint.rotation) as Bullet;
                    newbullet.speed = BulletSpeed;
                    cur_pistolAmmo -= 1;
                }

            }
            else
            {
                ShotCounter = 0;
            }
        }    

    }
}
