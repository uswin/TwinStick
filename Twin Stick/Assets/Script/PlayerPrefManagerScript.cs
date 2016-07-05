using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerPrefManagerScript : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume_key";
	const string LEVEL_UNLOCKED_KEY = "level_unlocked_key_";
	const string DIFFICULTY_KEY = "difficulty_key";
		
	public static void SetMasterVolume(float volume)
	{
		if(volume >= 0f && volume <=1f)
		{
			PlayerPrefs.SetFloat(MASTER_VOLUME_KEY,volume);
		}
		else
		{
			Debug.LogError("Master Volum Out of Range!");
		}
	}
	
	public static float GetMasterVolume()
	{
		return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
	}
	
	
	public static void SetUnlockLevel(int level)
	{
		if(level <=SceneManager.sceneCountInBuildSettings-1)
		{
			PlayerPrefs.SetInt(LEVEL_UNLOCKED_KEY+level.ToString(),1); //use 1 for true
		}
		else
		{
			Debug.LogError("Trying to unlock level Out of Range/not in build setting");
		}
	}

	public static void SetlockLevel(int level)
	{
		if(level <=SceneManager.sceneCountInBuildSettings-1)
		{
			PlayerPrefs.SetInt(LEVEL_UNLOCKED_KEY+level.ToString(),0); //use 0 for lock
		}
		else
		{
			Debug.LogError("Trying to unlock level Out of Range/not in build setting");
		}
	}

	public static bool GetIsUnlockLevel(int level)
	{
		if(level <=SceneManager.sceneCountInBuildSettings-1)
		{
			if (PlayerPrefs.GetInt(LEVEL_UNLOCKED_KEY+level.ToString()) ==1)
			{return true;}
			else
			{return false;}
			
		}
		else
		{
			Debug.LogError("Trying to query level Out of Range/not in build setting");
			return false;
		}
	}
	
		
	public static void SetDifficulty(float difficulty)
	{
		if(difficulty >= 0f && difficulty <=3f)
		{
			PlayerPrefs.SetFloat(DIFFICULTY_KEY,difficulty);
		}
		else
		{
			Debug.LogError("Trying to set difficulty level that out of Range!");
		}
	}
	
	public static float GetDifficulty()
	{
		return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
	}
}
