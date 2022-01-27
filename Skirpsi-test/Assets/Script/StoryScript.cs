using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryScript : MonoBehaviour
{
    public string state;
    DialogueManager dialogueManager;
    public bool finish;
    public int id;
    Inventory inventory;
    public Item item;
    bool ketemu =false;
    bool coba=false;
    bool misi1_terima = false;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameManager.instance.inventory;
        dialogueManager = GameManager.instance.dialogueManager;
        item = ScriptableObject.CreateInstance<Item>();

    }

    // Update is called once per frame
    void Update()
    {
        if(dialogueManager.ip1==1)
        {
            state = "IP_2";
        }

        if (!ketemu || !coba)
        {
            for (int i = 0; i < inventory.items.Count; i++)
            {
                if (inventory.items[i].id == 0 && !ketemu)
                {
                    ketemu = true;
                    //state = "IP_3";
                    //Debug.Log(state);
                    
                }
                else if (inventory.items[i].ItemState.Coba == true && inventory.items[i].id == 0 && !coba)
                {
                    //state = "MISI_1";
                    coba = true;
                   
                    
                }
            }
        }

        if (ketemu && !coba)
        {
            state = "IP_3";

            
        }

        else if (ketemu && coba)
        {
            state = "MISI_1";
            
            misi1_terima = true;
        }

        if (misi1_terima && dialogueManager.ip3 == 1)
        {
            state = "COBA_1";
        }



    }
}
