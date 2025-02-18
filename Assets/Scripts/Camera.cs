﻿// Camera that always follow the player.
// Copyright Alexey Ptitsyn <alexey.ptitsyn@gmail.com>, 2023
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public float distance = 3.0f;

    private void OnDrawGizmos()
    {
        Common.ValidateObject<Transform>(target, "target");
    }

    private void Awake()
    {
        Common.ValidateObject<Transform>(target, "target", true);
    }

    void Update()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = target.position.z - distance;

        transform.position = new Vector3(x, y, z);
    }
}
