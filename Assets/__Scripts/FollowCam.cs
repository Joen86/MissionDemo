using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {

	static public FollowCam S;

	public bool ____________________________;
	public GameObject poi; 
	public float camZ;

	void Awake() {
				S = this;
				camZ = this.transform.position.z;
		}

	void update () {
				if (poi == null)
						return;
				Vector3 destination = poi.transform.position;
				destination.z = camZ;
				transform.position = destination;
		}
	
}
