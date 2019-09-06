using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using MySql.Data.MySqlClient;
using System;

public class Conexiones : MonoBehaviour
{
    public static Conexiones conexion;
    public static String connetionString = "host=ulearnet.org; Port =3306; UserName=reim_ulearnet; Password=KsclS$AcSx.20Cv83xT; Database=ulearnet_reim_pruebas;";
    public static MySqlConnection cnn = new MySqlConnection(connetionString);
    public static String id_per = "201902";
    public static String id_user = "1";
    public static String id_reim = "3";
    public static String id_actividad;
    public static String id_elemento;
    public Touch touch;
    TouchPhase touchPhase = TouchPhase.Ended;

    void Awake()
    {
        if (conexion == null)
        {
            conexion = this;
            DontDestroyOnLoad(gameObject);
        }else if(conexion != this)
        {
            Destroy(gameObject);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        CrearConexion();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == touchPhase)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow, 100f);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                if (hit.collider != null)
                {

                    GameObject touchedObject = hit.transform.gameObject;

                    Debug.Log("Touched " + touchedObject.transform.name);
                    if (touchedObject.transform.name == "Boton play")
                    {
                        id_elemento = 3000.ToString();
                    }
                    else if (touchedObject.transform.name == "Boton volver")
                    {
                        id_elemento = 3001.ToString();
                    }
                    else if (touchedObject.transform.name == "Boton avanzar")
                    {
                        id_elemento = 3002.ToString();
                    }
                    else if (touchedObject.transform.name == "actividadLancha")
                    {
                        id_elemento = 3003.ToString();
                    }
                    else if (touchedObject.transform.name == "actividadLaberinto")
                    {
                        id_elemento = 3004.ToString();
                    }
                    else if (touchedObject.transform.name == "actividadDibujo")
                    {
                        id_elemento = 3005.ToString();
                    }
                    else if (touchedObject.transform.name == "actividadSuma")
                    {
                        id_elemento = 3006.ToString();
                    }
                    else if (touchedObject.transform.name == "Boton musica on")
                    {
                        id_elemento = 3007.ToString();
                    }
                    else if (touchedObject.transform.name == "Boton pausa")
                    {
                        id_elemento = 3008.ToString();
                    }
                    else if (touchedObject.transform.name == "Boton reinicio")
                    {
                        id_elemento = 3009.ToString();
                    }
                    else if (touchedObject.transform.name == "Respuesta alumno actsuma")
                    {
                        id_elemento = 3010.ToString();
                    }
                    else if (touchedObject.transform.name == "Respuesta correcta actsuma")
                    {
                        id_elemento = 3011.ToString();
                    }
                    else if (touchedObject.transform.name == "Pez payaso")
                    {
                        id_elemento = 3012.ToString();
                    }
                    else if (touchedObject.transform.name == "Boton instrucciones audio")
                    {
                        id_elemento = 3013.ToString();
                    }
                    else if (touchedObject.transform.name == "actividadDrag")
                    {
                        id_elemento = 3014.ToString();
                    }
                    else if (touchedObject.transform.name == "Background")
                    {
                        id_elemento = 3015.ToString();
                    }
                    else if (touchedObject.transform.name == "Agua" || touchedObject.transform.name == "Waves")
                    {
                        id_elemento = 3016.ToString();
                    }
                    else if (touchedObject.transform.name == "Coral")
                    {
                        id_elemento = 3017.ToString();
                    }
                    else if (touchedObject.transform.name == "RocaGrande")
                    {
                        id_elemento = 3018.ToString();
                    }
                    else if (touchedObject.transform.name == "Basura Barril" || touchedObject.transform.name == "Barril" || touchedObject.transform.name == "BarrilPrefab" || touchedObject.transform.name == "Basura5" || touchedObject.transform.name == "Basura9")
                    {
                        id_elemento = 3019.ToString();
                    }
                    else if (touchedObject.transform.name == "RocaPequeña")
                    {
                        id_elemento = 3020.ToString();
                    }
                    else if (touchedObject.transform.name == "Ballena")
                    {
                        id_elemento = 3021.ToString();
                    }
                    else if (touchedObject.transform.name == "Shark" || touchedObject.transform.name == "Tiburon blanco" || touchedObject.transform.name == "Tiburon Blanco")
                    {
                        id_elemento = 3022.ToString();
                    }
                    else if (touchedObject.transform.name == "Tiburon toro")
                    {
                        id_elemento = 3023.ToString();
                    }
                    else if (touchedObject.transform.name == "Orca")
                    {
                        id_elemento = 3024.ToString();
                    }
                    else if (touchedObject.transform.name == "Delfin")
                    {
                        id_elemento = 3025.ToString();
                    }
                    else if (touchedObject.transform.name == "Pulpo")
                    {
                        id_elemento = 3026.ToString();
                    }
                    else if (touchedObject.transform.name == "Calamar")
                    {
                        id_elemento = 3027.ToString();
                    }
                    else if (touchedObject.transform.name == "Pez sol")
                    {
                        id_elemento = 3028.ToString();
                    }
                    else if (touchedObject.transform.name == "Pez cofre")
                    {
                        id_elemento = 3029.ToString();
                    }
                    else if (touchedObject.transform.name == "Pez mariposa")
                    {
                        id_elemento = 3030.ToString();
                    }
                    //else if (touchedObject.transform.name == "Pez mariposa")
                    //{
                    //    id_elemento = 3031.ToString();
                    //}
                    else if (touchedObject.transform.name == "Pez luna")
                    {
                        id_elemento = 3031.ToString();
                    }
                    else if (touchedObject.transform.name == "Pez leon")
                    {
                        id_elemento = 3032.ToString();
                    }
                    else if (touchedObject.transform.name == "Mantarraya")
                    {
                        id_elemento = 3033.ToString();
                    }
                    else if (touchedObject.transform.name == "Tortuga")
                    {
                        id_elemento = 3034.ToString();
                    }
                    else if (touchedObject.transform.name == "Salmon")
                    {
                        id_elemento = 3035.ToString();
                    }
                    else if (touchedObject.transform.name == "Sardina")
                    {
                        id_elemento = 3036.ToString();
                    }
                    else if (touchedObject.transform.name == "Pez idolo moro")
                    {
                        id_elemento = 3037.ToString();
                    }
                    else if (touchedObject.transform.name == "Pez cirujano purpura")
                    {
                        id_elemento = 3038.ToString();
                    }
                    else if (touchedObject.transform.name == "Salmon rojo")
                    {
                        id_elemento = 3039.ToString();
                    }
                    else if (touchedObject.transform.name == "Basura Vaso" || touchedObject.transform.name == "Vaso" || touchedObject.transform.name == "Basura1" || touchedObject.transform.name == "Basura4" || touchedObject.transform.name == "Basura13" || touchedObject.transform.name == "Basura17")
                    {
                        id_elemento = 3040.ToString();
                    }
                    else if (touchedObject.transform.name == "Basura Bolsa" || touchedObject.transform.name == "Bolsa" || touchedObject.transform.name == "BolsaPrefab" || touchedObject.transform.name == "Basura2" || touchedObject.transform.name == "Basura8" || touchedObject.transform.name == "Basura12" || touchedObject.transform.name == "Basura16" || touchedObject.transform.name == "Basura19" || touchedObject.transform.name == "BasuraPrefab")
                    {
                        id_elemento = 3041.ToString();
                    }
                    else if (touchedObject.transform.name == "Basura Botella azul" || touchedObject.transform.name == "Botella azul" || touchedObject.transform.name == "Basura3" || touchedObject.transform.name == "Basura11")
                    {
                        id_elemento = 3042.ToString();
                    }
                    else if (touchedObject.transform.name == "Basura Botella verde" || touchedObject.transform.name == "Botella verde" || touchedObject.transform.name == "Basura6" || touchedObject.transform.name == "Basura7" || touchedObject.transform.name == "Basura10" || touchedObject.transform.name == "Basura15" || touchedObject.transform.name == "Basura18")
                    {
                        id_elemento = 3043.ToString();
                    }
                    else if (touchedObject.transform.name == "Basura spray" || touchedObject.transform.name == "Basura14" || touchedObject.transform.name == "Basura20" || touchedObject.transform.name == "Spray")
                    {
                        id_elemento = 3044.ToString();
                    }
                    else if (touchedObject.transform.name == "Pelota actividades")
                    {
                        id_elemento = 3045.ToString();
                    }
                    else if (touchedObject.transform.name == "isla actLancha")
                    {
                        id_elemento = 3046.ToString();
                    }
                    else if (touchedObject.transform.name == "Lancha" || touchedObject.transform.name == "BoatPrefab")
                    {
                        id_elemento = 3047.ToString();
                    }
                    else if (touchedObject.transform.name == "Pelota actLab")
                    {
                        id_elemento = 3048.ToString();
                    }
                    else if (touchedObject.transform.name == "Petroleo actLab")
                    {
                        id_elemento = 3049.ToString();
                    }
                    else if (touchedObject.transform.name == "Isla actLab")
                    {
                        id_elemento = 3050.ToString();
                    }
                    else if (touchedObject.transform.name == "Faro actLab")
                    {
                        id_elemento = 3051.ToString();
                    }
                    else if (touchedObject.transform.name == "Elefante marino actLab")
                    {
                        id_elemento = 3052.ToString();
                    }
                    else if (touchedObject.transform.name == "Boyas actDibujo")
                    {
                        id_elemento = 3053.ToString();
                    }
                    else if (touchedObject.transform.name == "Barco actDibujo")
                    {
                        id_elemento = 3054.ToString();
                    }
                    else if (touchedObject.transform.name == "Panelpregunta actSuma")
                    {
                        id_elemento = 3055.ToString();
                    }
                    else if (touchedObject.transform.name == "Pez cirujano azul")
                    {
                        id_elemento = 3056.ToString();
                    }
                    else if (touchedObject.transform.name == "Panel respuestas actSuma")
                    {
                        id_elemento = 3057.ToString();
                    }
                    else if (touchedObject.transform.name == "Panel recompensa")
                    {
                        id_elemento = 3058.ToString();
                    }
                    else if (touchedObject.transform.name == "Recompensa")
                    {
                        id_elemento = 3059.ToString();
                    }
                    else if (touchedObject.transform.name == "Concha actDibujo")
                    {
                        id_elemento = 3060.ToString();
                    }
                    else if (touchedObject.transform.name == "Estrella de mar")
                    {
                        id_elemento = 3061.ToString();
                    }
                    else if (touchedObject.transform.name == "Erizo de mar")
                    {
                        id_elemento = 3062.ToString();
                    }
                    else if (touchedObject.transform.name == "Cangrejo")
                    {
                        id_elemento = 3063.ToString();
                    }
                    else if (touchedObject.transform.name == "Cangrejo ermitaño")
                    {
                        id_elemento = 3064.ToString();
                    }
                    else if (touchedObject.transform.name == "Pieza pregunta")
                    {
                        id_elemento = 3065.ToString();
                    }
                    else if (touchedObject.transform.name == "Pieza respuesta")
                    {
                        id_elemento = 3066.ToString();
                    }
                    else if (touchedObject.transform.name == "Boton instrucciones texto")
                    {
                        id_elemento = 3067.ToString();
                    }
                    else if (touchedObject.transform.name == "BasuraRueda" || touchedObject.transform.name == "RuedaPrefab")
                    {
                        id_elemento = 3068.ToString();
                    }
                    else if (touchedObject.transform.name == "Basura Leche")
                    {
                        id_elemento = 3069.ToString();
                    }
                    else if (touchedObject.transform.name == "Respuesta1")
                    {
                        id_elemento = 3070.ToString();
                    }
                    else if (touchedObject.transform.name == "Respuesta2")
                    {
                        id_elemento = 3071.ToString();
                    }
                    else if (touchedObject.transform.name == "Respuesta3")
                    {
                        id_elemento = 3072.ToString();
                    }

                    // PANTALLAS DEL JUEGO

                    if (SceneManager.GetActiveScene().name == "Progreso")
                    {
                        id_actividad = 3000.ToString();
                    }
                    else if (SceneManager.GetActiveScene().name == "Actividad Tesoro")
                    {
                        id_actividad = 3005.ToString();
                    }
                    else if (SceneManager.GetActiveScene().name == "Actividad Drag And Drop")
                    {
                        id_actividad = 3006.ToString();
                    }
                    else if (SceneManager.GetActiveScene().name == "Actividad Laberinto")
                    {
                        id_actividad = 3004.ToString();
                    }
                    else if (SceneManager.GetActiveScene().name == "Actividad Lancha")
                    {
                        id_actividad = 3002.ToString();
                    }
                    else if (SceneManager.GetActiveScene().name == "Actividad suma")
                    {
                        id_actividad = 3003.ToString();
                    }
                    else if (SceneManager.GetActiveScene().name == "MainMenu")
                    {
                        id_actividad = 3001.ToString();
                    }

                    if (id_actividad != "0" && id_elemento != "0")
                    {
                        //cnn.Open();
                        Debug.Log("Voy a registrar");
                        DateTime ahora = DateTime.Now;
                        MySqlCommand query = cnn.CreateCommand();
                        touch = Input.GetTouch(0);
                        query.CommandText = "INSERT INTO `ulearnet_reim_pruebas`.`alumno_respuesta_actividad` (`id_per`, `id_user`, `id_reim`, `id_actividad`, `id_elemento`, `datetime_touch`, `fila`, `columna`, `correcta`) VALUES ('" + id_per + "', '" + id_user + "', '" + id_reim + "', '" + id_actividad + "', '" + id_elemento + "', '" + ahora.ToString("yyyyMMddHHmmssffff") + "', '" + touch.position.y + "', '" + touch.position.x + "','2');";
                        query.ExecuteNonQuery();
                        //cnn.Close();
                        Debug.Log("Connection Closed!");
                        print("REGISTRÉ");
                        id_elemento = "0";
                        id_actividad = "0";
                    }

                    }
                }
            }
        }

    public void CrearConexion()
    {
        string connetionString = null;
        connetionString = "host=ulearnet.org; Port =3306; UserName=reim_ulearnet; Password=KsclS$AcSx.20Cv83xT; Database=ulearnet_reim_pruebas;";
        //"server=localhost;database=testDB;uid=root;pwd=abc123;";
        cnn = new MySqlConnection(connetionString);
        try
        {
            cnn.Open();
            Debug.Log("Connection Open ! ");
            //DateTime ahora = DateTime.Now;
            //MySqlCommand query = cnn.CreateCommand();
            //query.CommandText = "INSERT INTO `ulearnet_reim_pruebas`.`alumno_respuesta_actividad` (`id_per`, `id_user`, `id_reim`, `id_actividad`, `id_elemento`, `datetime_touch`, `fila`, `columna`, `correcta`) VALUES ('201902', '1', '1', '1', '1', '" + ahora.ToString("yyyyMMddHHmmssffff") + "', '" + touch.position.y + "', '" + touch.position.x + "','2');";
            //query.CommandText = "INSERT INTO pais (id,nombre) VALUES (1,'CHILE')";
            //query.ExecuteNonQuery();

            //cnn.Close();
            Debug.Log("Connection Closed!");
        }
        catch (Exception ex)
        {
            Debug.Log("Can not open connection ! " + ex);
        }
    }

    public void Boton()
    {
        try
        {
            //Touch touch = Input.GetTouch(0);
           //cnn.Open();
            Debug.Log("Connection Open ! ");
            DateTime ahora = DateTime.Now;
            MySqlCommand query = cnn.CreateCommand();
            //query.CommandText = "INSERT INTO `ulearnet_reim_pruebas`.`alumno_respuesta_actividad` (`id_per`, `id_user`, `id_reim`, `id_actividad`, `id_elemento`, `datetime_touch`, `fila`, `columna`, `correcta`) VALUES ('"+id_per+"', '"+id_user+"', '"+id_reim+"', '"+id_actividad+"', '"+id_elemento+"', '" + ahora.ToString("yyyyMMddHHmmssffff") + "', '" + touch.position.y + "', '" + touch.position.x + "','2');";
            query.CommandText = "INSERT INTO `ulearnet_reim_pruebas`.`alumno_respuesta_actividad` (`id_per`, `id_user`, `id_reim`, `id_actividad`, `id_elemento`, `datetime_touch`, `fila`, `columna`, `correcta`) VALUES ('"+id_per+"', '"+id_user+"', '"+id_reim+"', '"+id_actividad+"', '"+id_elemento+"', '" + ahora.ToString("yyyyMMddHHmmssffff") + "', '0', '0','2');";
            //query.CommandText = "INSERT INTO pais (id,nombre) VALUES (1,'CHILE')";
            query.ExecuteNonQuery();
            //cnn.Close();
            Debug.Log("Connection Closed!");
        }
        catch (Exception ex)
        {
            Debug.Log("Can not open connection ! " + ex);
        }
    }

    public void SetActividad(String act)
    {
        id_actividad = act;
    }

    public void SetElemento(String elm)
    {
        id_elemento = elm;
    }

    public void AlmacenaCorrecto(string SceneActive, string respuesta="false")
    {
        if (SceneActive == "Actividad Tesoro")
        {
            id_actividad = 3005.ToString();
            id_elemento = "3059";
        }
        else if (SceneActive == "Actividad Drag and Drop")
        {
            id_actividad = 3006.ToString();
            id_elemento = "3059";
        }
        else if (SceneActive == "Actividad Laberinto")
        {
            id_actividad = 3004.ToString();
            if (respuesta == "RocaE")
            {
                id_elemento = 3052.ToString();
            }
            else if (respuesta == "Faro actLab")
            {
                id_elemento = 3051.ToString();
            }
            else if (respuesta == "Isla actLab")
            {
                id_elemento = 3050.ToString();
            }
        }
        else if (SceneActive == "Actividad Lancha")
        {
            id_actividad = 3002.ToString();
            id_elemento = "3059";
        }
        else if (SceneActive == "Actividad suma")
        {
            id_actividad = 3003.ToString();
            if (respuesta == "Respuesta1")
            {
                id_elemento = 3070.ToString();
            }
            else if (respuesta == "Respuesta2")
            {
                id_elemento = 3071.ToString();
            }
            else if (respuesta == "Respuesta3")
            {
                id_elemento = 3072.ToString();
            }
        }
        //cnn.Open();
        Debug.Log("Connection Open ! ");
        DateTime ahora = DateTime.Now;
        MySqlCommand query = cnn.CreateCommand();
        //touch = Input.GetTouch(0);
        query.CommandText = "INSERT INTO `ulearnet_reim_pruebas`.`alumno_respuesta_actividad` (`id_per`, `id_user`, `id_reim`, `id_actividad`, `id_elemento`, `datetime_touch`, `fila`, `columna`, `correcta`) VALUES ('" + id_per + "', '" + id_user + "', '" + id_reim + "', '" + id_actividad + "', '" + id_elemento + "', '" + ahora.ToString("yyyyMMddHHmmssffff") + "', '" + 0 + "', '" + 0 + "','1');";
        query.ExecuteNonQuery();
        //cnn.Close();
        Debug.Log("Connection Closed!");
        print("REGISTRÉ CORRECTO");
        id_elemento = "0";
        id_actividad = "0";

    }
    public void AlmacenaIncorrecto(string SceneActive, string respuesta="false")
    {
        if (SceneActive == "Actividad Tesoro")
        {
            id_actividad = 3005.ToString();
            id_elemento = "3059";
        }
        else if (SceneActive == "Actividad Drag and Drop")
        {
            id_actividad = 3006.ToString();
            id_elemento = "3059";
        }
        else if (SceneActive == "Actividad Laberinto")
        {
            id_actividad = 3004.ToString();
            id_elemento = 3049.ToString();
        }
        else if (SceneActive == "Actividad Lancha")
        {
            id_actividad = 3002.ToString();
            id_elemento = "3059";
        }
        else if (SceneActive == "Actividad suma")
        {
            id_actividad = 3003.ToString();
            if (respuesta == "Respuesta1")
            {
                id_elemento = 3070.ToString();
            }
            else if (respuesta == "Respuesta2")
            {
                id_elemento = 3071.ToString();
            }
            else if (respuesta == "Respuesta3")
            {
                id_elemento = 3072.ToString();
            }
        }
        //cnn.Open();
        Debug.Log("Connection Open ! ");
        DateTime ahora = DateTime.Now;
        MySqlCommand query = cnn.CreateCommand();
        query.CommandText = "INSERT INTO `ulearnet_reim_pruebas`.`alumno_respuesta_actividad` (`id_per`, `id_user`, `id_reim`, `id_actividad`, `id_elemento`, `datetime_touch`, `fila`, `columna`, `correcta`) VALUES ('" + id_per + "', '" + id_user + "', '" + id_reim + "', '" + id_actividad + "', '" + id_elemento + "', '" + ahora.ToString("yyyyMMddHHmmssffff") + "', '" + 0 + "', '" + 0 + "','0');";
        query.ExecuteNonQuery();
        //cnn.Close();
        print("REGISTRÉ INCORRECTO");
        id_elemento = "0";
        id_actividad = "0";

    }

    public void Colision(string SceneActive, string respuesta = "false")
    {
        if (SceneActive == "Actividad Drag and Drop")
        {
            id_elemento = 3066.ToString();
            id_actividad = 3006.ToString();
        }
        else if (SceneActive == "Actividad Laberinto")
        {
            id_actividad = 3004.ToString();
            if (respuesta == "Basura Vaso")
            {
                id_elemento = "3040";
            }
            else if (respuesta == "Basura Bolsa")
            {
                id_elemento = 3041.ToString();
            }
            else if (respuesta == "Basura Leche")
            {
                id_elemento = 3069.ToString();
            }
            else if (respuesta == "Basura Botella azul")
            {
                id_elemento = 3042.ToString();
            }
        }
        else if (SceneActive == "Actividad Lancha")
        {
            if (respuesta == "BasuraPrefab")
            {
                id_elemento = 3041.ToString();
            }
            else if (respuesta == "RuedaPrefab")
            {
                id_elemento = 3068.ToString();
            }
            else if (respuesta == "BarrilPrefab")
            {
                id_elemento = 3019.ToString();
            }
            id_actividad = 3002.ToString();
        }

        //cnn.Open();
        Debug.Log("Connection Open ! ");
        DateTime ahora = DateTime.Now;
        MySqlCommand query = cnn.CreateCommand();
        //id_elemento = "3059";
        query.CommandText = "INSERT INTO `ulearnet_reim_pruebas`.`alumno_respuesta_actividad` (`id_per`, `id_user`, `id_reim`, `id_actividad`, `id_elemento`, `datetime_touch`, `fila`, `columna`, `correcta`) VALUES ('" + id_per + "', '" + id_user + "', '" + id_reim + "', '" + id_actividad + "', '" + id_elemento + "', '" + ahora.ToString("yyyyMMddHHmmssffff") + "', '" + 0 + "', '" + 0 + "','3');";
        query.ExecuteNonQuery();
        //cnn.Close();
        Debug.Log("Connection Closed!");
        print("REGISTRÉ Colision");
        id_elemento = "0";
        id_actividad = "0";

    }

}
