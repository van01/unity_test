using UnityEngine;
using System.Collections;

public class BackgroundLooper : MonoBehaviour {
	
	void OnTriggerEnter2D (Collider2D collider)
	{
		Vector2 size = ((BoxCollider2D)collider).size;
		Vector3 pos = collider.transform.position;
		Vector3 scale = collider.transform.localScale;

		float prevPos = pos.y;

		pos.y =  size.y * scale.y;

		collider.transform.position = pos;
	}
}
