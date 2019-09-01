using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Recompensas : MonoBehaviour
{
    public GameObject[] Animales, Animalaux = new GameObject[20], Basura = new GameObject[20];
    public int x;
    public static int contadoranimales,porcentaje,act;
    public GameObject Panel_recompensas;
    public GameObject Rotatefish;
    public GameObject Slider;
    private Vector3 camerapos;


    //Scene currentScene = SceneManager.GetActiveScene();
    // Start is called before the first frame update

    //void Awake()
    //{
    //    //if we don't have an [_instance] set yet
    //    if (!Recompensas)
    //        Recompensas = this;
    //    //otherwise, if we do, kill this thing
    //    else
    //        Destroy(this.gameObject);


    //    DontDestroyOnLoad(this.gameObject);
    //}

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (GameObject.Find(gameObject.name)
                  && GameObject.Find(gameObject.name) != this.gameObject)
        {
            Destroy(GameObject.Find(gameObject.name));
        }

        if (SceneManager.GetActiveScene().name == "Progreso")
        {
            print(Animalaux.Length);
            for (x = 0; x <= 19; x++)
            {
                Animalaux[x] = GameObject.Find(Animales[x].name);
                Animalaux[x].SetActive(false);
                //print("basura" + (x + 1).ToString());
                //Basura[x].SetActive(false);
            }
            for (x = 0; x <= 19; x++)
            {

                //Basura[x] = GameObject.Find("basura" + (x + 1).ToString());
                //print(x);
                Basura[x].SetActive(false);
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Progreso")
        {
            PorcentajeProgreso();
        }
        porcentaje = BarraProgreso.act;
    }

    public void Recompensa()
    {
        
        if (BarraProgreso.act <= 95)
        {
            BarraProgreso.act += 5;
        }
            if (contadoranimales == 20)
            {

            }
            else
            {
                
                    Panel_recompensas.gameObject.SetActive(true);
                    //camerapos = GameObject.Find("Main Camera").GetComponent<Transform>().position;
                    GameObject a = Instantiate(Animales[contadoranimales]) as GameObject;
                    a.gameObject.SetActive(false);
                    a.GetComponent<Rotatefish>().enabled = true;
                    //a.transform.position = camerapos;
                    if (contadoranimales == 4) //pulpo
                    {
                        a.transform.position = new Vector3(GameObject.Find("Main Camera").GetComponent<Transform>().position.x, GameObject.Find("Main Camera").GetComponent<Transform>().position.y - 0.97f, GameObject.Find("Main Camera").GetComponent<Transform>().position.z + 10.2f);
                    }
                    else if (contadoranimales == 5)
                    {
                        a.transform.position = new Vector3(GameObject.Find("Main Camera").GetComponent<Transform>().position.x, GameObject.Find("Main Camera").GetComponent<Transform>().position.y - 3.6f, GameObject.Find("Main Camera").GetComponent<Transform>().position.z + 17.46f);
                    }
                    else if (contadoranimales == 10)
                    {
                        a.transform.position = new Vector3(GameObject.Find("Main Camera").GetComponent<Transform>().position.x, GameObject.Find("Main Camera").GetComponent<Transform>().position.y - 3.2f, GameObject.Find("Main Camera").GetComponent<Transform>().position.z + 19.51f);
                    }
                    else if (contadoranimales == 11)
                    {
                        a.transform.position = new Vector3(GameObject.Find("Main Camera").GetComponent<Transform>().position.x, GameObject.Find("Main Camera").GetComponent<Transform>().position.y - 2.8f, GameObject.Find("Main Camera").GetComponent<Transform>().position.z + 13.5f);
                    }
                    else if (contadoranimales == 12)
                    {
                        a.transform.position = new Vector3(GameObject.Find("Main Camera").GetComponent<Transform>().position.x, GameObject.Find("Main Camera").GetComponent<Transform>().position.y - 2.3f, GameObject.Find("Main Camera").GetComponent<Transform>().position.z + 15.7f);
                    }
                    else
                    {
                        a.transform.position = new Vector3(GameObject.Find("Main Camera").GetComponent<Transform>().position.x, GameObject.Find("Main Camera").GetComponent<Transform>().position.y - 1.4f, GameObject.Find("Main Camera").GetComponent<Transform>().position.z + 8.16f);
                    }

                    a.gameObject.SetActive(true);
                    Invoke("RestartScene", 5f);
                    //if (contadoranimales==
                    contadoranimales += 1;
                
            }
        }
    void PorcentajeProgreso()
    {
        BarraProgreso.act = contadoranimales*5 ;
        for (x = contadoranimales; x >= 0; x--)
        {
            Animalaux[x].SetActive(true);
        }
        for (x = contadoranimales; x <= 19; x++)
        {
            Basura[x].SetActive(true);
        }

        //  print(aux);
    }
    


    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

