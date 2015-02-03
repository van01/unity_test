using UnityEngine;
using System.Collections;

public class ProjectDirector : MonoBehaviour {
	
	enum eSTATE {
		TITLE,
		INGAME
	};
	

	
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
