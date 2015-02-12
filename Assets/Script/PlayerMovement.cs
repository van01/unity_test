using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public Animator m_anim;
	public float MOVE_SPEED = 4.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 position = transform.position;
		float fSpeed = 0.0f;
		int nAnimationFlag = 0;

		if (Input.GetKey (KeyCode.LeftArrow))
		{
			fSpeed = -MOVE_SPEED;
			nAnimationFlag = -1;
		}
		else if (Input.GetKey (KeyCode.RightArrow))
		{
			fSpeed = MOVE_SPEED;
			nAnimationFlag = 1;
		}

		position.x += (fSpeed * Time.deltaTime);
		transform.position = position;

		//animator
		m_anim.SetInteger ("MoveX", nAnimationFlag);
	}
}
