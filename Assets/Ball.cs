using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public Paddle paddle;
	private Vector3 paddleToBallVector;
	private bool isLaunched;

	// Use this for initialization
	void Start () {
		isLaunched = false;
		paddleToBallVector = gameObject.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!isLaunched) {
			gameObject.transform.position = paddle.transform.position + paddleToBallVector;
		}

		if (Input.GetMouseButtonDown (0)) {
			isLaunched = true;
			gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 10f);
		}
	}
}
