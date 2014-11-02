using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update()
	{
		Vector3 relative_position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		float angle = Vector3.Angle (Vector3.right, relative_position);

		transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
	}
}
