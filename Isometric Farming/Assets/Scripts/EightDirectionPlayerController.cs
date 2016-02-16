using UnityEngine;
using System.Collections;

public class EightDirectionPlayerController : MonoBehaviour {

	[SerializeField]
    private float speed = 5f;

    private RotateGraphics rg;
	
	
	void Start () {
		rg = GetComponentInChildren<RotateGraphics>();
		print(rg);
	}
	
	// Update is called once per frame
	void Update () {
		float xMov = Input.GetAxisRaw("Horizontal");
		float zMov = Input.GetAxisRaw("Vertical");
		Vector3 direction = new Vector3(xMov, 0, zMov);
		transform.Translate(direction * speed * Time.deltaTime);
		rg.SetDirection(direction);
		//transform.LookAt(direction);
	}
}
