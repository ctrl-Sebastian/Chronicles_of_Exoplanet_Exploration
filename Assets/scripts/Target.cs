using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    [SerializeField] private GameObject MainCam;

    [SerializeField] private GameObject focusCam;

    [SerializeField] private GameObject StarMenu;
    [SerializeField] private GameObject Title;

    private DialogueManager dialogueManager;

    void Start()
    {
        dialogueManager = FindObjectOfType<DialogueManager>();
        MainCam = GameObject.Find("MainCam");
        focusCam.SetActive(false);
        StarMenu.SetActive(false);
        Title.SetActive(true);
    }

    public void GoToDirectImaging()
    {
        SceneManager.LoadScene("DirectImaging");
    }

    public void GoToTransit()
    {
        SceneManager.LoadScene("Transit");
    }

    public void GoToRadialVelocity()
    {
        SceneManager.LoadScene("RadialVelocity");
    }   

    void OnMouseDown()
    {
        if(dialogueManager != null && !DialogueManager.isActive)
        {
            MainCam.SetActive(false);
            focusCam.SetActive(true);
            StarMenu.SetActive(true);
            Title.SetActive(false);
        }
    }

}
