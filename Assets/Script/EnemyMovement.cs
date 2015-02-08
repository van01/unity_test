using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public float m_fSpeed = 8.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;

		pos.y -= m_fSpeed * Time.deltaTime;

		transform.position = pos;
	}
}
