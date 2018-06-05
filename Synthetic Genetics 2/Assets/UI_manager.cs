using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_manager : MonoBehaviour {
    [SerializeField]
    private GameObject m_pistolUI;
    [SerializeField]
    private GameObject m_galilUI;
    private GunBool gunbool;

	// Use this for initialization
	void Start () {
        m_pistolUI.SetActive(false);
        m_galilUI.SetActive(false);
        gunbool = FindObjectOfType<GunBool>();
	}
	
	// Update is called once per frame
	void Update () {
        if (gunbool.m_Pistol == true)
        {
            m_pistolUI.SetActive(true);
            
        }
        if(gunbool.m_SMG == true)
        {

            m_galilUI.SetActive(true);
            
        }
	}
}
