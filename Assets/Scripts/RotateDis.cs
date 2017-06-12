using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDis : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(-.5f, .5f, .25f);
	}
}
