using UnityEngine;
using System.Collections;

public class SphereMovement : MonoBehaviour {

	public float speed;



	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		//for movement
		transform.Translate (Input.GetAxis("Horizontal")* Time.deltaTime*speed, 0.0f,Input.GetAxis("Vertical")*Time.deltaTime * speed);


	}

	void TurnObject()
	{
		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			transform.Rotate (0,-90,0);
			
		}
		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			transform.Rotate (0,90,0);
			
		}
	}
}
