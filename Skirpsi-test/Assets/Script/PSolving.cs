using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PSolving : MonoBehaviour
{
    PSItem pSItems;
    public Button closebutton;
    public GameObject UtP;
    public GameObject UtP_com;
    public GameObject DaP;
    public GameObject DaP_com;
    public GameObject Dit;
    public GameObject Dit_com;
    public GameObject Dik;
    public GameObject Dik_com;
    public GameObject TtP;
    public GameObject TtP_com;
    public GameObject Dik_Lok;
    public GameObject DaP_Lok;
    public GameObject TtP_Lok;
    public GameObject Review_Lok;
    public GameObject Review;
    public GameObject Review_com;
    public GameObject PB_panel;
    public GameObject qpanel;
    public GameObject qoption;
    public GameObject qoption_select;
    public GameObject qbutton;
    public GameObject qbutton_select;
    public GameObject confirm;
    public GameObject TtP_confirm;
    public GameObject Review_confirm;
    public GameObject Comp_ps;
    Text qtext;
    string title;
    string soal_UtP_1;
    string soal_UtP_2;
    string soal_DaP;
    List<string> choice_UtP_1;
    List<string> choice_UtP_2; 
    List<string> choice_DaP;
    List<string> choice;
    int currentchoice;
    bool confirm2;
    GameObject temp2;
    Comp_Sys comp_Sys;
    bool reviewstate = false;
    Vector3 position;
    int jawaban;
    // Update is called once per frame
    private void Start()
    {
        qtext = qpanel.transform.GetChild(0).GetComponent<Text>();
        comp_Sys = GameManager.instance.comp_Sys;
    }
    void Update()
    {
        if (Input.GetButtonDown("PSolving"))
        {
            if (PB_panel.activeSelf == true)
            {
                PB_panel.SetActive(false);
            }
            else
            {
                PB_panel.SetActive(true);
            }
        
        }
       
    }

    /*public void ParsingFile(string title2, string soal_UtP_12, string soal_UtP_22,string soal_DaP2, List<string> choice_UtP_12, List<string> choice_UtP_22, List<string> choice_DaP2)
    {
        title = title2;
        soal_DaP = soal_DaP2;
        soal_UtP_1 = soal_UtP_12;
        soal_UtP_2 = soal_UtP_22;
        choice_UtP_1 = choice_UtP_12;
        choice_UtP_2 = choice_UtP_22;
        choice_DaP = choice_DaP2;
    }*/
    public void ParsingFile(PSItem pSItem)
    {
        pSItems = pSItem;
        comp_Sys.psItem = pSItem;
    }
    public void OnCloseButton()
    {
        PB_panel.SetActive(false);
    }
    public void OnConfirmButton()
    {
        
        if (currentchoice != 0)
        {
            confirm2 = true;
            Debug.Log("jawaban = " + currentchoice);
            if (qtext.text == pSItems.soal_UtP_1)
            {
                pSItems.PSItemState.Uts_1_jawaban = currentchoice;
                pSItems.PSItemState.UtS_1_pos = position;
                if (pSItems.UtP_1_jawaban == currentchoice && confirm2 == true)
                {
                   
                    pSItems.PSItemState.Uts_1_state = true;
                    qoption.SetActive(false);
                    qpanel.SetActive(false);
                    confirm.SetActive(false);
                    Dit_com.SetActive(true);
                    PB_panel.SetActive(true);
                    Dik_Lok.SetActive(false);

                    Debug.Log(pSItems.PSItemState.Uts_1_state);


                }

                else if (pSItems.UtP_1_jawaban != currentchoice && confirm2 == true)
                {
                    pSItems.PSItemState.Uts_1_state = false;
                    qoption.SetActive(false);
                    qpanel.SetActive(false);
                    confirm.SetActive(false);
                    Dit_com.SetActive(true);
                    PB_panel.SetActive(true);
                    Dik_Lok.SetActive(false);

                    Debug.Log("jawaban anda =" + currentchoice + "seharusnya" + pSItems.UtP_1_jawaban);
                }
                
            }
            else if (qtext.text == pSItems.soal_UtP_2)
            {
                pSItems.PSItemState.Uts_2_jawaban = currentchoice;
                pSItems.PSItemState.UtS_2_pos = position;
                if (pSItems.UtP_2_jawaban == currentchoice && confirm2 == true)
                {
                    pSItems.PSItemState.Uts_2_state = true;
                    qoption.SetActive(false);
                    qpanel.SetActive(false);
                    confirm.SetActive(false);
                    Dik_com.SetActive(true);
                    UtP_com.SetActive(true);
                    PB_panel.SetActive(true);
                    DaP_Lok.SetActive(false);

                    Debug.Log(pSItems.PSItemState.Uts_2_state);


                }

                else if (pSItems.UtP_2_jawaban != currentchoice && confirm2 == true)
                {
                    pSItems.PSItemState.Uts_2_state = false;
                    qoption.SetActive(false);
                    qpanel.SetActive(false);
                    confirm.SetActive(false);
                    Dik_com.SetActive(true);
                    UtP_com.SetActive(true);
                    PB_panel.SetActive(true);
                    DaP_Lok.SetActive(false);

                    Debug.Log("jawaban anda =" + currentchoice + "seharusnya" + pSItems.UtP_2_jawaban);
                }
            }
            else if (qtext.text == pSItems.soal_DaP)
            {
                pSItems.PSItemState.DaP_jawaban = currentchoice;
                pSItems.PSItemState.DaP_pos = position;
                if (pSItems.DaP_jawaban == currentchoice && confirm2 == true)
                {
                    pSItems.PSItemState.DaP_state = true;
                    qoption.SetActive(false);
                    qpanel.SetActive(false);
                    confirm.SetActive(false);
                    DaP_com.SetActive(true);
                    PB_panel.SetActive(true);
                    TtP_Lok.SetActive(false);

                    Debug.Log(pSItems.PSItemState.DaP_state);


                }

                else if (pSItems.DaP_jawaban != currentchoice && confirm2 == true)
                {
                    pSItems.PSItemState.DaP_state = false;
                    qoption.SetActive(false);
                    qpanel.SetActive(false);
                    confirm.SetActive(false);
                    DaP_com.SetActive(true);
                    PB_panel.SetActive(true);
                    TtP_Lok.SetActive(false);

                    Debug.Log("jawaban anda =" + currentchoice + "seharusnya" + pSItems.DaP_jawaban);
                }

            }
           for (int i = 0; i < Comp_ps.transform.childCount; i++ )
            {
                
                if (i % 2 == 0)
                {
                    Comp_ps.transform.GetChild(i).gameObject.SetActive(true);

                }
                else
                {
                    Comp_ps.transform.GetChild(i).gameObject.SetActive(false);
                }
                Debug.Log(i);
            }
            
           
        }
        else {
            Debug.Log("Pilih jawaban");
        }

       
    }
    public void OnUtP1Button()
    {
        PB_panel.SetActive(false);
        qtext.text = pSItems.soal_UtP_1;
        choice = pSItems.choice_UtP_1;
        position = pSItems.PSItemState.UtS_1_pos;
        jawaban = pSItems.PSItemState.Uts_1_jawaban; 
        ShowAnswer();
        qpanel.SetActive(true);
        confirm.SetActive(true);
    }
    public void OnUtP2Button()
    {
        PB_panel.SetActive(false);
        qtext.text = pSItems.soal_UtP_2;
        choice = pSItems.choice_UtP_2;
        position = pSItems.PSItemState.UtS_2_pos;
        jawaban = pSItems.PSItemState.Uts_2_jawaban;
        ShowAnswer();
        qpanel.SetActive(true);
        confirm.SetActive(true);
    }
    public void OnDaPButton()
    {
        PB_panel.SetActive(false);
        qtext.text = pSItems.soal_DaP;
        choice = pSItems.choice_DaP;
        position = pSItems.PSItemState.DaP_pos;
        jawaban = pSItems.PSItemState.DaP_jawaban;

        ShowAnswer();
        qpanel.SetActive(true);
        confirm.SetActive(true);
    }
    public void OnUtPButton()
    { 
       if (!TtP_confirm.activeSelf)
        {
            TtP_confirm.SetActive(true);
            GameObject temp = TtP_confirm.transform.GetChild(3).gameObject;
            GameObject temp2 = TtP_confirm.transform.GetChild(4).gameObject;

            temp.GetComponent<Button>().onClick.AddListener(()=>
                {
                    TtP_com.SetActive(true);
                    TtP_confirm.SetActive(false);
                    Review_Lok.SetActive(false);
                    for (int i = 0; i < Comp_ps.transform.childCount; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Comp_ps.transform.GetChild(i).gameObject.SetActive(false);

                        }
                        else
                        {
                            Comp_ps.transform.GetChild(i).gameObject.SetActive(true);
                        }

                    }
                });

            temp2.GetComponent<Button>().onClick.AddListener(() =>
            {
                TtP_confirm.SetActive(false);
            });
        }
        else
        {
            TtP_confirm.SetActive(false);
        }


        
    }

    public void OnReviewButton()
    {
        if (!Review_confirm.activeSelf)
        {
            Review_confirm.SetActive(true);
            GameObject temp = Review_confirm.transform.GetChild(3).gameObject;
            GameObject temp2 = Review_confirm.transform.GetChild(4).gameObject;

            temp.GetComponent<Button>().onClick.AddListener(() =>
            {
                if (reviewstate)
                {
                    Debug.Log("aaaaaaa");
                    Review_com.SetActive(true);
                    Review_confirm.SetActive(false);
                    

                }
                else
                {
                    Debug.Log("bbbbbb");
                    reset();
                    Review_confirm.SetActive(false);
                    reviewstate = true;
                }
            });

            temp2.GetComponent<Button>().onClick.AddListener(() =>
            {
                Review_confirm.SetActive(false);
            });
        }
        else
        {
            Review_confirm.SetActive(false);
        }



    }

    void reset()
    {
        UtP_com.SetActive(false);
        Dit_com.SetActive(false);
        Dik_com.SetActive(false);
        DaP_com.SetActive(false);
        TtP_com.SetActive(false);
        Dik_Lok.SetActive(true);
        DaP_Lok.SetActive(true);
        TtP_Lok.SetActive(true);
        Review_Lok.SetActive(true);
         
    }

    void ShowAnswer()
    {
        int tempint;
        Vector3 pos = qbutton.transform.position;
        float tempy = pos.y;
        for (int i = 0; i< choice.Count; i++)
        {
            GameObject temp = Instantiate(qbutton, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity, qoption.transform);
            if (choice.Count > 2)
            {
                if (i == 3)
                {
                    pos.x += 450;
                    pos.y = tempy;
                }
                else
                {
                    pos.y -= 60;
                }


            }
            else
            {
                pos.y -= 60;
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
                if(currentchoice==0)
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
        if(reviewstate)
        {
            Confirmation(jawaban - 1, position);
        }
        qoption.SetActive(true);

        
    }
    void Confirmation(int buttonindex, Vector3 newpos)
    {
        Debug.Log(buttonindex);
        temp2 = Instantiate(qbutton_select, new Vector3(newpos.x, newpos.y, newpos.z), Quaternion.identity, qoption.transform);
        temp2.transform.GetChild(0).GetComponent<Text>().text = choice[buttonindex];
        currentchoice = buttonindex + 1;
        position = newpos;
        temp2.GetComponent<Button>().onClick.AddListener(() =>
        {
            Destroy(temp2.gameObject);
            currentchoice = 0;
        });
        //buat tombol jadi seolah olah kepilih
    }
}
