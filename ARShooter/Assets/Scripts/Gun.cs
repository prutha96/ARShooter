using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public GameObject bulletPrefab;
	public Transform spawnPoint;
	public float bulletSpeed;

	void FixedUpdate () {

		if (Input.GetMouseButtonDown (0)) {

			GameObject go = Instantiate (bulletPrefab, spawnPoint.position, spawnPoint.rotation) as GameObject;
			go.GetComponent<Rigidbody> ().AddForce (transform.forward * bulletSpeed, ForceMode.VelocityChange);
		}
	}
}
