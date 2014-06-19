using UnityEngine;
using System.Collections;

public class GameContext {
	private static GameContext	ms_Instance = null;

	public static GameContext	Instance()
	{
		if( ms_Instance == null )
		{
			ms_Instance = new GameContext();
		}
		return ms_Instance;
	}


	void Awake() {
		//DontDestroyOnLoad( this );
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Log( string msg )
	{
		Debug.Log( msg );
	}
}
