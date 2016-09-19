using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float smoothing = 5f;

	Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - target.position;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 targetComPos = target.position + offset;

		transform.position = Vector3.Lerp (transform.position, targetComPos, smoothing * Time.deltaTime);
	}
}
