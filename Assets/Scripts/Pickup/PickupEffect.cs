﻿using UnityEngine;
using System.Collections;

public class PickupEffect : MonoBehaviour
{
	void Update ()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * 50);
    }
}
