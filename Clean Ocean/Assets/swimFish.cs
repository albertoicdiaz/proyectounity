using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swimFish : MonoBehaviour
{
    public GameObject rotatedObject;
    public float speed;
    public float turnspeed = 10f;
    bool rotating = false;
    private float eulerangle;
    private int eulerauxl, eulerauxr, randomrotation;
    public float smoothTime = 5.0f; //rotate over 5 seconds
    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up * turnspeed * Time.deltaTime);
        eulerangle = transform.eulerAngles.z;
        eulerauxl = (int)eulerangle;
        eulerauxr = eulerauxl - 360;
        //print("derecha" + eulerauxr);
        //print("izquierda" + eulerauxl);
        if (eulerauxl == 71)
        {
            transform.Rotate(Vector3.back * turnspeed * Time.deltaTime);
            eulerangle = transform.eulerAngles.z;
            eulerauxl = (int)eulerangle;
        }
        if (eulerauxr == -71)
        {
            transform.Rotate(Vector3.forward * turnspeed * Time.deltaTime);
            eulerangle = transform.eulerAngles.z;
            eulerauxr = (int)eulerangle;
        }
        if ((eulerauxl) <= (70) || ((eulerauxr) >= (-290)))
        {
            randomrotation = Random.Range(0, 2);
            if (randomrotation == 0)
            {
                transform.Rotate(Vector3.forward * turnspeed * Time.deltaTime);
            }
            if (randomrotation == 1)
            {
                transform.Rotate(Vector3.back * turnspeed * Time.deltaTime);
            }
        }

    }
    void OnCollisionEnter(Collision col)
    {
        print("DEBUGGG");
        if (col.gameObject.tag == "Limits")
        {
            transform.Rotate(Vector3.left * 90 * Time.deltaTime);
        }            
    }
}


    //void OnCollisionEnter(Collision col)
    //{
    //    if (col.gameObject.tag == "Limits" && !rotating) // we dont want to call this if the object is already rotating, so we check if it is
    //    {
    //        //Rotate rotatedObject by 90 degrees on the Y axis
    //        rotating = true;
    //        float rando = Random.Range(0, 100); // pick a random number between 1 and 100
    //        int multiplier = 1;
    //        if (rando > 50)
    //        {
    //            multiplier = -1;
    //        }
    //        StartCoroutine(RotateOverTime(rotatedObject.transform.localEulerAngles.y, rotatedObject.transform.localEulerAngles.y + (90 * multiplier), smoothTime));
    //    }
    //}
    //IEnumerator RotateOverTime(float currentRotation, float desiredRotation, float overTime)
    //{
    //    float i = 0.0f;
    //    while (i <= 1)
    //    {
    //        rotatedObject.transform.localEulerAngles = new Vector3(rotatedObject.transform.localEulerAngles.x, Mathf.Lerp(currentRotation, desiredRotation, i), rotatedObject.transform.localEulerAngles.z);
    //        i += Time.deltaTime / overTime;
    //        yield return null;
    //    }
    //    yield return new WaitForSeconds(overTime);
    //    rotating = false; // no longer rotating
    //}


