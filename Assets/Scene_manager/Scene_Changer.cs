using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scene_Changer : MonoBehaviour {
	
	public Text Store_name;
	
	public void AwakeToQR ()
	{
		Debug.Log("Awake to QR");
		Application.LoadLevelAsync(2);
	}
	public void AwakeToStoreSearch ()
	{
		PlayerPrefs.SetString("Store_Name", Store_name.text);
		Application.LoadLevelAsync(1);
		Debug.Log("Awake to Search");
	}
	public void Store_SearchToStore ()
	{
		Application.LoadLevelAsync(3);
	}
	public void StoreToAwake ()
	{
		Application.LoadLevelAsync(0);
	}

	public void StoreToMenu ()
	{
		Application.LoadLevelAsync(7);
	}

	public void StoreToARWaiter()
	{
		Application.LoadLevelAsync(4);
	}

	public void StoreToOrderList()
	{
		Application.LoadLevelAsync(5);
	}
	public void GotoStore ()
	{
		Application.LoadLevelAsync(3);
	}

	public void GotoFood ()
	{
		Application.LoadLevelAsync(6);
	}

}
