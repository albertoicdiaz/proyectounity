using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gyroscope : MonoBehaviour
{
    private bool gyroEnabled;
    public static Gyroscope gyros;
    private GameObject cameraContainer;
    private Quaternion rot;

    // Start is called before the first frame update
    void Start()
    {        
        cameraContainer.transform.position = transform.position;
        transform.SetParent(cameraContainer.transform);
        gyroEnabled = EnableGyro();
    }

    // Update is called once per frame
    bool EnableGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyros = Input.gyro;
            gyros.enabled = true;
            cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
            rot = new Quaternion(0, 0, 1, 0);
            return true;
        }
        return false;

    }
    void Update()
    {
        if (gyroEnabled)
        {
            transform.localRotation = gyros.attitude * rot;
        }
    }
}
