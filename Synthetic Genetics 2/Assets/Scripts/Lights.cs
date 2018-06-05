using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour {
    [SerializeField]private GameObject Arealight;
	// Use this for initialization
	void Start () {
        Arealight.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.name == "Player")
        {
            Arealight.SetActive(true);
        }
    }
}
