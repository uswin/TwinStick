using UnityEngine;
using System.Collections;

public class myReplay : MonoBehaviour 
{
	private const int bufferFrames=100;
	private myKeyframe[] mykeyframe = new myKeyframe[bufferFrames];
	private Rigidbody myRigidbody;

	// Use this for initialization
	void Start () 
	{
		myRigidbody = transform.GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () 
	{
		PlayBackReplay ();
	}

	void PlayBackReplay ()
	{
		myRigidbody.isKinematic = true;
		int frame = Time.frameCount % bufferFrames;
		print ("Writing Frame " + frame);
		transform.position = mykeyframe [frame].position;
		transform.rotation = mykeyframe [frame].rotation;
	}

	void Record ()
	{
		myRigidbody.isKinematic = false;
		int frame = Time.frameCount % bufferFrames;
		print ("Writing Frame " + frame);
		mykeyframe [frame] = new myKeyframe (Time.time, transform.position, transform.rotation);
	}
}

public class myKeyframe
{
	public float frameTime;
	public Vector3 position;
	public Quaternion rotation;

	public myKeyframe(float aTime, Vector3 aPosition, Quaternion aRotation)
	{
		frameTime = aTime;
		position = aPosition;
		rotation = aRotation;
	}
}
