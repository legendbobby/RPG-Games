using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notif_sys : MonoBehaviour
{
    public GameObject notifimg;
    string notif2;
    public GameObject notifcanvas;
    int jumlah = 0;
    Vector3 pos;
    float tempy;
    private void Start()
    {
       pos = notifimg.transform.position;
       tempy = pos.y;
    }
    void Update()
    { 
        
    }
    public void Show(string notif)
    {
        notif2 = notif;
        //StopAllCoroutines();
        StartCoroutine(Show_notif());
    }


    IEnumerator Show_notif ()
    {
        jumlah++;
       
        GameObject temp = Instantiate(notifimg, new Vector3(pos.x,pos.y,pos.z), Quaternion.identity, notifcanvas.transform);
        temp.transform.GetChild(0).GetComponent<Text>().text = notif2;
        temp.SetActive(true);
       /* for (int i = 1; i < jumlah; i++)
        {
            tempy = tempy + 90;
            notifcanvas.transform.GetChild(jumlah - 1).position = new Vector3(pos.x, tempy, pos.z);

        }*/
       if (jumlah > 1)
        {
            tempy = tempy + 90;
            notifcanvas.transform.GetChild(jumlah-1).position = new Vector3(pos.x,tempy,pos.z);
            if (jumlah > 2)
            {

                notifcanvas.transform.GetChild(jumlah - 1).position = new Vector3(pos.x, tempy, pos.z);
                notifcanvas.transform.GetChild(jumlah - 2).position = new Vector3(pos.x, tempy + 90, pos.z);
            }

        }
       
        yield return new WaitForSeconds(3);
        temp.SetActive(false);
        Destroy(temp);
        
        jumlah--;
        tempy = pos.y;
    }
    // Start is called before the first frame update
    
}
