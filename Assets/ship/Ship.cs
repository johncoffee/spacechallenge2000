using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

	public float hp = 100f;
	public GameObject model;
	public ParticleSystem particleSystem;

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
			particleSystem.Emit(300);
		}
	}
}
