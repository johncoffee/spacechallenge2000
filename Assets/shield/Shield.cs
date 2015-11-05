using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour {

	public float missleDamage = 25f;
	public float shieldHp = 100f;
	float maxHp;

	// Use this for initialization
	void Start () {
		maxHp = shieldHp;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	// when a missle collide with ship
	void OnTriggerEnter(Collider col) {
		shieldHp = shieldHp - missleDamage;
		if ((int)shieldHp <= 0) {
			Destroy(this.gameObject);
		}

		Material shieldMaterial = this.gameObject.GetComponent<Renderer>().material;
		Color color = shieldMaterial.color;
		float a = shieldHp / maxHp;
		color.a = a;
		Debug.Log (a);
		shieldMaterial.color = color;
	}
}
