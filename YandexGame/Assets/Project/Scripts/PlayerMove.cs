using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private bool firstPlayer;
    private Rigidbody2D _playerRb;
    private readonly float _speed = 5f;
    [SerializeField] private Joystick joystick;


    private void Awake()
    {
        _playerRb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Init.Instance.mobile == false)
        {
            if (firstPlayer == true)
                _playerRb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized * _speed;
            else if (firstPlayer == false && gameManager.onePlayer == false)
                _playerRb.velocity = new Vector2(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2")).normalized * _speed;
        }
        else
            _playerRb.velocity = new Vector2(joystick.Horizontal, joystick.Vertical).normalized * _speed;
        
    }
}