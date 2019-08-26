 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavesFollowLaberynth : MonoBehaviour
{
    public GameObject boatPrefab,positionObject;
    // Start is called before the first frame update
    void Start()
    {
        //boatPrefab = GameObject.Find("/BoatPrefab");
        //positionObject = GameObject.Find("Position");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(boatPrefab.GetComponent<Transform>().position.x-33, positionObject.GetComponent<Transform>().position.y, boatPrefab.GetComponent<Transform>().position.z-54);
    }
}
