using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightController : MonoBehaviour
{
    [SerializeField] GameObject highlighter;
    [SerializeField] GameObject mainchar;

    GameObject currentTarget;
 
    public void Highlight(GameObject target)
    {
        if (currentTarget == target)
        {
            return;
        }
        currentTarget = target;
        Vector3 position =currentTarget.transform.position;
        Highlight(position);

    }

    public void Highlight(Vector3 position)
    {

        highlighter.SetActive(true);
        position = new Vector3(position.x, position.y+0.8f, position.z);
        highlighter.transform.position = position;
       
    }

    public void Hide()
    {
        currentTarget = null;
        highlighter.SetActive(false);
        
    }

}
