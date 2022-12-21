using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class VRMap
{
    public Transform vrTargert;
    public Transform rigTargert;
    public Vector3 trackingPositionOffset;
    public Vector3 trackingRotationOffset;

    public void Map()
    {
        rigTargert.SetPositionAndRotation
            (vrTargert.TransformPoint(trackingPositionOffset), vrTargert.rotation * Quaternion.Euler(trackingRotationOffset));
    }
}

public class VRRig : MonoBehaviour
{
    public VRMap head;
    public VRMap leftHand;
    public VRMap rightHand;

    public Transform headContraint;
    public Vector3 headBodyOffset;

    void Start()
    {
        headBodyOffset = transform.position - headContraint.position;
    }

    void Update()
    {
        transform.position = headContraint.position + headBodyOffset;
        transform.forward = Vector3.ProjectOnPlane(headContraint.up, Vector3.up).normalized;
        head.Map();
        leftHand.Map();
        rightHand.Map();
    }
}
