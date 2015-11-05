using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

	public float missleDamage = 20f;
	public float shieldHp = 100f;
	public ParticleSystem damageEffects = null;

	// Use this for initialization
	void Start () {
		if (damageEffects == null) {
			Debug.LogWarning("Remember to set a ParticleSystem on damageEffects");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// when a missle collide with ship
	void OnTriggerEnter(Collider col) {
		shieldHp = shieldHp - missleDamage;
		damageEffects.Emit (3);
		if (shieldHp <= 0) {
			Destroy(this.gameObject);
			damageEffects.Emit(300);
		}
	}
}
