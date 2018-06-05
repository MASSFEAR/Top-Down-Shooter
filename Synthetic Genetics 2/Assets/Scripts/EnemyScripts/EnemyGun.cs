using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour {

    public Transform gunEnd;
    public GameObject bullet;
    Coroutine m_Shooting;

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            m_Shooting = StartCoroutine("Shooting");
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            StopCoroutine(m_Shooting);
        }
    }
	
	// Update is called once per frame
	IEnumerator Shooting()
    {
        
        while (true)
        {
            Instantiate(bullet, gunEnd.position, gunEnd.rotation);
            yield return new WaitForSeconds(.2f);
        }
    }
}
