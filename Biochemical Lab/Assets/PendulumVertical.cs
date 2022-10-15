using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumVertical : MonoBehaviour
{
    Vector3 _start, _end;

    [SerializeField]
    [Range(0.0f, 360.0f)]
    private float _speed = 2.0f;

    [SerializeField]
    [Range(0.0f, 10.0f)]
    private float _startTime = 0.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
