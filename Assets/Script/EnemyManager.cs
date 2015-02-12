using UnityEngine;
using System.Collections;


public class EnemyManager : MonoBehaviour {

	private static string TAG_START_POSITION 	= "EnemyStartPosition";
	private static string TAG_SIDE_WALL	 		= "SideWall";
	private static string NAME_AREA_LEFT	 	= "MoveAreaLeft";

	private static EnemyManager m_instance;
	private GameObject m_startObject;

	public Rigidbody2D m_rigidbody;

	public float m_fBacWidth;
	private float m_fObjectMakeTime = 0.0f;


	public static EnemyManager Instance{
		get 
		{
			if (m_instance == null)
			{
				m_instance = new EnemyManager();
			}

			return m_instance;
		}
	}




	// Use this for initialization
	void Start () {
		m_startObject = GameObject.FindGameObjectWithTag (TAG_START_POSITION);
		m_fBacWidth = getAvailableAreaWidthForMakeObject ();


		makeEnemyObject ();
	}
	
	// Update is called once per frame
	void Update () {
		m_fObjectMakeTime += Time.deltaTime;

		if (m_fObjectMakeTime > 0.3f)
		{
			m_fObjectMakeTime = Time.deltaTime;
			makeEnemyObject();
		}
	}
	void makeEnemyObject ()
	{
		float fHalfWidth = m_fBacWidth / 2;
		Vector2 position = m_startObject.transform.position;
		position.x += Random.Range (-fHalfWidth, fHalfWidth);
		Rigidbody2D enemyClone = (Rigidbody2D)Instantiate (m_rigidbody, 
		                                                   position, 
		                                                   m_startObject.transform.rotation);
	}

//	float getScreegenSize()
	float getAvailableAreaWidthForMakeObject()
	{
		float width = 0.0f;
		/*
		Camera camera = Camera.main;
		size.x = camera.aspect * camera.orthographicSize;
		size.y = camera.orthographicSize;
*/
		GameObject []objects = GameObject.FindGameObjectsWithTag (TAG_SIDE_WALL);

		for (int i=0; i<objects.Length; i++)
		{
			if (objects[i].name == NAME_AREA_LEFT)
			{
				width = objects[i].transform.position.x*2;
				break;
			}
		}


		return width;
	}
}
