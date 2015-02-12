using UnityEngine;
using System.Collections;

public class PlayerShooter : MonoBehaviour {

	public float DELAY_TIME = 0.2f;
	private float m_fTime = 0;
	public Rigidbody2D m_rigidbody;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		m_fTime += Time.deltaTime;

		if (DELAY_TIME < m_fTime)
		{
			m_fTime = 0.0f;
			Vector2 position = transform.position;
			position.y += 0.55f;
			Rigidbody2D shoot = (Rigidbody2D)Instantiate (m_rigidbody, 
			                                                   position, 
			                                                   transform.rotation);
		}
	}
}
