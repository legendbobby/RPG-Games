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
    bool ketemusubnet = true;
    bool coba=false;
    bool misi1_terima = false;
    bool bukugudangtracerremove = false;
    public GameObject BukuPerpusTR;
    public GameObject BukuPerpusTRtemp;
    public GameObject BukuGedungMS1;
    public GameObject BukuGedungMS1temp;
    public GameObject NPC;
    public bool MS1 = false;
    public bool Bukuperpustracker =false;
    public bool BukuGudangTracker = false;
    public int misi = 0;
    public bool misiTR = false;
    PSolving pSolving;
    Tracker tracker;
    Tracker.QuestTracker questTracker;
    LootContainerInteract lootContainerInteract;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameManager.instance.inventory;
        dialogueManager = GameManager.instance.dialogueManager;
        item = ScriptableObject.CreateInstance<Item>();
        tracker = GameManager.instance.tracker;
        lootContainerInteract = GameManager.instance.lootContainerInteract;
        pSolving = GameManager.instance.psolving;
        Transform NPC_T = NPC.transform;
        questTracker = tracker.CreateTracker(NPC_T);
        Debug.Log("MMS1 = " + MS1);
        
    }

    // Update is called once per frame
    public void Update()
    {
        if(dialogueManager.ip1==1 && !Bukuperpustracker)
        {
            Bukuperpustracker=true;
            state = "IP_2";
            BukuPerpusTR.SetActive(true);
            BukuPerpusTRtemp.SetActive(false);
            Transform BukuPerpusTR_T = BukuPerpusTR.transform;
            questTracker = tracker.CreateTracker(BukuPerpusTR_T);
            

        }

        if (!ketemu || !coba)
        {
            for (int i = 0; i < inventory.items.Count; i++)
            {
                if (inventory.items[i].id == 0 && !ketemu)
                {
                    ketemu = true;
                    BukuPerpusTR.SetActive(false);
                    BukuPerpusTRtemp.SetActive(true);
                    tracker.DestroyTracker(questTracker);
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

        else if (ketemu && coba && !misi1_terima)
        {
            state = "MISI_1";
            
            misi1_terima = true;
        }

        if (misi1_terima && dialogueManager.ip3 == 1 && !BukuGudangTracker)
        {
            state = "COBA_1";
            BukuGudangTracker = true;
            BukuGedungMS1.SetActive(true);
            BukuGedungMS1temp.SetActive(false);
            Transform BukuGedungMS1_T = BukuGedungMS1.transform;
            questTracker = tracker.CreateTracker(BukuGedungMS1_T);
        }
        if(!bukugudangtracerremove && MS1)
        {
            bukugudangtracerremove = true;
            BukuGedungMS1.SetActive(false);
            BukuGedungMS1temp.SetActive(true);
            tracker.DestroyTracker(questTracker);
        }
        if (misi == 2  && !misiTR)
        {
            Debug.Log("MISI 1 C");
            misiTR = true;
            state = "MISI_1_C";
            
        }
        if(dialogueManager.sm==1 && !ketemusubnet)
        {
            for (int i = 0; i < inventory.items.Count; i++)
            {
                if (inventory.items[i].id == 0)
                {
                    ketemusubnet = true;
                }
              
            }
        }
        else if (dialogueManager.sm == 1 && ketemusubnet)
        {
            state = "MISI_2";
        }


    }
}
