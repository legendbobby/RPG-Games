using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public static bool queriesHitTriggers = true;
    public Image icon;
    Item item;
    public GameObject itemTitle;
    private bool mouse_over = false;
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (item != null)
        {
            mouse_over = true;
            //Debug.Log("Mouse enter");
            //Debug.Log(item.name);
            itemTitle.GetComponent<Text>().text = item.name;
            itemTitle.SetActive(true);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
       //Debug.Log("Mouse exit");

        itemTitle.SetActive(false);
        itemTitle.GetComponent<Text>().text = null;
    }
    
   
    public void AddItem(Item newItem)
    {


        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
    }

    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;

        icon.enabled = false;
    }
    public void UseItem()
    {
        if (item != null)
        {
            item.Use();
        }
        
    }
}
