using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {
	
	static public FollowCam S;

	public float easing = 0.05f;
	public Vector2 minXY;
	public bool ____________________________;
	public GameObject poi; 
	public float camZ;
	
	void Awake() {
		S = this;
		camZ = this.transform.position.z;
	}
	
<<<<<<< HEAD
	void FixedUpdate() {
		Vector3 destination;
		// If there is no poi, return to P:[0,0,0]
		if (poi == null) {
			destination = Vector3.zero;
		} else {
			// Get the position of the poi
			destination = poi.transform.position;
			// If poi is a Projectile, check to see if it's at reast
			if (poi.tag == "Projectile") {
				// if it is sleeping (that is, not moving)
				if ( poi.rigidbody.IsSleeping() ) {
					// return to default view
					poi = null;
					// in the next update
					return;
				}
			}
		}
		
		
		// Limit the X & Y to minimum values
=======
	void Update () {
		if (poi == null)
			return;
		Vector3 destination = poi.transform.position;
>>>>>>> origin/master
		destination.x = Mathf.Max (minXY.x, destination.x);
		destination.y = Mathf.Max (minXY.y, destination.y);
		// Interpolate from the current Camera position toward destination
		destination = Vector3.Lerp (transform.position, destination, easing);
		// Retain a destination.z of camZ
		destination.z = camZ;
		// Set the camera to the destination
		transform.position = destination;
		// Set the orthographicSize of the Camera to keep Ground in view
		this.camera.orthographicSize = destination.y + 10;
<<<<<<< HEAD
	}
	
	

=======
	
		//Vector3 destination;
				if (poi == null) {
						destination = Vector3.zero;
				} else { 
						destination = poi.transform.position;
						if (poi.tag == "Projectile") {
								if (poi.rigidbody.IsSleeping ()) {
										poi = null;
										return;
								}
						}
				}
		//this.camera.orthographicSize = destination.y + 10;
		}
>>>>>>> origin/master
	
}
