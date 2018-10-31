using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmSwingUtility : MonoBehaviour {
    public Transform ControllerToFollow;

    public Transform[] MovementDetectors;
    // Use this for initialization
    void Start()
    {

    }
    bool detectedFloor = false;
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(ControllerToFollow.position.x, ControllerToFollow.position.y, ControllerToFollow.position.z), Time.deltaTime * 5);
        transform.position = new Vector3(ControllerToFollow.position.x, transform.position.y, ControllerToFollow.position.z);
    }
}
