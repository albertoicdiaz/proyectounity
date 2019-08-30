using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasuraFlotando : MonoBehaviour
{
    private float direction;
    private float speed=10f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Example());
    }

    // Update is called once per frame
    void Update()
    {


       
    }

    void ChangeDirection()
    {
        speed = speed * -1;
    }



    IEnumerator Example()
    {
        yield return new WaitForSeconds(5);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        Invoke("ChangeDirection", 5f);
    }
}
