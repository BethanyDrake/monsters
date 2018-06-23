using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody>().velocity = new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
		
	}
}
