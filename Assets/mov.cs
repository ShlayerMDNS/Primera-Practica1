using UnityEngine;
using System.Collections;

public class mov : MonoBehaviour {
	// ints aqui
	private Rigidbody rb;
	public GameObject disparo;
	public Transform Spawner;
	public int vel;
	private double temp;
	public float fireRate;
	private AudioSource audioSource;


	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody> ();
		temp = Time.time;

	

	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		rb.velocity = new Vector3 (moveHorizontal * vel, 0, moveVertical * vel);
		if (Input.GetButton ("Fire1") && Time.time > temp+fireRate) {
			temp = Time.time;
			Instantiate (disparo, Spawner.position, Spawner.rotation);
			audioSource = GetComponent<AudioSource> ();
			audioSource.Play ();
		}


		}
	}

