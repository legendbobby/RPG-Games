using UnityEngine;
using UnityEngine.UI;


public class inventoryUI : MonoBehaviour
{
    
    public Transform itemParent;
    public Button closeButton;
    public GameObject InventoryPanel;

    Inventory inventory;
    InventorySlot[] slots;

    void Start()
    {
        inventory = GameManager.instance.inventory;
        inventory.onItemChangedCallBack += UpdateUI;

        slots = itemParent.GetComponentsInChildren<InventorySlot>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            if (!InventoryPanel.activeSelf)
            {
                InventoryPanel.SetActive(true);
            }
            else
            {
                InventoryPanel.SetActive(false);
            }
            
        }
    }

    void UpdateUI()
    {
        Debug.Log("Updating UI");
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
    public void OnCloseButton()
    {
        InventoryPanel.SetActive(false);
    }

}
