using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSItemState
{
    public PSItemState()
    {
        
        Uts_1_state = false;
        Uts_1_jawaban = 0;
        Uts_2_state = false;
        Uts_2_jawaban = 0;
        DaP_state = false;
        DaP_jawaban = 0;
        TP_state = false;
        TP_pc1 = 0;
        TP_pc2 = 0;
        TP_pc3 = 0;
        TP_pc4 = 0;
        TP_pc1_pos = default;
        TP_pc2_pos = default;
        TP_pc3_pos = default;
        TP_pc4_pos = default;
        Review_state = false;
        UtS_1_pos = default;
        UtS_2_pos = default;
        DaP_pos = default;




    }
   
    public bool Uts_1_state { get; set; } = false;
    public int Uts_1_jawaban { get; set; } = 0;
    public Vector3 UtS_1_pos { get; set; } = default;
    public bool Uts_2_state { get; set; } = false;
    public int Uts_2_jawaban { get; set; } = 0;
    public Vector3 UtS_2_pos { get; set; } = default;
    public bool DaP_state { get; set; } = false;
    public int DaP_jawaban { get; set; } = 0;
    public Vector3 DaP_pos { get; set; } = default;
    public bool TP_state { get; set; } = false;
    public int TP_pc1 { get; set; } = 0;
    public Vector3 TP_pc1_pos { get; set; } = default;
    public int TP_pc2 { get; set; } = 0;
    public Vector3 TP_pc2_pos { get; set; } = default;
    public int TP_pc3 { get; set; } = 0;
    public Vector3 TP_pc3_pos { get; set; } = default;
    public int TP_pc4 { get; set; } = 0;
    public Vector3 TP_pc4_pos { get; set; } = default;

    public bool pc1_state { get; set; } = false;
    public bool pc2_state { get; set; } = false;
    public bool pc3_state { get; set; } = false;
    public bool pc4_state { get; set; } = false;
    public bool Review_state { get; set; } = false;
}
