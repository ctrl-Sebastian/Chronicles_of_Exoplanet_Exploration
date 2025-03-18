using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public DialogueTrigger dialogueTrigger;

    void Start() {
        dialogueTrigger.StartDialogue(0);
    }
}
