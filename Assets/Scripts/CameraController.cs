using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ReSharper disable InconsistentNaming

public class CameraController : MonoBehaviour
{
    public Transform target, farBackground, midBackground;

    private float lastXpos;
    // Start is called before the first frame update
    void Start()
    {
        lastXpos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        // camera follow
        var transform1 = transform;
        var position = transform1.position;
        position = new Vector3(target.position.x, position.y, position.z);
        transform1.position = position;
        //parallax
        float amoutToMoveX = position.x - lastXpos;

        farBackground.position += new Vector3(amoutToMoveX, 0f, 0f);
        midBackground.position += new Vector3(amoutToMoveX * 0.5f, 0f, 0f);

        lastXpos = position.x;
    }
}