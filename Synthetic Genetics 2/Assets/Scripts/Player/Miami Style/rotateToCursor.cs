using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateToCursor : MonoBehaviour {

    Vector3 mousePos;
    Camera cam;
    Rigidbody rid;
	// Use this for initialization
	void Start () {
        rid = GetComponent<Rigidbody>();
        cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
        rotateToCamera();
	}

    void rotateToCamera()
    {
        mousePos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y - cam.transform.position.y, Input.mousePosition.z));
        rid.transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2((mousePos.z - transform.position.z), (mousePos.x - transform.position.x)) * Mathf.Rad2Deg);
    }
}
