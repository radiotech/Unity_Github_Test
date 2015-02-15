using UnityEngine;
using System.Collections;

public class trail : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate ( new Vector3(1f,1f,1f));
		transform.localScale -= new Vector3(0.01F, .01F, .01F);

		if(transform.localScale.x < 0){
			transform.Translate ( new Vector3(30f,.3f,.3f));
		}

	}
}
