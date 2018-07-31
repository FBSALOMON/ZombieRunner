using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycle : MonoBehaviour {
    public float timeScale;
	
	// Update is called once per frame
	void Update () {
        float angleThisFrame = Time.deltaTime / 360 * timeScale;
        transform.RotateAround(transform.position, Vector3.forward, angleThisFrame);
	}
}
