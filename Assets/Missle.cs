using UnityEngine;
using System.Collections;

public class Missle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider col) {
//		Debug.Log("kaboom!");
		Destroy(this.gameObject);
	}
}

