using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp : MonoBehaviour
{
	
	
	[SerializeField]
	private Transform targetToFollow;
 

    // Update is called once per frame
    void Update()
    {
	    transform.position = new Vector3( transform.position.x,
		    Mathf.Clamp(targetToFollow.position.y,-0.62f,0.75f),
		                                  transform.position.z
	                                    );
    }
}
