using UnityEngine;
using System.Collections;

public class WebCamStream : MonoBehaviour {

	public GameObject sphere;
	public int cameraNumber = 0;

	private WebCamTexture webCamTexture;
	private WebCamDevice webCamDevice;
	
	void Start() 
	{
		// Checks how many and which cameras are available on the device
		for (int cameraIndex = 0; cameraIndex < WebCamTexture.devices.Length; cameraIndex++) {
			Debug.Log ("WebCamDevice " + cameraIndex + " name " + WebCamTexture.devices [cameraIndex].name);
		}

		if (WebCamTexture.devices.Length > cameraNumber) {
            webCamDevice = WebCamTexture.devices [cameraNumber];
			webCamTexture = new WebCamTexture(webCamDevice.name, 1280, 720);
			sphere.GetComponent<Renderer>().material.mainTexture = webCamTexture;
			webCamTexture.Play();
		} else {
			Debug.Log("no camera");
		}
	}
}
