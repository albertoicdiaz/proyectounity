 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavesFollow : MonoBehaviour
{
    private GameObject boatPrefab,positionObject;
    // Start is called before the first frame update
    void Start()
    {
        boatPrefab = GameObject.Find("BoatPrefab");
        positionObject = GameObject.Find("Position");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(boatPrefab.GetComponent<Transform>().position.x-150, positionObject.GetComponent<Transform>().position.y, boatPrefab.GetComponent<Transform>().position.z-10);
    }
}
