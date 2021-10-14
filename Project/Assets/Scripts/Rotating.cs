using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour
{
    
    private float _rotateInp;

    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        _rotateInp = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * rotateSpeed * _rotateInp * Time.deltaTime);
    }
}
