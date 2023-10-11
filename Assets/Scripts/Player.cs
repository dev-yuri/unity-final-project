using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float _force;
    [SerializeField] private float _jumpForce;
    [SerializeField] GameObject _projectile;
    public float Force
    {
        get { return _force; }
        set { _force = value; }
    }
    public float JumpForce
    {
        get {return _jumpForce;}
        set {_jumpForce = value;}
    }
    private bool _grounded;
    private Transform _focalPoint;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _focalPoint = GameObject.Find("CameraRotator").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.Space))
            if (_grounded)
            {
                Jump();
                _grounded = false;
            }
    }

    //Abstraction
    
    //Only foward and backwards. the sideway movement is controlled by the camera angle
    public virtual void Move()
    {
        _rigidbody.AddForce(_focalPoint.forward * Input.GetAxis("Vertical") * _force);
    }
    public virtual void Jump()
    {
        _rigidbody.AddForce(_focalPoint.up * _jumpForce, ForceMode.Impulse);
    }

    public virtual void Shoot()
    {
        //shoot projectile
        Instantiate(_projectile, transform.position + _focalPoint.forward + Vector3.up, _projectile.transform.rotation);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
            _grounded = true;
    }
}
