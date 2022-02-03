using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;


public class TalkInteract : Interactable
{

    [SerializeField] public TextAsset inkFile;
    [SerializeField] public string nameChar;
    [SerializeField] public GameObject pc;
    


    public override void Interact(Character character)
    {
        if (inkFile != null)
        {
            GameManager.instance.dialogueManager.ParsingFile(inkFile, nameChar);
            GameManager.instance.dialogueManager.StartDialogue();
        }
        else if (pc != null)
        {
            GameManager.instance.comp_Sys.OnPCInteract(pc);

        }


    }
}
