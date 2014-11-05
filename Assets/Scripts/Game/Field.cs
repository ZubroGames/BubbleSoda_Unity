using UnityEngine;
using System.Collections;

public class Field : MonoBehaviour {

	public float cell_size = 1.0f;
	public int field_width = 11;


	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	public float GetWidth()
	{
		return cell_size * field_width;
	}
}
