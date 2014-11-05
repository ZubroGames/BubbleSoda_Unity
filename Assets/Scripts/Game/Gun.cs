using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public float move_speed    = 20.0f;
	public float rotate_speed  = 180.0f;
	public float max_angle     = 45.0f;

	private float left_border  = 0.0f;
	private float right_border = 0.0f;

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update()
	{	
		float horizontal_force = Input.GetAxis("Horizontal");
		if (horizontal_force != 0)
		{
			Move(horizontal_force);
		}

		float rotation_force = - Input.GetAxis("Z Axis");
		if (rotation_force != 0)
		{
			Rotate(rotation_force);
		}
	}

	// 
	public void SetMoveArea(float left, float right)
	{
		SpriteRenderer rend = gameObject.GetComponent<SpriteRenderer>();
		float width = rend.bounds.size.x;
		left_border = left - width / 2;
		right_border = right + width / 2; 
	}

	void Move(float force)
	{
		// calc
		Vector3 movement = Vector3.right * force * move_speed * Time.deltaTime;
		// move
		transform.Translate(movement, Space.World);
		// check borders
		if (transform.position.x < left_border || transform.position.x > right_border)
		{
			// back
			transform.Translate(-movement, Space.World);
		}
	}

	void Rotate(float force)
	{
		// calc
		float rotation = force * rotate_speed * Time.deltaTime;
		// rotate
		transform.Rotate(0, 0, rotation);
		// check limits
		if (transform.eulerAngles.z > max_angle && transform.eulerAngles.z < 360 - max_angle)
		{
			// back
			transform.Rotate(0, 0, -rotation);
		}
	}
}
