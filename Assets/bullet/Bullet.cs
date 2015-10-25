using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// when a bullet collides with a missle
	void OnCollisionEnter(Collision col) {
		Destroy(this.gameObject);
		Destroy(col.gameObject);
	}
}
