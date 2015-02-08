using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	private GameObject m_player;
	public float m_fAreaWidth = 2.0f;

	// Use this for initialization
	void Start () {
		m_player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 posCamera = transform.position;
		Vector3 posPlayer = m_player.transform.position;

		float fGap = posCamera.x - posPlayer.x;

		if (fGap < -m_fAreaWidth)
		{
			posCamera.x = posPlayer.x - m_fAreaWidth;
		}
		else if (fGap > m_fAreaWidth)
		{
			posCamera.x = posPlayer.x + m_fAreaWidth;
		}

		transform.position = posCamera;
	}
}
