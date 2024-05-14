using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Photo : MonoBehaviour, IDragHandler
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
    public float zoomSpeed = 0.1f;
    Vector3 OriScale;
    Vector3 OriPos;
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
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Vector3 newScale = img.transform.localScale + Vector3.one * scroll * zoomSpeed;
        img.transform.localScale = newScale;
        
    }
    public void OnDrag(PointerEventData eventData)
    {
        // Move the image based on the mouse delta
        img.rectTransform.anchoredPosition += eventData.delta;
    }
        public void ParsingFile(List<Sprite> img3, string judul)
    {
        img2 = img3;
        
        img.sprite = img2[0];
        title.text = judul;
        count = img2.Count;
        back.SetActive(false);
        next.SetActive(true);
        OriScale = img.transform.localScale;
        OriPos = img.rectTransform.anchoredPosition;
    }
    public void OnCloseButton()
    {
        img.transform.localScale= OriScale;
        img.rectTransform.anchoredPosition = OriPos;
        PhotoPanel.SetActive(false);
    }
    public void OnNextButton()
    {
        i++;
        img.sprite = img2[i];
        img.transform.localScale = OriScale;
        img.rectTransform.anchoredPosition = OriPos;
    }

    public void OnBackButton()
    {
        i--;
        img.sprite = img2[i];
        img.transform.localScale = OriScale;
        img.rectTransform.anchoredPosition = OriPos;
    }
    public void PhotoActive()
    {
        PhotoPanel.SetActive(true);
    }
}
