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
        Review_state = false;
        


    }

    public bool Uts_1_state { get; set; } = false;
    public int Uts_1_jawaban { get; set; } = 0;
    public bool Uts_2_state { get; set; } = false;
    public int Uts_2_jawaban { get; set; } = 0;
    public bool DaP_state { get; set; } = false;
    public int DaP_jawaban { get; set; } = 0;
    public bool TP_state { get; set; } = false;
    public int TP_pc1 { get; set; } = 0;
    public int TP_pc2 { get; set; } = 0;
    public int TP_pc3 { get; set; } = 0;
    public int TP_pc4 { get; set; } = 0;
    public bool Review_state { get; set; } = false;
}
