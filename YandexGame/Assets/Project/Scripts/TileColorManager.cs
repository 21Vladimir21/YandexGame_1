using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileColorManager : MonoBehaviour
{
    [SerializeField] private Color color;
    public SpriteRenderer square;

    public bool imСolored = false;
    public bool imFree = true;

    private void Awake()
    {
        square = gameObject.GetComponent<SpriteRenderer>();
        square.sprite = null;
    }

    private void OnDisable()
    {
        square.sprite = null;
        imСolored = false;
        imFree = true;
    }

    public void SwithcColorType(bool value)
    {
        imСolored = value;
        imFree = false;
    }
}