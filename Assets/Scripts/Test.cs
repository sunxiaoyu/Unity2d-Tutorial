using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	
	public Rigidbody2D test;		
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		print ("Update");
	}

	// Update is called once per frame
	void FixedUpdate () {
		print ("FixedUpdate");
	}
}
