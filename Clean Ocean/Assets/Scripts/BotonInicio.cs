﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonInicio : MonoBehaviour
{
    public GameObject btn1;
    public GameObject btn2;
    //public GameObject[] btnini;
    public RectTransform panel;
    public GameObject Slider;
    void Start()
    {
     //rotatedObject.GetComponent<RotateCamera>().enabled = false;   
     GameObject.Find("Main Camera").GetComponent<RotateCamera>().enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ini(){
        //btnini = GameObject.FindGameObjectsWithTag("inicio");
        //btn1.transform.position=new Vector3(531f, 58f,0);
        //btn2.transform.position=new Vector3(47f, 58f,0);
        panel.gameObject.SetActive(false);
        btn1.SetActive(true);
        btn2.SetActive(true);
        Slider.SetActive(true);
        //rotatedObject.GetComponent<RotateCamera>().enabled = true; 
        GameObject.Find("Main Camera").GetComponent<Camtest>().enabled=true;
        
        //for (int i = 0; i < btnini.Length; i++)
        //{
        //    Destroy(btnini[i]);
        //}
    }
    public void back()
    {
        panel.gameObject.SetActive(true);
        btn1.SetActive(false);
        btn2.SetActive(false);
        Slider.SetActive(false);
        //rotatedObject.GetComponent<RotateCamera>().enabled = true; 
        GameObject.Find("Main Camera").GetComponent<Camtest>().enabled = false;
    }
}
