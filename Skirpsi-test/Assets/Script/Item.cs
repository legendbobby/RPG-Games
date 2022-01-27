
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName ="NewItem",menuName ="Inventory/Item")  ]
public class Item : ScriptableObject
{
    [SerializeField]  new public string name = "New Item";
    [SerializeField] public int id;
    [SerializeField] public List<Sprite> img;
    [SerializeField] public Sprite icon = null;

    Photo foto;


    public ItemState ItemState { get; set; }


    public Item()
    {
        ItemState = new ItemState();
    }

   

   

    public virtual void Use()
    {
        if (id == 0)
        {
            ItemState.Coba = true;
        }
        Debug.Log("Using" + name);
       
        GameManager.instance.photo.ParsingFile(img, name);
        GameManager.instance.photo.PhotoActive();

    }
   
}
