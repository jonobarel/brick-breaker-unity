using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	//float mousePosInBlocks;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float mousePosInBlocks = Input.mousePosition.x/Screen.width*16;
		Vector3 paddlePos = new Vector3(Mathf.Clamp(mousePosInBlocks,0.5f,15.5f), gameObject.transform.position.y, gameObject.transform.position.z);
		gameObject.transform.position = paddlePos;
		Debug.Log("Paddle Position: "+paddlePos.ToString());
		Debug.Log("Mouse position: "+Input.mousePosition.x+", blocks: "+mousePosInBlocks);
		Debug.Log("Screen width: "+Screen.width);
	}
}
