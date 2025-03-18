using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueManager dialogueManager;
    public Dialogue[] dialogues;
    public void StartDialogue(int i) {
        dialogueManager.OpenDialogue(dialogues[i].messages, dialogues[i].actors);
    }

}


[System.Serializable]
public class Message {
    public int actorId;
    public string message;
}


[System.Serializable]
public class Actor {
    public string name;
    public Sprite sprite;
}

[System.Serializable]
public class Dialogue{
    public Message[] messages;
    public Actor[] actors;
}