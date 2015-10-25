using UnityEngine;
using System.Collections;

public class SimpleGun : MonoBehaviour {

	float cooldown = 1.5f;
	float lastShot = 0f;

	public bool fireAtWill = true; 

	public float speed = 5f;

	public GameObject spawnHere;

	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		lastShot = -cooldown;
	}
	
	// Update is called once per frame
	void Update () {

		if (fireAtWill && Time.timeSinceLevelLoad > lastShot + cooldown) {
			lastShot = Time.timeSinceLevelLoad;

			DebugShotInRandomDirection();
		}

		if (Input.GetKey(KeyCode.A)) {
			DebugShotInRandomDirection();
		}
	}

	void ShootAt (Vector3 target) {
		GameObject bullet = (GameObject) Instantiate(bulletPrefab);
		bullet.transform.position = spawnHere.transform.position;
	
		Vector3 velocity = target - transform.position;
		velocity = velocity.normalized * speed;
		bullet.GetComponent<Rigidbody>().velocity = velocity;		
	}



	
	// this is a usefull method that demonstrates a shot
	void DebugShotInRandomDirection() {
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
