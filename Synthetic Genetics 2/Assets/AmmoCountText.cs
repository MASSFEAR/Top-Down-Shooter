using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCountText : MonoBehaviour {
    [SerializeField]
    private Text ammoCount;
    private GunBool gunbool;
    [SerializeField]
    private PistolGunController pistol;

	// Use this for initialization
	void Start () {
        gunbool = FindObjectOfType<GunBool>();
        
	}
	
	// Update is called once per frame
	void Update () {
		
        if(gunbool.m_Pistol == true)
        {
            ammoCount.text = pistol.cur_pistolAmmo.ToString();
        }
	}
}
