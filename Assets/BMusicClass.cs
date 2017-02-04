using UnityEngine;
using System.Collections;

public class BMusicClass : MonoBehaviour {
	public float fireRate;
	private double temp;
	private AudioSource audioSource;


	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		if (Time.time > temp+fireRate) {
			temp = Time.time;

			audioSource.Play ();
		}
	}
}

