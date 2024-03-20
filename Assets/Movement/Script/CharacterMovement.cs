using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1;
    private Vector3 _desiredDirection;
    [SerializeField]private float rotationSpeed=12;

    public float CurrentSpeed
    {
        get
        {
            return _desiredDirection.magnitude * speed;
        }
    }
    public void Move(Vector3 direction)
    {
        _desiredDirection = direction; 
    }
    private void Update()
    {
        transform.position += _desiredDirection * (speed * Time.deltaTime);
        float angle =Vector3.SignedAngle(transform.forward,_desiredDirection,transform.up);
        transform.Rotate(transform.up, angle* Time.deltaTime * rotationSpeed);
    }

    public float GetCurrentSpeed()
    {
        return _desiredDirection.magnitude * speed;
    }
}