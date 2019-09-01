using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    public static String id_actividad = "3000";
    public static String id_elemento = "1";

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
        CrearConexion();
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
            cnn.Close();
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
            cnn.Open();
            Debug.Log("Connection Open ! ");
            DateTime ahora = DateTime.Now;
            MySqlCommand query = cnn.CreateCommand();
            //query.CommandText = "INSERT INTO `ulearnet_reim_pruebas`.`alumno_respuesta_actividad` (`id_per`, `id_user`, `id_reim`, `id_actividad`, `id_elemento`, `datetime_touch`, `fila`, `columna`, `correcta`) VALUES ('"+id_per+"', '"+id_user+"', '"+id_reim+"', '"+id_actividad+"', '"+id_elemento+"', '" + ahora.ToString("yyyyMMddHHmmssffff") + "', '" + touch.position.y + "', '" + touch.position.x + "','2');";
            query.CommandText = "INSERT INTO `ulearnet_reim_pruebas`.`alumno_respuesta_actividad` (`id_per`, `id_user`, `id_reim`, `id_actividad`, `id_elemento`, `datetime_touch`, `fila`, `columna`, `correcta`) VALUES ('"+id_per+"', '"+id_user+"', '"+id_reim+"', '"+id_actividad+"', '"+id_elemento+"', '" + ahora.ToString("yyyyMMddHHmmssffff") + "', '0', '0','2');";
            //query.CommandText = "INSERT INTO pais (id,nombre) VALUES (1,'CHILE')";
            query.ExecuteNonQuery();
            cnn.Close();
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
}
