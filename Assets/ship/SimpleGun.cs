using UnityEngine;
using System.Collections;

public class SimpleGun : MonoBehaviour {

	public float cooldown = 0.5f;
	float lastShot;

	public float bulletSpeed = 5f;
	public uint remainingBullets = 50;	
	public Transform bulletsSpawnHere;
	 
	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		lastShot = -cooldown;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad > lastShot + cooldown) {
			lastShot = Time.timeSinceLevelLoad;
			
			UselessShotInRandomDirection();
		}
	}

	void ShootAt (Vector3 target) {
		if (remainingBullets > 0) {
			remainingBullets -= 1;

			GameObject bullet = (GameObject) Instantiate(bulletPrefab);
			bullet.transform.position = bulletsSpawnHere.position;
		
			Vector3 direction = target - transform.position;
			Vector3 velocity = direction.normalized * bulletSpeed;
			bullet.GetComponent<Rigidbody>().velocity = velocity;		
		}
	}


	void UselessShotInRandomDirection() {
		Vector3 randomPoint = Quaternion.Euler(Random.value * 360f, Random.value * 360f, Random.value * 360f) * Vector3.forward;
		ShootAt(randomPoint);
	}

}
