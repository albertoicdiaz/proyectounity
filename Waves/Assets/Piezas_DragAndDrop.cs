using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Piezas_DragAndDrop : MonoBehaviour, IDragHandler
{
    public float z = 0.0f;
    public GameObject PlacePieza1, PlacePieza2,Father, Panel_correcto, Panel_incorrecto, Panel_recompensa;
    public bool placed = false;
    public Text Respuesta1, Respuesta2;
    private int contador1, contador2,aux;
    public static int final=0;
    public void OnDrag(PointerEventData eventData)
    {
        if (placed == false)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = z;
            transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
        }
    }

    void Update()
    {
        if (placed == false)
        {
            if ((transform.position != PlacePieza1.transform.position) && (transform.position != PlacePieza2.transform.position))
            {
                if (((transform.position.x <= PlacePieza1.transform.position.x + 3) && (transform.position.x >= PlacePieza1.transform.position.x - 3)) && ((transform.position.y <= PlacePieza1.transform.position.y + 3) && (transform.position.y >= PlacePieza1.transform.position.y - 3)) && transform.Find("Animal").tag == Controlador_DragNDrop.a.tag && Respuesta1.text != Controlador_DragNDrop.respuesta1.ToString())
                {

                    GameObject a = Instantiate(Father);
                    a.GetComponent<Piezas_DragAndDrop>().placed = true;
                    a.transform.position = PlacePieza1.transform.position;
                    placed = true;
                    if (this.gameObject.name == "PiezaRespuesta1")
                    {
                        transform.position = new Vector3(-63.7f, -37.5f, 96.6f);
                    }
                    else if (this.gameObject.name == "PiezaRespuesta2")
                    {
                        transform.position = new Vector3(-15.9f, -37.5f, 96.9f);
                    }
                    else if (this.gameObject.name == "PiezaRespuesta3")
                    {
                        transform.position = new Vector3(31.9f, -37.5f, 96.9f);
                    }
                    else if (this.gameObject.name == "PiezaRespuesta4")
                    {
                        transform.position = new Vector3(79.7f, -37.5f, 96.9f);
                    }
                    Invoke("UnlockedPiece", 1f);
                    contador1++;
                    Respuesta1.text = contador1.ToString();
                    if (Respuesta1.text == Controlador_DragNDrop.respuesta1.ToString())
                    {
                        final += 1;
                    }
                }

                if (((transform.position.x <= PlacePieza2.transform.position.x + 3) && (transform.position.x >= PlacePieza2.transform.position.x - 3)) && ((transform.position.y <= PlacePieza2.transform.position.y + 3) && (transform.position.y >= PlacePieza2.transform.position.y - 3)) && transform.Find("Animal").tag == Controlador_DragNDrop.c.tag && Respuesta2.text != Controlador_DragNDrop.respuesta2.ToString())
                {
                    GameObject a = Instantiate(Father);
                    a.GetComponent<Piezas_DragAndDrop>().placed = true;
                    a.transform.position = PlacePieza2.transform.position;
                    placed = true;
                    if (this.gameObject.name == "PiezaRespuesta1")
                    {
                        transform.position = new Vector3(-63.7f, -37.5f, 96.6f);
                    }
                    else if (this.gameObject.name == "PiezaRespuesta2")
                    {
                        transform.position = new Vector3(-15.9f, -37.5f, 96.9f);
                    }
                    else if (this.gameObject.name == "PiezaRespuesta3")
                    {
                        transform.position = new Vector3(31.9f, -37.5f, 96.9f);
                    }
                    else if (this.gameObject.name == "PiezaRespuesta4")
                    {
                        transform.position = new Vector3(79.7f, -37.5f, 96.9f);
                    }
                    Invoke("UnlockedPiece", 1f);
                    contador2++;
                    Respuesta2.text = contador2.ToString();
                    if (Respuesta2.text == Controlador_DragNDrop.respuesta2.ToString())
                    {
                        final += 1;
                    }
                }
            }
        }
    }
    void UnlockedPiece()
    {
        placed = false;
    }
    }
