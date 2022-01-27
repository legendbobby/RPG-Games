using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallBack;
    //public static Inventory instance;
    public int Space = 10;
   /* void awake()
    {

        if (instance != null)
        {
            Debug.Log("instance nyala 2");
                return;
        }
        instance = this;
    }*/
    public List<Item> items = new List<Item>();

    public void Add(Item item)
    {

        Debug.Log("ada " + item.name);
        if (items.Count >= Space)
        {
            return; 
        }

        items.Add(item);

       if (onItemChangedCallBack != null)
        {
            onItemChangedCallBack.Invoke();
        }
        
    }

    public void Remove(Item item)
    {
        items.Remove(item);

        if (onItemChangedCallBack != null)
        {
            onItemChangedCallBack.Invoke();
        }
    }
}
