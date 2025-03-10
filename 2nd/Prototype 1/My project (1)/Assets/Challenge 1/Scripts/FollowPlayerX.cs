using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(30, 0, 10);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Set the camera position relative to the plane
        transform.position = plane.transform.position + offset;

        // Make the camera look at the plane
        //transform.LookAt(plane.transform.position);
    }
}
