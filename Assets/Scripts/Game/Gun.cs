using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public static float rotate_speed = 80.0f;

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		// rotating to pointer
		float rotation_angle = 0.0f;
		Vector3 rotation_axis = Vector3.right;
		transform.rotation.ToAngleAxis(out rotation_angle, out rotation_axis);

		float mouse_angle = Vector3.Angle (Input.mousePosition, Vector3.right);

		float diff_angle = Mathf.Abs(mouse_angle - rotation_angle);
		if (diff_angle > 3.0f)
		{
			Vector3 rotate_to;

			if (Input.mousePosition.z < rotation_angle) {
					rotate_to = Vector3.forward;
			} else {
					rotate_to = Vector3.back;
			}

			transform.Rotate (rotate_to, rotate_speed * Time.deltaTime);
		}
		else
		{
			// transform.rotation = Quaterion.AngleAxis
		}
	}
}
