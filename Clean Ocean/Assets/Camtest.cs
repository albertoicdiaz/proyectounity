using UnityEngine;
using System.Collections;

public class Camtest : MonoBehaviour
{

    public Vector2 rotAngle;
    Vector3 angle;
    Vector3 tempAngle;

    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        angle.x = (Input.acceleration.y * rotAngle.y);
        angle.y = (Input.acceleration.x * rotAngle.x);
        print ("angulox: " + angle.x);
        print ("anguloy: " + angle.y);

        tempAngle = Vector3.Slerp(tempAngle, angle, Time.deltaTime * 2);

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(tempAngle), Time.deltaTime * 5);
        print("rotacion: "+transform.rotation);
    }
}