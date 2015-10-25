using UnityEngine;
using System.Collections;

public class GameStuff : MonoBehaviour {

	public int numberOfMissles = 10;
	public int radius = 10;
	public GameObject misslePrefab;
	public GameObject target;
	public float speed = 3f;

	public bool spawnOnStart = true;

	void Start () {
		if (spawnOnStart) {
			Spawn();
		}
	}

	void Spawn() {
		for (int i =0; i< numberOfMissles; i++) {
			GameObject missle = (GameObject) Instantiate(misslePrefab);
			missle.transform.position = new Vector3(
				-radius + (Random.value * 2 * radius),
				-radius + (Random.value * 2 * radius),
				-radius + (Random.value * 2 * radius)
			);

			Vector3 targetPos = target.transform.position;		
			Vector3 velocity = targetPos - missle.transform.position;
			velocity = velocity.normalized * speed;
			missle.GetComponent<Rigidbody>().velocity = velocity;

			missle.transform.LookAt(targetPos);
		}
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			Spawn();
		}
	}
}
