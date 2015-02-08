using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float m_fSpeed = 10.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 position = transform.position;
		if (Input.GetKey (KeyCode.LeftArrow))
		{
			position.x -= (m_fSpeed * Time.deltaTime);
		}
		else if (Input.GetKey (KeyCode.RightArrow))
		{
			position.x += (m_fSpeed * Time.deltaTime);
		}

		transform.position = position;
		
	}
}
