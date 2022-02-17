using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notif_sys : MonoBehaviour
{
    public GameObject notifimg;
    string notif2;
    string notif3;
    public GameObject notifcanvas;
    int jumlah = 0;
    Vector3 pos;
    float tempy;
    Queue<string> queue = new Queue<string>();
    bool ada;

    private void Start()
    {
       pos = notifimg.transform.position;
       tempy = pos.y;
    }
    void Update()
    {
       if(queue.Count>0)
        {

            StartCoroutine(Show_notif());
        }
            
    }
    public void Show(string notif)
    {
        notif3 = notif;
        //StopAllCoroutines();
        queue.Enqueue(notif3);
        Debug.Log(queue.Count);
        //StartCoroutine(Show_notif());
    }


    IEnumerator Show_notif ()
    {
        if (notifcanvas.transform.childCount - 1 < 2)
        {
            GameObject temp = Instantiate(notifimg, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity, notifcanvas.transform);
            temp.transform.GetChild(0).GetComponent<Text>().text = queue.Dequeue();
            Debug.Log("keluar");
            temp.SetActive(true);
            if (notifcanvas.transform.childCount - 1 == 2)
            {
                tempy = pos.y + 75;
                notifcanvas.transform.GetChild(notifcanvas.transform.childCount - 2).position = new Vector3(pos.x, tempy, pos.z);
                tempy = pos.y - 75;
            }

            yield return new WaitForSeconds(2);
            temp.SetActive(false);
            Destroy(temp);
        }

    }
    // Start is called before the first frame update
    
}
