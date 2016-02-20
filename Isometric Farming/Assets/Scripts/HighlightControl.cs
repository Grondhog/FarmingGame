using UnityEngine;
using System.Collections;

public class HighlightControl : MonoBehaviour {

	[SerializeField]
	private GameObject highlight;

	// Use this for initialization
	void Start () {
		highlight = Instantiate(highlight, new Vector3(transform.position.x, 0, transform.position.z), Quaternion.identity) as GameObject;
		highlight.transform.parent = this.transform;
		highlight.transform.position = new Vector3( Mathf.Floor(transform.position.x), 0, Mathf.Floor(transform.position.z));
	}
	
	// Update is called once per frame
	void Update () {
		highlight.transform.position = new Vector3( Mathf.Floor(transform.position.x + transform.forward.x + .5f), 0, Mathf.Floor(transform.position.z + transform.forward.z));
		if(transform.rotation.y % 90 != 0)
		{
			highlight.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
		}
	}
}
