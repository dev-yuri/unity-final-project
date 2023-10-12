using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : Player
{
private int _doubleJump;
private GameObject _object;
private Transform _focalPoint;
private void Awake()
{
    JumpForce = 5f;
    Force = 2f;
    _doubleJump = 0;
    _focalPoint = GameObject.Find("CameraRotator").GetComponent<Transform>();
}
// Update is called once per frame
    void Update()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.Space))
            Jump();

        if (Input.GetKeyDown(KeyCode.LeftAlt))
            Shoot(); 

    }

    public override void Jump()
    {
        if(_doubleJump < 2)
        {
            base.Jump();
            _doubleJump++;
        }
    }

    public override void Shoot()
    {
        _object = Instantiate(Projectile, transform.position + _focalPoint.forward + Vector3.up, Projectile.transform.rotation);
        _object.tag = "Fire Projectile";        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Ground"))
            _doubleJump = 0;
    }
}
