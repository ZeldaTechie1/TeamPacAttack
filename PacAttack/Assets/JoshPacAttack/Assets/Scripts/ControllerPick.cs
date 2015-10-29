using UnityEngine;
using System.Collections;

public class ControllerPick : MonoBehaviour {
	private bool move1 = true;
	public float speed;
	public Camera cam;
	public float cameraDis;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position - cam.transform.position;
		transform.position = cam.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyUp (KeyCode.C)) {
			move1 = !move1;
		}

		if(move1 == true){
			transform.Translate (Input.GetAxis("Horizontal")* Time.deltaTime*speed, 0.0f,Input.GetAxis("Vertical")*Time.deltaTime * speed);

			if (Input.GetKeyUp (KeyCode.LeftArrow)) {
				transform.Rotate (0,-90,0);
				
			}
			if (Input.GetKeyUp (KeyCode.RightArrow)) {
				transform.Rotate (0,90,0);
				
			}
		}
		if (move1 == false) {
			cam.transform.position = transform.position + offset;
			transform.Translate (0.0f, 0.0f,Input.GetAxis("Vertical")*Time.deltaTime * speed);

			if (Input.GetKeyUp (KeyCode.LeftArrow)) {
				transform.Rotate (0,-90,0);
				cam.transform.Rotate (0,-90,0);
				
			}
			if (Input.GetKeyUp (KeyCode.RightArrow)) {
				transform.Rotate (0,90,0);
				cam.transform.Rotate(0,90,0);
				
			}
		}
	}
}
