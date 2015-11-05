using UnityEngine;
using System.Collections;

public class SimpleGun : MonoBehaviour {

	public float cooldown = 0.5f;
	float lastShot;

	public bool fireAtWill = true; 

	public float speed = 5f;

	public Transform bulletsSpawnHere;
	 
	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		lastShot = -cooldown;

		for (int j = 0; j < 20; j++){

			for (int i = 0; i < 20; i++){
				
				ShootAt(new Vector3(Mathf.Cos(0.1f*Mathf.PI*i),Mathf.Sin(0.1f*Mathf.PI*i),Mathf.Cos(0.1f*Mathf.PI*j)));
				
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

	}

	void ShootAt (Vector3 target) {
		GameObject bullet = (GameObject) Instantiate(bulletPrefab);
		bullet.transform.position = bulletsSpawnHere.position;
	
		Vector3 velocity = target - transform.position;
		velocity = velocity.normalized * speed;
		bullet.GetComponent<Rigidbody>().velocity = velocity;		
	}
}
