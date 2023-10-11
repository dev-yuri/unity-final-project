using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody rigidbody;
    private Transform _focalPoint;
    // Start is called before the first frame update
    void Start()
    {
        _focalPoint = GameObject.Find("CameraRotator").GetComponent<Transform>();
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(_focalPoint.forward * 10, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
