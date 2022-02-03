
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewItem", menuName = "ProblemSolving/Item")]
public class PSItem : ScriptableObject
{
    [SerializeField] public string title = "New Item";
    [SerializeField] public int id;
    [SerializeField] public string soal_UtP_1;
    [SerializeField] public string soal_UtP_2;
    [SerializeField] public string soal_DaP;
    [SerializeField] public List<string> choice_UtP_1;
    [SerializeField] public List<string> choice_UtP_2;
    [SerializeField] public List<string> choice_DaP;
    [SerializeField] public Sprite icon = null;
    [SerializeField] public int UtP_1_jawaban;
    [SerializeField] public int UtP_2_jawaban;
    [SerializeField] public int DaP_jawaban;
    [SerializeField] public List<string> pc1;
    [SerializeField] public List<string> pc2;
    [SerializeField] public List<string> pc3;
    [SerializeField] public List<string> pc4;
    [SerializeField] public int pc1_jawaban;
    [SerializeField] public int pc2_jawaban;
    [SerializeField] public int pc3_jawaban;
    [SerializeField] public int pc4_jawaban;


    Photo foto;


    public PSItemState PSItemState { get; set; }


    public PSItem()
    {
        PSItemState = new PSItemState();
    }





    public virtual void Use()
    {
        if (id == 0)
        {
            //ItemState.Coba = true;
        }
        Debug.Log("Using" + name);

       // GameManager.instance.photo.ParsingFile(img, name);
        // GameManager.instance.photo.PhotoActive();

    }

}
