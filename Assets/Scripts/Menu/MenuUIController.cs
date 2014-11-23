using UnityEngine;
using System.Collections;

public class MenuUIController : MonoBehaviour
{
	public void Play ()
	{
		Application.LoadLevel("Game");
	}
	
	public void Construct ()
	{
		Application.LoadLevel("Construct");
	}
}
