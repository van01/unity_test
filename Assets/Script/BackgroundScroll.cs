using UnityEngine;
using System.Collections;

public class BackgroundScroll : MonoBehaviour {

	public float m_fSpeed = 5.0f;

	void FixedUpdate()
	{
		Vector3 pos = transform.position;

		pos.y -= m_fSpeed * Time.deltaTime;

		transform.position = pos;
	}

}
