using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {

	private Field field;
	private Gun   gun;

	// Use this for initialization
	void Start ()
	{
		field = GameObject.Find("Field").GetComponent<Field>();
		gun = GameObject.Find("Gun").GetComponent<Gun>();

		float field_width = field.GetWidth();
		float gun_pos_x = gun.transform.position.x;
		gun.SetMoveArea(gun_pos_x - field_width / 2, gun_pos_x + field_width / 2);
	}
	
	// Update is called once per frame
	void Update ()
	{	
	}
}
