using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collider_Laberinto : MonoBehaviour
{
    public GameObject Panel_correcto, Panel_incorrecto, Panel_recompensa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "Petroleo actLab")
        {
            GetComponent<movimientoF>().enabled = false;
            print(col.gameObject.name);
            GameObject.Find("Conexiones").GetComponent<Conexiones>().AlmacenaIncorrecto(SceneManager.GetActiveScene().name, col.gameObject.name);
            GameObject.Find("Animales").GetComponent<Recompensas>().Incorrecto(Panel_incorrecto);
        }
        else if (col.gameObject.name == "RocaE")
        {
            GetComponent<movimientoF>().enabled = false;
            print(col.gameObject.name);
            GameObject.Find("Conexiones").GetComponent<Conexiones>().AlmacenaCorrecto(SceneManager.GetActiveScene().name, col.gameObject.name);
            GameObject.Find("Animales").GetComponent<Recompensas>().Recompensa(Panel_recompensa, Panel_correcto);
        }
        else if (col.gameObject.name == "Faro actLab")
        {
            GetComponent<movimientoF>().enabled = false;
            GameObject.Find("Conexiones").GetComponent<Conexiones>().AlmacenaCorrecto(SceneManager.GetActiveScene().name, col.gameObject.name);
            GameObject.Find("Animales").GetComponent<Recompensas>().Recompensa(Panel_recompensa, Panel_correcto);
        }
        else if (col.gameObject.name == "Isla actLab")
        {
            GetComponent<movimientoF>().enabled = false;
            GameObject.Find("Conexiones").GetComponent<Conexiones>().AlmacenaCorrecto(SceneManager.GetActiveScene().name, col.gameObject.name);
            GameObject.Find("Animales").GetComponent<Recompensas>().Recompensa(Panel_recompensa, Panel_correcto);
        }
        else if (col.gameObject.name == "Muralla Invisible" || col.gameObject.tag == "Basura") 
        {
            GameObject.Find("Conexiones").GetComponent<Conexiones>().Colision(SceneManager.GetActiveScene().name, col.gameObject.name);
        }

    }

}
