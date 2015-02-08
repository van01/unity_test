using UnityEngine;
using System.Collections;

public class ProjectDirector : MonoBehaviour {

	private static ProjectDirector m_instance;
	
	enum eSTATE {
		TITLE,
		INGAME
	};

	public static ProjectDirector Instnace {
		get {
			if (m_instance == null)
			{
				m_instance = new ProjectDirector();
			}
			return m_instance;
		}
	}

	ProjectDirector()
	{
	
	}

	
	// Use this for initialization
	void Start () {
		setState (eSTATE.INGAME);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void setState (eSTATE eState)
	{
		switch (eState) 
		{
		case eSTATE.INGAME:
			//change to ingame scene
			break;
		}
	}
}
