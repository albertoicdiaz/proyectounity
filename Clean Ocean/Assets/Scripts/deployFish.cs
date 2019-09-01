using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class deployFish : MonoBehaviour
{
    public GameObject fish1, fish2, fish3, fish4, fish5;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    private int fishtype, question, randomquestion;
    public float speed = 10f, respuestacorrecta;
    public float[] countfish;
    public int count,cantpeces;
    public Text text_panel, respuesta1, respuesta2, respuesta3;
    public RectTransform respuestas, correcto, incorrecto;
    private string text_answer1, text_answer2, text_answer3;
    //public float[] positionz;
    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //Debug.Log("alto: " + Screen.height);
        //Debug.Log("ancho: " + Screen.width);
        //Debug.Log("screenboundsx" + screenBounds.x);
        //Debug.Log("screenboundsy" + screenBounds.y);
        question = Random.Range(0, 5);
        if (question == 0)
        {
            GameObject a = Instantiate(fish1) as GameObject;
            a.GetComponent<MovementUp>().enabled = false;
            a.transform.position = new Vector3(-970, -103, -362);
        }

        if (question == 1)
        {
            GameObject a = Instantiate(fish2) as GameObject;
            a.GetComponent<MovementUp>().enabled = false;
            a.transform.position = new Vector3(-1000, -100, -362);
        }

        if (question == 2)
        {
            GameObject a = Instantiate(fish3) as GameObject;
            a.GetComponent<MovementUpTurtle>().enabled = false;
            a.transform.position = new Vector3(-990, -100, -362);
        }

        if (question == 3)
        {
            GameObject a = Instantiate(fish4) as GameObject;
            a.GetComponent<MovementUp>().enabled = false;
            a.transform.position = new Vector3(-990, -100, -362);
        }

        if (question == 4)
        {
            GameObject a = Instantiate(fish5) as GameObject;
            a.GetComponent<MovementUp>().enabled = false;
            a.transform.position = new Vector3(-970, -100, -362);
        }

        count = 1;
        countfish = new float[5];
        cantpeces = Random.Range(3, 16);
        StartCoroutine(generateFish());

    }
    private void spawnFish()
    {
        //x = Random.Range(0, 6);
        fishtype = Random.Range(0, 5);
        //fishtype = 0;

        if (fishtype == 0)
        {
            GameObject a = Instantiate(fish1) as GameObject;
            a.transform.position = new Vector2(screenBounds.x - 100, (screenBounds.y+ Random.Range(100,600)));
            countfish[0] = countfish[0] + 1;
        }

        else if (fishtype == 1)
        {
            GameObject a = Instantiate(fish2) as GameObject;
            a.transform.position = new Vector2(screenBounds.x - 100, (screenBounds.y + Random.Range(100, 650)));
            countfish[1] = countfish[1] + 1;
        }

        else if (fishtype == 2)
        {
            GameObject a = Instantiate(fish3) as GameObject;
            a.transform.position = new Vector2(screenBounds.x - 100, (screenBounds.y + Random.Range(100, 650)));
            countfish[2] = countfish[2] + 1;
        }

        else if (fishtype == 3)
        {
            GameObject a = Instantiate(fish4) as GameObject;
            a.transform.position = new Vector2(screenBounds.x - 100, (screenBounds.y + Random.Range(100, 650)));
            countfish[3] = countfish[3] + 1;
        }

        else if (fishtype == 4)
        {
            GameObject a = Instantiate(fish5) as GameObject;
            a.transform.position = new Vector2(screenBounds.x - 100, (screenBounds.y + Random.Range(100, 650)));
            countfish[4] = countfish[4] + 1;
        }


        //if (x == 0 || x == 1 || x == 2 || x == 3 || x == 4) // 0 izquierda, 1 derecha
        //{
        //    GameObject a = Instantiate(fish1) as GameObject;

        //    a.transform.position = new Vector2(screenBounds.x-20, (screenBounds.y / 2) + Random.Range(-20, 20));
        //    //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //}
        //else
        //{
        //    if (x == 5)
        //    {
        //        GameObject a = Instantiate(fishrightPrefab) as GameObject;
        //        //a.transform.position = new Vector2(374, Random.Range(450, 550));
        //        a.transform.position = new Vector2(screenBounds.x/2, (screenBounds.y / 2) + Random.Range(25, 45));
        //        a.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //    }
        //}

    }

    IEnumerator generateFish()
    {
        while (count <= cantpeces)
        {
            yield return new WaitForSeconds(respawnTime);
            //var aux = new float [1];
            //aux[0] = 2;
            //GameObject.Find("Respuesta1").GetComponentInChildren<Text>().text = (aux[0]+1).ToString();
            spawnFish();
            count += 1;

        }
        Debug.Log("contador: " + count);
        respuestacorrecta = countfish[question];
        yield return new WaitForSeconds(5);
        //¿Cuántos         ves?
        text_panel.text = ("¿Cuántos         viste?");
        randomquestion = Random.Range(0, 3);
        Debug.Log("CONTADOR FINAL DE PECES: " + countfish[question]);

        if (randomquestion == 0)
        {
            respuesta1.GetComponentInChildren<Text>().text = (countfish[question]).ToString();
            var aux1 = Random.Range(0, cantpeces);
            var aux2 = Random.Range(0, cantpeces);
            while (aux1 == respuestacorrecta || aux1 == aux2)
            {
                aux1 = Random.Range(0, cantpeces);
            }
            while (aux2 == respuestacorrecta || aux2 == aux1)
            {
                aux2 = Random.Range(0, cantpeces);
            }
            respuesta2.GetComponentInChildren<Text>().text = (aux1).ToString();
            respuesta3.GetComponentInChildren<Text>().text = (aux2).ToString();
        }

        else if (randomquestion == 1)
        {
            respuesta2.GetComponentInChildren<Text>().text = (countfish[question]).ToString();
            var aux1 = Random.Range(0, cantpeces);
            var aux2 = Random.Range(0, cantpeces);
            while (aux1 == respuestacorrecta || aux1 == aux2)
            {
                aux1 = Random.Range(0, cantpeces);
            }
            while (aux2 == respuestacorrecta || aux2 == aux1)
            {
                aux2 = Random.Range(0, cantpeces);
            }
            respuesta1.GetComponentInChildren<Text>().text = (aux1).ToString();
            respuesta3.GetComponentInChildren<Text>().text = (aux2).ToString();
        }

        else if (randomquestion == 2)
        {
            respuesta3.GetComponentInChildren<Text>().text = (countfish[question]).ToString();
            var aux1 = Random.Range(0, cantpeces);
            var aux2 = Random.Range(0, cantpeces);
            while (aux1 == respuestacorrecta || aux1 == aux2)
            {
                aux1 = Random.Range(0, cantpeces);
            }
            while (aux2 == respuestacorrecta || aux2 == aux1)
            {
                aux2 = Random.Range(0, cantpeces);
            }
            respuesta1.GetComponentInChildren<Text>().text = (aux1).ToString();
            respuesta2.GetComponentInChildren<Text>().text = (aux2).ToString();
        }
        respuestas.gameObject.SetActive(true);
    }
}
