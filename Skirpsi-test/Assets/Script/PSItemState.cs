using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSItemState
{
    public PSItemState()
    {
        Uts_1_state = false;
        Uts_2_state = false;
        DaP_state = false;
        TP_state = false;
        Review_state = false;
    }

    public bool Uts_1_state { get; set; } = false;
    public bool Uts_2_state { get; set; } = false;
    public bool DaP_state { get; set; } = false;
    public bool TP_state { get; set; } = false;
    public bool Review_state { get; set; } = false;
}
