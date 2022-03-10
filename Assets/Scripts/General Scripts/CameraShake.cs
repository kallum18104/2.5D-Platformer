using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

	public Transform camTransform; //the location of the camera
	public static float shakeDuration = 0f; //how long the shake lasts for
	public float shakeAmount = 0.7f; //how heavy the shake is
	public float decreaseFactor = 1.0f; //transition between the shake and normal camera position
    Vector3 originalPos; //the cams position BEFORE any shake is applied

	void Awake()
	{
		if (camTransform == null) //if there is no set transform for the camTransform, it will enter this and set the cameras transform position.
		{
			camTransform = GetComponent(typeof(Transform)) as Transform;
		}
	}

	void OnEnable()
	{
		originalPos = camTransform.localPosition; //sets the originalPos as where the cam is before any shake.
	}

	void Update()
	{
		if (shakeDuration > 0) //if the shake duration is above 1, it will enter this
		{
			camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount; //this puts the cameras position to the original position, then adds a position modifier that moves the camtransform to be between the shake amounts axis'

			shakeDuration -= Time.deltaTime * decreaseFactor; //shake duration's time left decreases every single frame.
		}
		else
		{
			shakeDuration = 0f; 
			camTransform.localPosition = originalPos;

			//if the shake duration is 0, then this sets it to 0 (just to be sure) and makes the cameras position as the original position.
		}
	}
}