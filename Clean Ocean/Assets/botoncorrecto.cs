using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class botoncorrecto : MonoBehaviour
{
    public Button btn;
    public RectTransform correcto, incorrecto,pregunta,respuestas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (GameObject.Find("Main Camera").GetComponent<deployFish>().count== 3)
        //{
        //    isCorrect();
        //}
    }
    public void isCorrect()
    {
        //Debug.Log(GameObject.Find("Main Camera").GetComponent<deployFish>().respuestacorrecta.ToString());
        pregunta.gameObject.SetActive(false);
        var aux = GameObject.Find("Moorish_idol_prefab(Clone)");
        if (aux == null)
        {
            aux = GameObject.Find("Blue_tang_prefab(Clone)");
            if (aux == null)
            {
                aux = GameObject.Find("Salmon_prefab(Clone)");
                if (aux == null)
                {
                    aux = GameObject.Find("Clownfish_prefab(Clone)");

                    if (aux == null)
                    {
                        aux = GameObject.Find("Green_turtle_prefab(Clone)");
                    }
                }
            }
        }
        aux.SetActive(false);
        

        if (btn.GetComponentInChildren<Text>().text == (GameObject.Find("Main Camera").GetComponent<deployFish>().respuestacorrecta).ToString())
        {
            correcto.gameObject.SetActive(true);
            btn.GetComponent<Image>().color = Color.green;
        }
        else
        {
            incorrecto.gameObject.SetActive(true);
        }
        respuestas.gameObject.SetActive(false);
        Invoke("RestartScene", 2f);

    }
    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
