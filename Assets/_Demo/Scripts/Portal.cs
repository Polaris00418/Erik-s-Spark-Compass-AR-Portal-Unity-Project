using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {

	[Header("Cameras")]
	public Camera portalCam;


	void Update () {

		// Move portal camera position based on main camera distance from the portal.
		Vector3 cameraOffset = Camera.main.transform.position - transform.position;
		portalCam.transform.position = transform.position + cameraOffset;

		// Make portal cam face the same direction as the main camera.
		portalCam.transform.rotation = Quaternion.LookRotation(Camera.main.transform.forward, Vector3.up);
	}

	void OnTriggerEnter (Collider other) {
		if (other.CompareTag ("MainCamera")) {

			// Use xor operator to toggle the ARWorld layer in the mainCam's culling mask.
			Camera.main.cullingMask ^= 1 << LayerMask.NameToLayer("ARWorld");

		}
	}
}