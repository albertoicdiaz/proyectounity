﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0f, 0f, 3f, Space.Self);
        transform.Rotate(new Vector3(0,1f,0));
    }
}
