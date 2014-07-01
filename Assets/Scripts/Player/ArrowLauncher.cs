using UnityEngine;
using System.Collections;

public class ArrowLauncher : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate()
	{
		if (m_HoldingArrow != null)
		{
			if( Input.touchCount == 0 )
			{
				Launch();
			}
			else
			{
			}
		}
		else
		{
			if( Input.touchCount > 0 )
			{
				Spawn();
			}
		}
	}

	// Update is called once per frame
	void Update () {
	
	}


	protected void Spawn()
	{
	}

	protected void Launch()
	{
	}

	GameObject		m_HoldingArrow;
}
