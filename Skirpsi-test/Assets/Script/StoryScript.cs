using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryScript : MonoBehaviour
{
    public bool MisiSM = false;

    public string state;
    DialogueManager dialogueManager;
    public bool finish;
    public int id;
    Inventory inventory;
    public Item item;
    bool ketemu =false;
    bool ketemusubnet = false;
    bool coba=false;
    bool misi1_terima = false;
    bool bukugudangtracerremove = false;
    public GameObject BukuPerpusTR;
    public GameObject BukuPerpusTRtemp;
    public GameObject BukuGedungMS1;
    public GameObject BukuGedungMS1temp;
    public GameObject BukuPerpussubnet;
    public GameObject BukuPerpussubnettemp;
    public GameObject BukubSubnetPB;
    public GameObject BukubSubnetPBTemp;
    public GameObject NPC;
    public bool MS1 = false;
    public bool Bukuperpustracker =false;
    public bool BukuGudangTracker = false;
    public int misi = 0;
    public bool misiTR = false;
    PSolving pSolving;
    Tracker tracker;
    Tracker.QuestTracker TNPC;
    Tracker.QuestTracker BukuKelompok;
    Tracker.QuestTracker BukuPS1TR;
    Tracker.QuestTracker BukuSubnet;
    public bool ketemusubnetpb = false;
    public bool tracersubnetmt = false;
    Tracker.QuestTracker BukuSubnetPB;
    LootContainerInteract lootContainerInteract;
    private bool MISI2 = false;
    private bool tamat = false;

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
        TNPC = tracker.CreateTracker(NPC_T);
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
            BukuKelompok = tracker.CreateTracker(BukuPerpusTR_T);
            tracker.DestroyTracker(TNPC);
            

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
                    tracker.DestroyTracker(BukuKelompok);
                    //state = "IP_3";
                    //Debug.Log(state);
                    Transform NPC_T = NPC.transform;
                    TNPC = tracker.CreateTracker(NPC_T);

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
            BukuPS1TR = tracker.CreateTracker(BukuGedungMS1_T);
            tracker.DestroyTracker(TNPC);
        }
        if(!bukugudangtracerremove && MS1)
        {
            bukugudangtracerremove = true;
            BukuGedungMS1.SetActive(false);
            BukuGedungMS1temp.SetActive(true);
            tracker.DestroyTracker(BukuPS1TR);
            MS1 = false;
        }
        if (misi == 2  && !misiTR)
        {
            
            misiTR = true;
            state = "MISI_1_C";
            Transform NPC_T = NPC.transform;
            TNPC = tracker.CreateTracker(NPC_T);

        }
        if (misiTR && dialogueManager.sm == 1 && !MisiSM)
        {
            MisiSM = true;
            state = "SM_1";

        }
        if(dialogueManager.sm==1 && !tracersubnetmt && MisiSM)
        {
            tracersubnetmt = true;
            BukuPerpussubnet.SetActive(true);
            BukuPerpussubnettemp.SetActive(false);
            Transform BukuPerpusSubnet_T = BukuPerpussubnet.transform;
            BukuSubnet = tracker.CreateTracker(BukuPerpusSubnet_T);
            tracker.DestroyTracker(TNPC);

        }
        if(dialogueManager.sm==1 && !ketemusubnet && tracersubnetmt)
        {
            
            for (int i = 0; i < inventory.items.Count; i++)
            {
                if (inventory.items[i].id == 2)
                {
                    ketemusubnet = true;
                }
              
            }
        }
        if (dialogueManager.sm == 1 && ketemusubnet && !MISI2)
        {
            MISI2 = true;
            state = "MISI_2";
            tracker.DestroyTracker(BukuSubnet);
            Transform NPC_T = NPC.transform;
            TNPC = tracker.CreateTracker(NPC_T);
            BukuPerpussubnet.SetActive(false);
            BukuPerpussubnettemp.SetActive(true);
        }
        if (dialogueManager.sm == 5 && !ketemusubnetpb)
        {
            
            state = "MISI_2_E";
            BukubSubnetPB.SetActive(true);
            BukubSubnetPBTemp.SetActive(false);
            Transform BukuPerpusSubnet_PB = BukubSubnetPB.transform;
            BukuSubnetPB = tracker.CreateTracker(BukuPerpusSubnet_PB);
            tracker.DestroyTracker(TNPC);
            ketemusubnetpb= true;


        }
        if (MS1==true && ketemusubnetpb)
        {
            tracker.DestroyTracker(BukuSubnetPB);
            BukubSubnetPB.SetActive(false);
            BukubSubnetPBTemp.SetActive(true);

            MS1 = false;
        }
        if (misi==3 && dialogueManager.sm == 5 && !tamat)
        {
            tamat = true;
            Transform NPC_T = NPC.transform;
            TNPC = tracker.CreateTracker(NPC_T);
            Debug.Log("Tamat");
            state = "Tamat";
        }



    }
}
