using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Logo : MonoBehaviour {

	public float Speed_Spin = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.localEulerAngles = new Vector3(gameObject.transform.localEulerAngles.x,
		gameObject.transform.localEulerAngles.y,
		gameObject.transform.localEulerAngles.z - Speed_Spin);
	}
}
