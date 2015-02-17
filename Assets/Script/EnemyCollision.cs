using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour {

	private Animator m_anim;
	public float m_fEnege = 100.0f;

	// Use this for initialization
	void Start () {
		m_anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	//	void OnCollisionEnter2D (Collision2D collision)
	void OnTriggerEnter2D (Collider2D collider)
	{
		Debug.Log ( "OnCollisionEnter2D : " + collider.gameObject.name + ", " + collider.gameObject.tag);
		if (collider.gameObject.tag == "PlayerShoot")
		{
			ShootMovement data = (ShootMovement)collider.gameObject.GetComponent(typeof(ShootMovement));

			m_fEnege -= data.getPower();

			if ( m_fEnege < 0)
			{
				EnemyMovement movement = GetComponent<EnemyMovement>();
				movement.m_fSpeed = 2.0f;

				m_anim.SetBool ("isDestroy", true);
				this.tag = "Untagged";
			}
			else
			{
				data.actionDestroy();
			}
		}
	}

	void OnDestroyEndAnimation()
	{
		Destroy (this.gameObject);
	}
}
