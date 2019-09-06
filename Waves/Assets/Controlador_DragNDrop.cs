using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controlador_DragNDrop : MonoBehaviour
{
    public Text[] Operaciones;
    public Text[] Digitos;
    public static GameObject a, b, c, d;
    public GameObject[] Animales,Ocultar;
    public GameObject Panel_recompensa, Panel_correcto;
    public int x, i, y;
    private int numero1, numero2, numero3, numero4, operador1, operador2,aux=0;
    public static int respuesta1, respuesta2;
    public string[] tagsToDisable =
            {
                     "Caracol",
                     "Estrella",
                     "Erizo",
                     "Cangrejo"
                 };
    // Start is called before the first frame update
    void Start()
    {
        for (i = 0; i < Operaciones.Length; i++)
        {
            x = Random.Range(0, 2);
            if (x == 0)
            {
                Operaciones[i].text = "+";
            }
            else if (x == 1)
            {
                Operaciones[i].text = "-";
            }


        }
        for (i = 0; i < Digitos.Length; i++)
        {

            if (i == 1 || i == 3)
            {
                y = int.Parse(Digitos[i - 1].text);
                x = Random.Range(0, y);
                Digitos[i].text = x.ToString();
            }
            else
            {
                x = Random.Range(1, 10);
                Digitos[i].text = x.ToString();
            }
        }

        for (i=0; i < 2; i++)
        {

            if (i == 0)
            {
                x = Random.Range(0, 4);
                a = Instantiate(Animales[x]);
                b = Instantiate(Animales[x]);
                a.gameObject.SetActive(true);
                b.gameObject.SetActive(true);
                if (a.name == "Ammonite_prefab(Clone)")
                {
                    a.transform.position = new Vector3(-59.2f, 29.8f, 69.6f);
                    b.transform.position = new Vector3(-18.37f, 29.8f, 69.6f);
                }
                else
                {
                    a.transform.position = new Vector3(-53.43f, 29.8f, 69.6f);
                    b.transform.position = new Vector3(-12.6f, 29.8f, 69.6f);
                }
            }

            if (i == 1)
            {
                y = Random.Range(0, 4);
                while (y == x)
                {
                    y = Random.Range(0, 4);
                }
                c = Instantiate(Animales[y]);
                d = Instantiate(Animales[y]);
                c.gameObject.SetActive(true);
                d.gameObject.SetActive(true);
                if (c.name == "Ammonite_prefab(Clone)")
                {
                    c.transform.position = new Vector3(12.2f, 29.8f, 69.6f);
                    d.transform.position = new Vector3(54.1f, 29.8f, 69.6f);
                }
                else
                {
                    c.transform.position = new Vector3(22.17f, 29.8f, 69.6f);
                    d.transform.position = new Vector3(63f, 29.8f, 69.6f);
                }
            }
        }

        numero1 = int.Parse(Digitos[0].text);
        numero2 = int.Parse(Digitos[1].text);
        numero3 = int.Parse(Digitos[2].text);
        numero4 = int.Parse(Digitos[3].text);

        for (i = 0; i < Operaciones.Length; i++)
        {
            if (Operaciones[i].text == "-")
            {
                if (i == 0)
                {
                    respuesta1 = numero1 - numero2;
                }
                if (i == 1)
                {
                    respuesta2 = numero3 - numero4;
                }
            }
            if (Operaciones[i].text == "+")
            {
                if (i == 0)
                {
                    respuesta1 = numero1 + numero2;
                }
                if (i == 1)
                {
                    respuesta2 = numero3 + numero4;
                }
            }
        }
        print(respuesta1);
        print(respuesta2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Piezas_DragAndDrop.final == 2 && aux == 0)
        {
            GameObject.Find("Shark").SetActive(false);

            GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("Ocultar");
            GameObject[] gameObjectArray2 = GameObject.FindGameObjectsWithTag("Pieza");
            GameObject[] gameObjectArray3 = GameObject.FindGameObjectsWithTag("Cangrejo");
            GameObject[] gameObjectArray4 = GameObject.FindGameObjectsWithTag("Estrella");
            GameObject[] gameObjectArray5 = GameObject.FindGameObjectsWithTag("Caracol");
            GameObject[] gameObjectArray6 = GameObject.FindGameObjectsWithTag("Erizo");

            foreach (GameObject go in gameObjectArray)
            {
                go.SetActive(false);
            }
            foreach (GameObject go in gameObjectArray2)
            {
                go.SetActive(false);
            }
            foreach (GameObject go in gameObjectArray3)
            {
                go.SetActive(false);
            }
            foreach (GameObject go in gameObjectArray4)
            {
                go.SetActive(false);
            }
            foreach (GameObject go in gameObjectArray5)
            {
                go.SetActive(false);
            }
            foreach (GameObject go in gameObjectArray6)
            {
                go.SetActive(false);
            }
            GameObject.Find("Conexiones").GetComponent<Conexiones>().AlmacenaCorrecto(SceneManager.GetActiveScene().name);
            GameObject.Find("Animales").GetComponent<Recompensas>().Recompensa(Panel_recompensa, Panel_correcto);
            aux += 1;
            Piezas_DragAndDrop.final = 0;
        }
    }
}
