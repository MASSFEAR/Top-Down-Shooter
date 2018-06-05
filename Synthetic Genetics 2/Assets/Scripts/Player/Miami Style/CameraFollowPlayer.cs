using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour {

    [SerializeField]
    GameObject player;
    bool followPlayer = true;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if(followPlayer == true)
        {
            camFollowPlayer();
        }
	}

    public void setFollowPlayer(bool val)
    {
        followPlayer = val;
    }

    void camFollowPlayer()
    {
        Vector3 newPos = new Vector3(player.transform.position.x, player.transform.position.y + 50f, player.transform.position.z);

        this.transform.position = newPos;
    }
}
