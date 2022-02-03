using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comp_Sys : MonoBehaviour
{
    public GameObject pcpanel;
    public GameObject ipmenu;
    public GameObject pilihip;
    public GameObject pilihip_select;
    public GameObject closebutton;
    public GameObject closebutton2;
    public GameObject cancel;
    public GameObject ok;
    List<string> choice;
    int currentchoice;
    GameObject temp2;
    PSolving PSolving;
    //List<string> pc_text;
    public GameObject pc1;
    public GameObject pc2;
    public GameObject pc3;
    public GameObject pc4;
    public PSItem psItem;
    Vector3 postemp;
    public GameObject tampungan;
    public GameObject tampungan2;
    Notif_sys notif;
    // Start is called before the first frame update
    void Start()
    {
        PSolving = GameManager.instance.psolving;
        psItem = GameManager.instance.pSItem;
        notif = GameManager.instance.notif;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPCInteract(GameObject pc)
    {
        CharacterContoller2D.enableMovement = false;
        if (pc == pc1)
        {
            currentchoice = psItem.PSItemState.TP_pc1;
            choice = psItem.pc1;
            postemp = psItem.PSItemState.TP_pc1_pos;
        }
        else if (pc == pc2)
        {
            currentchoice = psItem.PSItemState.TP_pc2;
            choice = psItem.pc2;
            postemp = psItem.PSItemState.TP_pc2_pos;
        }
        else if (pc == pc3)
        {
            currentchoice = psItem.PSItemState.TP_pc3;
            choice = psItem.pc3;
            postemp = psItem.PSItemState.TP_pc3_pos;
        }
        else if (pc == pc4)
        {
            currentchoice = psItem.PSItemState.TP_pc4;
            choice = psItem.pc4;
            postemp = psItem.PSItemState.TP_pc4_pos;
        }
        if (!pcpanel.activeSelf)
        {
            pcpanel.SetActive(true);
        }
    }

    public void OnCloseButton()
    {
        if (!ipmenu.activeSelf)
        {
            pcpanel.SetActive(false);
            CharacterContoller2D.enableMovement = true;

        }
        else
        {
            notif.Show("Tutup dulu Menu IP");
        }


         

    }
    public void OnCloseButton2()
    {
        OnCancelButton();
    }
    public void OnConfirmButton()
    {
        if (currentchoice!=0)
        {
           if (choice==psItem.pc1)
            {
                psItem.PSItemState.TP_pc1 = currentchoice;
                psItem.PSItemState.TP_pc1_pos = postemp;
                if (currentchoice == psItem.pc1_jawaban)
                {
                    psItem.PSItemState.pc1_state = true;
                }
                else
                {
                    psItem.PSItemState.pc1_state = false;
                }
              
            }
            else if (choice == psItem.pc2)
            {
                psItem.PSItemState.TP_pc2 = currentchoice;
                psItem.PSItemState.TP_pc2_pos = postemp;
                if (currentchoice == psItem.pc2_jawaban)
                {
                    psItem.PSItemState.pc2_state = true;
                }
                else
                {
                    psItem.PSItemState.pc2_state = false;
                }

            }
            else if (choice == psItem.pc3)
            {
                psItem.PSItemState.TP_pc3 = currentchoice;
                psItem.PSItemState.TP_pc3_pos = postemp;
                if (currentchoice == psItem.pc3_jawaban)
                {
                    psItem.PSItemState.pc3_state = true;
                }
                else
                {
                    psItem.PSItemState.pc3_state = false;
                }

            }
            else if (choice == psItem.pc4)
            {
                psItem.PSItemState.TP_pc4 = currentchoice;
                psItem.PSItemState.TP_pc4_pos = postemp;
                if (currentchoice == psItem.pc4_jawaban)
                {
                    psItem.PSItemState.pc4_state = true;
                }
                else
                {
                    psItem.PSItemState.pc4_state = false;
                }

            }
            ipmenu.SetActive(false);
            for (int i = 1; i < tampungan.transform.childCount; i++)
            {
                Destroy(tampungan.transform.GetChild(i).gameObject);
            }
        }

    }
    public void OnCancelButton()
    {
        if (choice == psItem.pc1)
        {
            currentchoice = psItem.PSItemState.TP_pc1;
        }
        else if (choice == psItem.pc2)
        {

            currentchoice = psItem.PSItemState.TP_pc2;
        }
        else if (choice == psItem.pc3)
        {
            currentchoice = psItem.PSItemState.TP_pc3;

        }
        else if (choice == psItem.pc4)
        {

            currentchoice = psItem.PSItemState.TP_pc4;
        }
        ipmenu.SetActive(false);
        for (int i = 1; i < tampungan.transform.childCount; i++)
        {
            Destroy(tampungan.transform.GetChild(i).gameObject);
        }
    }
    public void OnIPMenu()
    {
        if (!ipmenu.activeSelf)
        {
            
            int tempint;
            Vector3 pos = pilihip.transform.position;
            float tempy = pos.y;
            for (int i = 0; i < choice.Count; i++)
            {
               GameObject temp = Instantiate(pilihip, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity, tampungan.transform);
                if (choice.Count > 2)
                {
                    if (i == 3)
                    {
                        pos.x += 250;
                        pos.y = tempy;
                    }
                    else
                    {
                        pos.y -= 30;
                    }


                }
                else
                {
                    pos.y -= 30;
                }

                //GameObject temp = Instantiate(customButton, optionPanel.transform);

                temp.transform.GetChild(0).GetComponent<Text>().text = choice[i];
                //Debug.Log(_choices[i].text);
                tempint = i;
                //Vector3 postemp;
                temp.AddComponent<Selectable>();
                temp.GetComponent<Selectable>().indexPS = i;
                temp.GetComponent<Button>().onClick.AddListener(() =>
                {
                    if (currentchoice == 0)
                    {
                        //qbutton.SetActive(false);
                        Debug.Log("Cobaaaaaa");
                        Confirmation(temp.GetComponent<Selectable>().indexPS, temp.transform.position);
                    }
                    else
                    {
                        Destroy(temp2.gameObject);
                        Debug.Log("Cobaaaaa2");
                        Confirmation(temp.GetComponent<Selectable>().indexPS, temp.transform.position);
                    }


                });
                
            }
            if (currentchoice != 0)
            {
                Confirmation(currentchoice - 1, postemp);
            }
            ipmenu.SetActive(true);


        }
        
        }

    void Confirmation(int buttonindex, Vector3 newpos)
    {
        Debug.Log(buttonindex);
        temp2 = Instantiate(pilihip_select, new Vector3(newpos.x, newpos.y, newpos.z), Quaternion.identity, tampungan.transform);
        temp2.transform.GetChild(0).GetComponent<Text>().text = choice[buttonindex];
        currentchoice = buttonindex + 1;
        postemp = newpos;
        temp2.GetComponent<Button>().onClick.AddListener(() =>
        {
            Destroy(temp2.gameObject);
            currentchoice = 0;
        });
        //buat tombol jadi seolah olah kepilih
    }
}

