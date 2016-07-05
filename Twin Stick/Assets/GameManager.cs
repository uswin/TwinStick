using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

	public bool isRecording=true;
	// Use this for initialization

	void Awake()
	{
//		PlayerPrefManagerScript.SetUnlockLevel(0);
//		PlayerPrefManagerScript.SetUnlockLevel(1);
//		PlayerPrefManagerScript.SetUnlockLevel(2);
//		PlayerPrefManagerScript.SetlockLevel(0);
//		PlayerPrefManagerScript.SetlockLevel(1);
//		PlayerPrefManagerScript.SetlockLevel(2);
	}

	void Start () 
	{
		print(PlayerPrefManagerScript.GetIsUnlockLevel(0));
		print(PlayerPrefManagerScript.GetIsUnlockLevel(1));
		print(PlayerPrefManagerScript.GetIsUnlockLevel(2));
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(CrossPlatformInputManager.GetButton("Fire1"))
		{			
			isRecording=false;
		}
		else
		{
			isRecording=true;
		}
	}
}
