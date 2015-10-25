using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

	public float hp = 100f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// when a missle collide with ship
	void OnTriggerEnter(Collider col) {
		hp = hp - 20f;
		if (hp <= 0) {
			Destroy(this.gameObject);
		}
	}
}
