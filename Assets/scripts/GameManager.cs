using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject transitCam;
    public GameObject imagingCam;
    public GameObject radialVelocityCam;

    public GameObject transitTitle;
    public GameObject imagingTitle;
    public GameObject radialVelocityTitle;

    

    public void GoBackTransit()
    {
        transitTitle.SetActive(true);
        transitCam.SetActive(false); 
        mainCam.SetActive(true);
    }

    public void GoBackImaging()
    {
        imagingTitle.SetActive(true);
        imagingCam.SetActive(false);
        mainCam.SetActive(true);
    }

    public void GoBackRadialVelocity()
    {
        radialVelocityTitle.SetActive(true);
        radialVelocityCam.SetActive(false);
        mainCam.SetActive(true);
    }
}
