using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemaze : MonoBehaviour {
	public Transform heroObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w")){
			GetComponent<Rigidbody2D>().velocity = new Vector2(0,-20);
			heroObj.transform.eulerAngles = new Vector3 (0,0,90);
		} else{
			if (Input.GetKey("s")){
				GetComponent<Rigidbody2D>().velocity = new Vector2(0,20);
				heroObj.transform.eulerAngles = new Vector3 (0,0,-90);
			} else {
				if (Input.GetKey("a")){
					GetComponent<Rigidbody2D>().velocity = new Vector2(20,0);
					heroObj.transform.eulerAngles = new Vector3 (0,180,0);
				} else {
					if (Input.GetKey("d")){
						GetComponent<Rigidbody2D>().velocity = new Vector2(-20,0);
						heroObj.transform.eulerAngles = new Vector3 (0,0,0);
					}
					else{
						GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
					}
				}
			}
		}
	}
}
