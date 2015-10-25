using UnityEngine;
using System.Collections;

public class SimpleGun : MonoBehaviour {

	float cooldown = 1.5f;
	float lastShot = 0f;

	public float speed = 5f;

	public GameObject spawnHere;

	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		lastShot = -cooldown;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)) {
			int radius = 10;
			ShootAt(
				new Vector3(
				-radius + (Random.value * 2 * radius),
				-radius + (Random.value * 2 * radius),
				-radius + (Random.value * 2 * radius)
				)
			);
		}
	}

	void ShootAt (Vector3 target) {
		GameObject bullet = (GameObject) Instantiate(bulletPrefab);
		bullet.transform.position = spawnHere.transform.position;
	
		Vector3 velocity = target - transform.position;
		velocity = velocity.normalized * speed;
		bullet.GetComponent<Rigidbody>().velocity = velocity;		
	}
	
}
