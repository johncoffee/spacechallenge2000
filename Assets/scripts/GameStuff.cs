using UnityEngine;
using System.Collections;

public class GameStuff : MonoBehaviour {

	public int number = 10;
	public int radius = 10;
	public GameObject misslePrefab;
	public GameObject target;
	public float speed = 3f;

	void Start () {
//		Spawn();
	}

	void Spawn() {
		for (int i =0; i< number; i++) {
			GameObject missle = (GameObject) Instantiate(misslePrefab);
			missle.transform.position = new Vector3(
				-radius + (Random.value * 2 * radius),
				-radius + (Random.value * 2 * radius),
				-radius + (Random.value * 2 * radius)
			);

			Vector3 targetPos = target.transform.position;		
			Vector3 velocity = targetPos - missle.transform.position;
			velocity = velocity.normalized * speed;
			Debug.Log (velocity);
			missle.GetComponent<Rigidbody>().velocity = velocity;

		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			Spawn();
		}
	}
}
