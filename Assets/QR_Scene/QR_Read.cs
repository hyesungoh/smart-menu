﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ZXing;
using ZXing.QrCode;

public class QR_Read : MonoBehaviour {

	// Use this for initialization
	/*public void clickbutton()
	{
		SceneManager.LoadScene ("UI_MAIN");
	}*/

    private WebCamTexture camTexture;
    private Rect screenRect;
  
    void Start() {
      screenRect = new Rect(0, 0, Screen.width, Screen.height);
      camTexture = new WebCamTexture();
      camTexture.requestedHeight = Screen.height;
      camTexture.requestedWidth = Screen.width;
      if (camTexture != null) {
        camTexture.Play();
      }
    }

    // public void clickbutton() { 
    void OnGUI () {
      // drawing the camera on screen
      GUI.DrawTexture (screenRect, camTexture, ScaleMode.ScaleToFit);
      // do the reading — you might want to attempt to read less often than you draw on the screen for performance sake
      
      try {
        IBarcodeReader barcodeReader = new BarcodeReader ();
        // decode the current frame
        var result = barcodeReader.Decode(camTexture.GetPixels32(), camTexture.width , camTexture.height);
        if (result != null) {
          Debug.Log(result.Text);
          Application.LoadLevelAsync(3);
        }
      } catch(Exception ex) { Debug.LogWarning (ex.Message); }

    }
  //  }
}