using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootContainerInteract : Interactable
{
    public Item item;
    Inventory inventory;
    PSolving psolving;
    Notif_sys notif;
    Tracker tracker;
    Tracker.QuestTracker questTracker;
    public bool MS1 = false;
    public PSItem PSItem;
    public StoryScript storyScript;
    void Start()
    {
        inventory = GameManager.instance.inventory;
        psolving = GameManager.instance.psolving;
        notif = GameManager.instance.notif;
        tracker = GameManager.instance.tracker;
        storyScript = GameManager.instance.storyscript;

    }
    
    public override void Interact(Character character)
    {
 
        PickUp();
    }

    void PickUp()
    {
        if (item != null)
        {
            for (int i = 0; i < inventory.items.Count; i++)
            {
                if (inventory.items[i].id == item.id)
                {
                    Debug.Log("Barang " + item.name + " sudah diambil");
                }
                else
                {
                    Debug.Log("Ambil " + item.name);
                    inventory.Add(item);
                }
            }

            if (inventory.items.Count == 0)
            {
                notif.Show("Mengambil " + item.name);
                inventory.Add(item);
            }
        }
        else if (PSItem != null)
        {
            
            notif.Show("Problem Solving " + PSItem.title + " ditambakan. Tekan P untuk membuka menu Problem Solving");
            psolving.ParsingFile(PSItem);
            storyScript.MS1 = true;
            
            
        }
        
    }

}

