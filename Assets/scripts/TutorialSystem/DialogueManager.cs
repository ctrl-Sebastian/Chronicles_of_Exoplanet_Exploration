using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Image actorImage;
    public TextMeshProUGUI actorName;
    public TextMeshProUGUI messageText;
    public RectTransform backgroundBox;

    public static bool isActive = false;

    Message[] currentMessages;
    Actor[] currentActors;
    int activeMessage = 0;

    public GameObject thingsToHide;

    void OnAwake() {
        backgroundBox.gameObject.SetActive(false);
    }

    public void OpenDialogue(Message[] messages, Actor[] actors) {
        if (thingsToHide != null){
        thingsToHide.SetActive(false);

        }
        backgroundBox.gameObject.SetActive(true);
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0;
        isActive = true;
        Debug.Log("Started conversation");
        DisplayMessage();
    }

    void DisplayMessage() {
        Message messageToDisplay = currentMessages[activeMessage]; 
        messageText.text = messageToDisplay.message;

        Actor actorToDisplay = currentActors[messageToDisplay.actorId];
        actorName.text = actorToDisplay.name;
        actorImage.sprite = actorToDisplay.sprite;
    }

    public void NextMessage() {
        activeMessage++;
        if (activeMessage < currentMessages.Length) {
            DisplayMessage();
        } else {
            Debug.Log("End of conversation"); 
            isActive = false;
            backgroundBox.gameObject.SetActive(false);
            if (thingsToHide != null)
            {
            thingsToHide.SetActive(true);

            }
        }
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && isActive) {
            NextMessage();
        }
    }
}
