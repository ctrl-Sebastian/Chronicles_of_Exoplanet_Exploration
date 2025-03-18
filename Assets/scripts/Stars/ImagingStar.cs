using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagingStar : MonoBehaviour
{

    void Update()
    {
        if (!gameObject.GetComponent<Renderer>().isVisible) {
            Debug.Log("Invisible");
        }
    }

    void OnBecameInvisible() {
        Debug.Log("Became Invisible");
    }
}
