using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generar : MonoBehaviour {
	public float fireRate;
	private double temp;
	public GameObject asteroide;
	public Transform Spawner;
	private Vector3 rabo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > temp+fireRate) {
			rabo = new Vector3 (Random.Range(-5,8), Spawner.position.y, Spawner.position.z);
			temp = Time.time;
			Instantiate (asteroide, Spawner.position, Spawner.rotation);
	}
}
}
