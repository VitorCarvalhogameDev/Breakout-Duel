using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform headTransformAux;
    
    public HandMovement HandRightSpeed, HandLeftSpeed;

    public Rigidbody rb;

    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float mH = HandRightSpeed.handMoveSpeed + HandLeftSpeed.handMoveSpeed;
        transform.position += headTransformAux.forward * Time.deltaTime * mH;
    }
}
