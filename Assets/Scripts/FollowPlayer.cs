using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    private Transform _player;
    [SerializeField] private float _sensibility;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _player.position;

        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * _sensibility);
    }
}
