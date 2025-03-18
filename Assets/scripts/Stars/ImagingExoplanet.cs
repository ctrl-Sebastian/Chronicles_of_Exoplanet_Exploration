using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagingExoplanet : MonoBehaviour
{
    public GameObject found;
    public GameObject tutorialPanel;


    void Start()
    {
        found.SetActive(false);
 
    }
    void OnMouseDown()
    {
        Debug.Log("Clicked");
        tutorialPanel.SetActive(false);
        found.SetActive(true);
    }
}
