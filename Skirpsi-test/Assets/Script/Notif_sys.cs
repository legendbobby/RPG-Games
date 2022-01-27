using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notif_sys : MonoBehaviour
{
    public GameObject notifimg;
    string notif2;
    public void Show(string notif)
    {
        notif2 = notif;
        StopAllCoroutines();
        StartCoroutine(Show_notif());
    }


    IEnumerator Show_notif ()
    {
        Debug.Log("coba");
        notifimg.transform.GetChild(0).GetComponent<Text>().text = notif2;
        notifimg.SetActive(true);
        yield return new WaitForSeconds(3);
        notifimg.SetActive(false);
    }
    // Start is called before the first frame update
    
}
