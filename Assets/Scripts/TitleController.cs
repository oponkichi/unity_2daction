using UnityEngine;
using System.Collections;

public class TitleController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameContext.Instance().Log( "Title Started" );
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Submit")) {
			GameContext.Instance().Log( "Submit Pressed" );
			Application.LoadLevel( "InGame" );
		}
	}
}
