using UnityEngine;
using System.Collections;

public class CameraHeight : MonoBehaviour {

	public Camera cam1;
	public float camHeight;
	private Vector3 height;

	// Use this for initialization
	void Start () {
		height = new Vector3(0.0f, camHeight, 0.0f);
		cam1.transform.Translate (height);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
