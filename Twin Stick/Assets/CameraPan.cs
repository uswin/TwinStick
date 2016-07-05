using UnityEngine;
using System.Collections;

public class CameraPan : MonoBehaviour {

	public Transform myTarget;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void LateUpdate()
	{
		if(myTarget.tag=="Player")
		{
			this.transform.LookAt(myTarget);
		}
	}
}
