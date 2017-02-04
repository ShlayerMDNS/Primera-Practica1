using UnityEngine;
using System.Collections;

public class desp : MonoBehaviour {
	public int vel;
	private Rigidbody rb;
	public float lifetime;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.forward * vel;
		Destroy (gameObject,lifetime);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
