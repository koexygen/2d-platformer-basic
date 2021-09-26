using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var transform1 = transform;
        var position = transform1.position;
        position = new Vector3(target.position.x, position.y, position.z);
        transform1.position = position;
    }
}