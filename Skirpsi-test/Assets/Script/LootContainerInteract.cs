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

    public PSItem PSItem;
    void Start()
    {
        inventory = GameManager.instance.inventory;
        psolving = GameManager.instance.psolving;
        notif = GameManager.instance.notif;
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
            Debug.Log("coba2");
            notif.Show("Problem Solving " + PSItem.title + " ditambakan");
            psolving.ParsingFile(PSItem);
        }
        
    }

}

