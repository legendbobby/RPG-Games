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
    public GameObject UtP_Lok;
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
    
    // Update is called once per frame
    private void Start()
    {
        qtext = qpanel.transform.GetChild(0).GetComponent<Text>();

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
                if (pSItems.DaP_jawaban == currentchoice && confirm2 == true)
                {
                    pSItems.PSItemState.DaP_state = true;
                    qoption.SetActive(false);
                    qpanel.SetActive(false);
                    confirm.SetActive(false);
                    DaP_com.SetActive(true);
                    PB_panel.SetActive(true);
                    UtP_Lok.SetActive(false);

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
                    UtP_Lok.SetActive(false);

                    Debug.Log("jawaban anda =" + currentchoice + "seharusnya" + pSItems.DaP_jawaban);
                }
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

       
        ShowAnswer();
        qpanel.SetActive(true);
        confirm.SetActive(true);
    }
    public void OnUtP2Button()
    {
        PB_panel.SetActive(false);
        qtext.text = pSItems.soal_UtP_2;
        choice = pSItems.choice_UtP_2;


        ShowAnswer();
        qpanel.SetActive(true);
        confirm.SetActive(true);
    }
    public void OnDaPButton()
    {
        PB_panel.SetActive(false);
        qtext.text = pSItems.soal_DaP;
        choice = pSItems.choice_DaP;


        ShowAnswer();
        qpanel.SetActive(true);
        confirm.SetActive(true);
    }
    public void OnTtPButton()
    { 
        //check progress
        
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
        qoption.SetActive(true);

        
    }
    void Confirmation(int buttonindex, Vector3 newpos)
    {
        Debug.Log(buttonindex);
        temp2 = Instantiate(qbutton_select, new Vector3(newpos.x, newpos.y, newpos.z), Quaternion.identity, qoption.transform);
        temp2.transform.GetChild(0).GetComponent<Text>().text = choice[buttonindex];
        currentchoice = buttonindex + 1;
        temp2.GetComponent<Button>().onClick.AddListener(() =>
        {
            Destroy(temp2.gameObject);
            currentchoice = 0;
        });
        //buat tombol jadi seolah olah kepilih
    }
}
