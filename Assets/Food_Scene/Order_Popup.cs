using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order_Popup : MonoBehaviour {

	public GameObject PopUp_Parents;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Ordered ()
	{
		PopUp_Parents.active = true;
	}
}
