using UnityEngine;
using System.Collections;

public class LooseCollider : MonoBehaviour {

	public LevelManager levelManager;

	void OnTriggerEnter2D (Collider2D collider)
	{
		Debug.Log("Trigger: Collider2D");
		levelManager.LoadLevel("Win Screen");

	}

	void OnCollisionEnter2D (Collision2D collision) {
		Debug.Log("Collision event: collision");
		print("Collision");
	}

}
