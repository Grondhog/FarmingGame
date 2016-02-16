using UnityEngine;
using System.Collections;

public class RotateGraphics : MonoBehaviour {

	private Vector3 direction = Vector3.zero;

	// Update is called once per frame
	void Update () 
	{
		if(!direction.Equals(Vector3.zero))
		{
			Quaternion rotation = Quaternion.LookRotation(direction);
			transform.rotation = rotation;
		}
	}

	public void SetDirection(Vector3 _direction)
	{
		direction = _direction;
	}
}
