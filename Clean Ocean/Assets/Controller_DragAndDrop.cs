﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Controller_DragAndDrop : MonoBehaviour, IDropHandler
{
    // Start is called before the first frame update
    public void  OnDrop (PointerEventData evenData)
    {
        RectTransform invPanel = transform as RectTransform;
        if(!RectTransformUtility.RectangleContainsScreenPoint(invPanel, Input.mousePosition)){
            Debug.Log("Drop item");
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
