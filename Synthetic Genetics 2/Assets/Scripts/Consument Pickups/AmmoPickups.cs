using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickups : MonoBehaviour {

    private GunBool gunbool;
    [SerializeField]
    private PistolGunController pistol;

    
    void Start () {
        gunbool = FindObjectOfType<GunBool>();
        
	}
	
	
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "Player")
        {
            if(gunbool.m_Pistol == true)
            {
                pistol.cur_pistolAmmo += 20;
            }
            Destroy(gameObject);
            
        }
    }
}
