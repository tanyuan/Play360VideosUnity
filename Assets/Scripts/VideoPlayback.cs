using UnityEngine;
using System.Collections;

public class VideoPlayback : MonoBehaviour
{
	public GameObject Sphere;

	void Start ()
	{
		MovieTexture video360 = (MovieTexture)Sphere.GetComponent<Renderer> ().material.mainTexture;
		video360.loop = true;
		video360.Play ();
	}

}
