using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

	public float missleDamage = 20f;
	public float hp = 100f;
	public ParticleSystem particleSystem;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// when a missle collide with ship
	void OnTriggerEnter(Collider col) {
		hp = hp - missleDamage;
		particleSystem.Emit (3);
		if (hp <= 0) {
			Destroy(this.gameObject);
			particleSystem.Emit(300);
		}
	}
}
