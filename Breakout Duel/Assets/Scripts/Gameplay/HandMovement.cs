using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMovement : MonoBehaviour
{
    public float handMoveSpeed;

    private float velocity;
    Vector3 previous;

    private void FixedUpdate()
    {
        velocity = ((transform.position.y - previous.y)) / Time.deltaTime;
        previous = transform.position;
        Debug.Log("Hand Velocity = " + Mathf.Abs(velocity).ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (handMoveSpeed >= 0.0f)
            handMoveSpeed -= Time.deltaTime;

        StartCheckingVelocity();
    }

    public void StartCheckingVelocity()
    {
       
        Collider[] cols = Physics.OverlapSphere(transform.position, 0.05f);
        foreach (Collider col in cols)
        {
            if (col.name == "Sphere")
            {
                col.enabled = false;
                handMoveSpeed = Mathf.Abs(velocity);
            }
        }
    }
}
