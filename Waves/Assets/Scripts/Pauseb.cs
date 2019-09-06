using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Pauseb : MonoBehaviour
{
    public GameObject  pause, ButtonPause, PanelPausa;

    // Start is called before the first frame update
    public void Pause()
    {
        PanelPausa.SetActive(true);
        GameObject.Find("AudioManager").GetComponent<AudioSource>().volume = 0.1f;
        Time.timeScale = 0; 
    }

    // Update is called once per frame
    public void Resume()
    {
        PanelPausa.SetActive(false);
        GameObject.Find("AudioManager").GetComponent<AudioSource>().volume = 1f;
        Time.timeScale = 1;   
    }
}
