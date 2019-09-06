using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotnPanel : MonoBehaviour
{
    public ShakeDemo shakedemo;
    public int pasosrandom;
    public GameObject Panel;
    public Text textofaro;
    public bool activo = false;
    public BotnPanel btnFaro;
    public BotnPanel btnVolcan;
    public BotnPanel btnCalavera;
    public Button faro;
    public Button volcan;
    public Button calavera;
    public Text Textollevo;

    private void Start()
    {
        if (this.gameObject.name == "Button_volcan")
        {
            volcan.interactable = false;
        }
        else if (this.gameObject.name == "Button_calavera")
        {
            calavera.interactable = false;
        }
    }
    private void Update()
    {
        Textollevo.text = "Llevas " + shakedemo.pasos + " pasos";
    }
    public void OpenPanel()
    {
        if (this.gameObject.name == "Button_faro")
        {
            if (Panel != null)
            {
                bool isActive = Panel.activeSelf;
                Panel.SetActive(!isActive);
                shakedemo.ResetShakeCount();
                activo = true;
                pasosrandom = Random.Range(1, 21);
                textofaro.text = "Da " + pasosrandom + " Pasos";
            }
        }
        else if (this.gameObject.name == "Button_volcan")
        {
            if (btnFaro.activo==true) {
                if (Panel != null)
                {
                    bool isActive = Panel.activeSelf;
                    Panel.SetActive(!isActive);
                    shakedemo.ResetShakeCount();
                    activo = true;
                    pasosrandom = Random.Range(1, 21);
                    textofaro.text = "Da " + pasosrandom;
                }
            }
        }
        else if (this.gameObject.name == "Button_calavera")
        {
            if (btnVolcan.activo == true)
            {
                if (Panel != null)
                {
                    bool isActive = Panel.activeSelf;
                    Panel.SetActive(!isActive);
                    shakedemo.ResetShakeCount();
                    activo = true;
                    pasosrandom = Random.Range(1, 21);
                    textofaro.text = "Da " + pasosrandom;
                }
            }
        }
    }
    public void botonvolcan()
    {
        
        if (shakedemo.pasos == pasosrandom)
        {
            Panel.SetActive(false);
            if (this.gameObject.name=="faro") { faro.interactable = false; volcan.interactable = true; }
            else if (this.gameObject.name == "volcan") { volcan.interactable = false; calavera.interactable = true; }
        }
    }
}
