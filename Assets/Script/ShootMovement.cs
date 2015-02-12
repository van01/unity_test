using UnityEngine;
using System.Collections;

public class ShootMovement : MonoBehaviour {

	private Animator m_anim;
	public float MOVE_SPEED = -2.0f;
	public float m_fPower = 22.0f;

	// Use this for initialization
	void Start () {
		m_anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;

		pos.y -= MOVE_SPEED * Time.deltaTime;

		transform.position = pos;
	}

	public float getPower()
	{
		return m_fPower;
	}

	public void actionDestroy()
	{
		this.tag = "Untagged";
		m_anim.SetBool ("isDestroy", true);
		MOVE_SPEED = 0.1f;
	}

	public void destroy()
	{
		Destroy (this.gameObject);
	}

}
