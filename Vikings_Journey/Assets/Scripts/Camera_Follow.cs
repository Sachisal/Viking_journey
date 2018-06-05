using System.Collections;
using UnityEngine;

public class Camera_Follow : MonoBehaviour {

    public Transform target;

    // Float
    public float smoothSpeed = 0.125f;

	void LateUpdate () {

        transform.position = target.position;
	}
}
