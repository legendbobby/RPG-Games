using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    public GameObject player;
    public DialogueSystem dialogueSystem;
    public DialogueManager dialogueManager;
    public Inventory inventory;
    public Photo photo;
    public StoryScript storyscript;
    public PSolving psolving;
    public Notif_sys notif;
   


}
