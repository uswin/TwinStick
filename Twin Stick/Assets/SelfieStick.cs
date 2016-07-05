using UnityEngine;
using System.Collections;

public class SelfieStick : MonoBehaviour {

	public float panSpeed=1f;

	private GameObject myPlayer;
	private Vector3 armRotation;

	// Use this for initialization
	void Start () 
	{
		myPlayer = GameObject.FindGameObjectWithTag("Player");
		armRotation = this.transform.rotation.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () 
	{
		armRotation.y += Input.GetAxis("RHor")*panSpeed;
		armRotation.x += Input.GetAxis("RVer")*panSpeed;
		this.transform.position = myPlayer.transform.position;
		this.transform.rotation = Quaternion.Euler(armRotation);
	}
}
