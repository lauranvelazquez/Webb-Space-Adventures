using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointsController : MonoBehaviour
{
    public List<ImageData> data;
    public GameObject panel; 
    public RawImage image;
    public TextMeshProUGUI text;
    public Button close;
    public GameObject point; 


    private int _count; 

    private void Start()
    {
        _count = 0;
        close.onClick.AddListener(ClosePanel);
        point.GetComponent<Button>().onClick.AddListener(UpdateImage);
    }

    private void Update()
    {

        if (_count == 12)
        {
            //pantalla final
            SceneManager.LoadScene("EndScene");
        }
    }

    void UpdateImage()
    {
        panel.GameObject().SetActive(true);
        image.texture = data[_count].image;
        text.text = data[_count].title;
        point.GameObject().SetActive(false);
    }

    void ClosePanel()
    {
        point.GameObject().GetComponent<RectTransform>().anchoredPosition = data[_count].position;
        //point.GameObject().transform.Translate(data[_count].position.x, data[_count].position.y, 0f);
        panel.GameObject().SetActive(false);
        point.GameObject().SetActive(true);
        _count = _count + 1; 
    }
}
