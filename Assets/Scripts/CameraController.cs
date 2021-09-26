using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ReSharper disable InconsistentNaming

public class CameraController : MonoBehaviour
{
    public Transform target, farBackground, midBackground;

    private Vector2 lastPos;

    public float minHeight, maxHeight;
    // Start is called before the first frame update
    void Start()
    {
        lastPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // camera follow
        var transform1 = transform;
        var position = transform1.position;
        var targetPos = target.position;
        position = new Vector3(targetPos.x, Mathf.Clamp(targetPos.y, minHeight, maxHeight), position.z);
        transform1.position = position;
        //parallax
        Vector2 amountToMove = new Vector2(position.x - lastPos.x, position.y - lastPos.y);

        farBackground.position += new Vector3(amountToMove.x, amountToMove.y, 0f);
        midBackground.position += new Vector3(amountToMove.x , amountToMove.y, 0f) * 0.5f;

        lastPos = position;
    }
}