using UnityEngine;
using System.Collections;

public class Main_Camera : MonoBehaviour {
	Transform target;
	float smooth;
	// Use this for initialization
	void Start () {
		smooth = 5;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position.z = target.position.z -distance;
		transform.position.y = target.position.y;
		transform.position.x = target.position.x;

		transform.position.x = Mathf.Lerp(transform.position.x,target.position.x,Time.deltaTime*smooth);
		transform.position.y = Mathf.Lerp(transform.position.y,target.position.y,Time.deltaTime*smooth);
	}
}
