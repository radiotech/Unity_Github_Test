using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
	void Start () {

	}
	
	// Update is called once per frame


	void Update () {

		GameObject go = Instantiate(Resources.Load("Trail"), new Vector3(Input.mousePosition.x/100,Input.mousePosition.y/100,0), new Quaternion(0,0,0,0)) as GameObject;

		transform.Rotate ( new Vector3(.3f,.3f,.3f));

		//move to mouse;
	}
}
