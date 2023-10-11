using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : Player
{
private int _doubleJump;
private void Awake()
{
    JumpForce = 5f;
    Force = 2f;
    _doubleJump = 0;
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

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Ground"))
            _doubleJump = 0;
    }
}
