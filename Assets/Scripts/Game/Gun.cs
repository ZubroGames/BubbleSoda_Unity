using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public float move_speed = 10.0f;

	private float left_border = 0.0f;
	private float right_border = 0.0f;

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update()
	{	
		// mouse
		Vector3 relative_mouse_position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, - Camera.main.transform.position.z));
		Vector3 relative_position = relative_mouse_position - transform.position;
		float angle = Vector3.Angle (Vector3.right, relative_position);

		transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

		// keyboard
		if (Input.GetKey(KeyCode.A))
		{
			Move(Vector3.left);
		}
		if (Input.GetKey(KeyCode.D))
		{
			Move(Vector3.right);
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

	void Move(Vector3 direction)
	{
		// move
		transform.Translate(direction * move_speed * Time.deltaTime, Space.World);

		// check borders
		if (transform.position.x < left_border || transform.position.x > right_border)
		{
			// back
			transform.Translate(-direction * move_speed * Time.deltaTime, Space.World);
		}
	}
}
