using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraProgreso : MonoBehaviour
{
    Slider Barra;

    public float max;
    public int act;
    public Text ValorString;

    // Start is called before the first frame update

    void Awake(){
        Barra = GetComponent<Slider> ();
    }

    void Update(){
        ActualizarValorBarra (max, act);
    }
    void ActualizarValorBarra(float ValorMax, float ValorAct ){
        float porcentaje;
        porcentaje = ValorAct / ValorMax;
        Barra.value = porcentaje;
        ValorString.text = porcentaje*100 + "%";
    }
}
