using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance = null;
	// Use this for initialization
	void Awake ()
	{
		Debug.Log("MusicPlayer Awake id = "+ GetInstanceID());
		GameObject.DontDestroyOnLoad(gameObject);
		if (instance == null) {
			instance = this;
		} else {
			Destroy(gameObject);
		}

	}

	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
