using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exoplanet : MonoBehaviour
{
    public Transform star;

    void Update()
    {
        transform.RotateAround(star.position, Vector3.up, 40 * Time.deltaTime);
    }
}
