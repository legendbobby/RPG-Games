using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour
{
    public object element;
    public int indexPS;
    public void Decide()
    {
        DialogueManager.SetDecision(element);
    }

}