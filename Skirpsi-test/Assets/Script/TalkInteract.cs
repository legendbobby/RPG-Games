using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;


public class TalkInteract : Interactable
{

    [SerializeField] public TextAsset inkFile;
    [SerializeField] public string nameChar;
    [SerializeField] public GameObject nama;
    

    public override void Interact(Character character)
    {
        Debug.Log("Mulai percakapan");
        GameManager.instance.dialogueManager.ParsingFile(inkFile,nameChar);
        GameManager.instance.dialogueManager.StartDialogue();
        
    }
}
