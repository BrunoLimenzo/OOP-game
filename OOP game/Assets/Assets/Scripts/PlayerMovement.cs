using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Camera _camera;

    Animator _animator;
    float desiredRotationX;
    float desiredRotationY;
    bool isWalking;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        HandleMovement();

        desiredRotationX = Input.GetAxis("Horizontal");
        desiredRotationY = Input.GetAxis("Vertical");

        if(isWalking)
        HandleRotation();
    }

    void HandleMovement() //ABSTRACTION
    {
        var isWalking = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);
        this.isWalking = isWalking;
        _animator.SetBool("isWalking", isWalking);
    }

    void HandleRotation() //ABSTRACTION
    {
        var desiredAngle = Mathf.Atan2(desiredRotationX, desiredRotationY) * Mathf.Rad2Deg + _camera.transform.rotation.y;
        transform.rotation = Quaternion.Euler(0f, desiredAngle, 0f);
    }
}
