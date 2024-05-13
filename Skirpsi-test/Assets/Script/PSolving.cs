using System;
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
    public GameObject block;
    public GameObject block2;
    public GameObject nilai;
    public GameObject soal;
    Text soaltext;
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
    bool reviewstate = true;
    bool pctracker = false;
    Vector3 position;
    int jawaban;
    ScreenShot screenShot;
    Notif_sys notif_Sys;
    Tracker tracker;
    Tracker.QuestTracker questTracker;
    StoryScript storyScript;
    DialogueManager dialogueManager;
    CharacterContoller2D characterContoller2;
    // Update is called once per frame
    private void Start()
    {
        qtext = qpanel.transform.GetChild(0).GetComponent<Text>();
        soaltext = soal.transform.GetChild(0).GetComponent<Text>();
        comp_Sys = GameManager.instance.comp_Sys;
        screenShot = GameManager.instance.screenShot;
        notif_Sys = GameManager.instance.notif;
        tracker = GameManager.instance.tracker;
        storyScript = GameManager.instance.storyscript;
        dialogueManager = GameManager.instance.dialogueManager;
        characterContoller2 = GameManager.instance.characterContoller2D;
        
       
    }
    void Update()
    {
        if (Input.GetButtonDown("PSolving"))
        {
            if (PB_panel.activeSelf == true)
            {
                PB_panel.SetActive(false);
                soal.SetActive(false);
                if (reviewstate && block.activeSelf==true)
                {
                    block.SetActive(false);
                }
                
            }
            else
            {
                if (dialogueManager.ngomong ==false && !Input.GetButton("Horizontal") && !Input.GetButton("Vertical"))
                {
                    CharacterContoller2D.enableMovement = false;
                    if (reviewstate)
                    {
                        block.SetActive(true);
                    }

                    PB_panel.SetActive(true);
                    soal.SetActive(true);
                    

                }
               

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
        //pSItems = new PSItem();
        pSItems = Instantiate(pSItem);
        comp_Sys.psItem = pSItem;
        reviewstate = false;
        soaltext.text = pSItems.soal;
        
    }
    public void OnCloseButton()
    {
        PB_panel.SetActive(false);
        soal.SetActive(false);
        block.SetActive(false);
        CharacterContoller2D.enableMovement = true;
        if (pSItems != null && block.activeSelf == true)
        {
            block.SetActive(false);
            Debug.Log("ADA SOAL PB");
        }
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
                    soal.SetActive(true);

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
                    soal.SetActive(true);


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
                    soal.SetActive(true);
                    DaP_Lok.SetActive(false);

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

                    
                }
                notif_Sys.Show("Tahap Understanding the Problem selesai");
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
                    soal.SetActive(true);



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
                    soal.SetActive(true);

                }
                notif_Sys.Show("Tahap Devise a Plan selesai. Akses Komputer telah dibuka. Selesaikan Permasalahan sesuai Petunjuk");
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
                

            }
            Transform PC1 = Comp_ps.transform.GetChild(0);
            questTracker = tracker.CreateTracker(PC1);
            Transform PC2 = Comp_ps.transform.GetChild(2);
            questTracker = tracker.CreateTracker(PC2);
            Transform PC3 = Comp_ps.transform.GetChild(4);
            questTracker = tracker.CreateTracker(PC3);
            Transform PC4 = Comp_ps.transform.GetChild(6);
            questTracker = tracker.CreateTracker(PC4);
            currentchoice = 0;
            
        }
        else {
            notif_Sys.Show("Silahkan Pilih Jawaban");
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
        soal.SetActive(false);

    }
    public void OnUtP2Button()
    {
        PB_panel.SetActive(false);
        soal.SetActive(false);
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
        soal.SetActive(false);
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
       if(!reviewstate)
        {
            comp_Sys.psItem = pSItems;
        }
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
            Debug.Log("review state= "+reviewstate);
            Review_confirm.SetActive(true);
            GameObject temp = Review_confirm.transform.GetChild(3).gameObject;
            GameObject temp2 = Review_confirm.transform.GetChild(4).gameObject;
            if (reviewstate)
            {
                string coba = "Kamu sudah selesai mengulas kembali Problem solving. Lanjut untuk melihat nilai?";
                Review_confirm.transform.GetChild(2).GetComponent<Text>().text = coba;
            }
            else
            {
                string coba = "Kamu akan mengulas kembali jawaban, dari Tahap 1 - 3. Lanjut untuk mengulas?";
                Review_confirm.transform.GetChild(2).GetComponent<Text>().text = coba;
            }
            temp.GetComponent<Button>().onClick.AddListener(() =>
            {
                if (reviewstate)
                {
                    storyScript.misi = 2;
                    Review_com.SetActive(true);
                    Review_confirm.SetActive(false);
                    int totalnilai = 10;
                    int UtSnilai = 0;
                    int DaPnilai = 0;
                    int TtPnilai = 0;
                    Calculate(out totalnilai,out UtSnilai,out DaPnilai,out TtPnilai);
                    nilai.transform.GetChild(6).GetComponent<Text>().text = UtSnilai.ToString();
                    nilai.transform.GetChild(7).GetComponent<Text>().text = DaPnilai.ToString();
                    nilai.transform.GetChild(8).GetComponent<Text>().text = TtPnilai.ToString();
                    nilai.transform.GetChild(9).GetComponent<Text>().text = "10";
                    nilai.transform.GetChild(10).GetComponent<Text>().text = totalnilai.ToString();
                    GameObject temp3 = nilai.transform.GetChild(11).gameObject;
                    GameObject temp4 = nilai.transform.GetChild(12).gameObject;

                    temp3.GetComponent<Button>().onClick.AddListener(() =>
                    {
                        nilai.SetActive(false);
                        block2.SetActive(false);
                        Review_com.SetActive(false);
                        Reset();
                       
                        reviewstate = false;
                        temp.GetComponent<Button>().onClick.RemoveAllListeners();
                        Debug.Log("review state sekarang= " + reviewstate);
                        
                        //lanjut story

                    });
                    temp4.GetComponent<Button>().onClick.AddListener(() =>
                    {
                        ScreenCapture.CaptureScreenshot("D:/tes.png");

                    });
                    nilai.SetActive(true);
                    block2.SetActive(true);
                    block.SetActive(true);


                }
                else
                {
                    
                    Reset();
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

    void Reset()
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
                    pos.x += 960f;
                    pos.y = tempy;
                }
                else
                {
                    pos.y -= 130f;
                }


            }
            else
            {
                pos.y -= 130f;
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
                    
                    Confirmation(temp.GetComponent<Selectable>().indexPS, temp.transform.position);
                }
                else
                {
                    Destroy(temp2.gameObject);
                   
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
        if (buttonindex < 0)
        {
            buttonindex = 0;
        }
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
    void Calculate(out int totalnilai,out int UtSnilai,out int DaPnilai,out int TtPnilai)
    {
        totalnilai = 10;
        UtSnilai = 0;
        DaPnilai = 0;
        TtPnilai = 0;
        if (pSItems.PSItemState.Uts_1_state == true)
        {
            UtSnilai = UtSnilai + 10;

        }
        if (pSItems.PSItemState.Uts_2_state == true)
        {
            UtSnilai = UtSnilai + 10;

        }
        if (pSItems.PSItemState.DaP_state == true)
        {
            DaPnilai = DaPnilai + 10;

        }
        if (pSItems.PSItemState.pc1_state == true)
        {
            TtPnilai = TtPnilai + 15;

        }
        if (pSItems.PSItemState.pc2_state == true)
        {
            TtPnilai = TtPnilai + 15;

        }
        if (pSItems.PSItemState.pc3_state == true)
        {
            TtPnilai = TtPnilai + 15;

        }
        if (pSItems.PSItemState.pc4_state == true)
        {
            TtPnilai = TtPnilai + 15;

        }
        totalnilai = UtSnilai + DaPnilai + TtPnilai + 10;

        



    }
}
