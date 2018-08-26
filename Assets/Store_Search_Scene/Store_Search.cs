using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store_Search : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Text>().text = PlayerPrefs.GetString("Store_Name");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
