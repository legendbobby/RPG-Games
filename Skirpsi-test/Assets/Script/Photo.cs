using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Photo : MonoBehaviour
{
    public Text title;
    public Button closeButton;
    public GameObject PhotoPanel;
    public Image img;
    List<Sprite> img2;
    Inventory inventory;
    int count;
    int i=0;
    public Button backButton;
    public GameObject back;
    public Button nextButton;
    public GameObject next;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count==0)
        {
            back.SetActive(false);
            next.SetActive(false);
        }
        if (i == 0)
        {
            back.SetActive(false);
        }
        else
        {
            back.SetActive(true);
            
        }
        if (i == count - 1)
        {
            next.SetActive(false);
        }
        else
        {
            next.SetActive(true);
        }
    }
    public void ParsingFile(List<Sprite> img3, string judul)
    {
        img2 = img3;
        Debug.Log("ada" + judul);
        img.sprite = img2[0];
        title.text = judul;
        count = img2.Count;
        back.SetActive(false);
        next.SetActive(true);
    }
    public void OnCloseButton()
    {
        PhotoPanel.SetActive(false);
    }
    public void OnNextButton()
    {
        i++;
        img.sprite = img2[i];
    }

    public void OnBackButton()
    {
        i--;
        img.sprite = img2[i];
    }
    public void PhotoActive()
    {
        PhotoPanel.SetActive(true);
    }
}
