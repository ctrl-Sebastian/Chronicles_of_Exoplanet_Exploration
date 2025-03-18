using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDrag : MonoBehaviour
{
    public Camera cam;
    private float camZDistance;
    private Collider col;

    public Vector2 point;

    public GameObject exoplanet;

    void Start()
    {
        camZDistance = cam.WorldToScreenPoint(transform.position).z;
        col = GetComponent<BoxCollider>();
    }

    void OnMouseDrag()
    {
        Vector3 screenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, camZDistance);
        Vector3 newWorldPos = cam.ScreenToWorldPoint(screenPos);
        transform.position = newWorldPos;
    }

    void OnMouseUp()
    {
        if (col.bounds.Contains(point))
        {
            Debug.Log("In bounds");
            exoplanet.SetActive(true);
            Destroy(this);
        }
    }
}
