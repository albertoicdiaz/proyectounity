using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployObjects : MonoBehaviour {
    public GameObject objectPrefab, boatPrefab, Trash;
    public float respawnTime = 1.0f;
    //private Vector2 screenBounds;
    private int x,count,trashtype;
    private float z;

    // Use this for initialization
    void Start () {
      //  screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(generateTrash());
        z = 190;
        count = 1;
    }
    private void spawnTrash(){
        //b=boatPrefab.GetComponent<Transform>().position.z;
        //Debug.Log(b);
        x = Random.Range(-22, 120);
        trashtype = Random.Range(1, 10);
        if (trashtype == 1)
        {
            Trash = GameObject.Find("/BarrilPrefab");
            Trash.transform.position = new Vector3(x, 1, z);
        }

        if (trashtype == 2)
        {
            Trash = GameObject.Find("/BasuraPrefab");
            Trash.transform.position = new Vector3(x, 1, z);
        }

        if (trashtype == 3)
        {
            Trash = GameObject.Find("/BotellaPrefab");
            Trash.transform.position = new Vector3(x, 1, z);
        }

        if (trashtype == 4)
        {
            Trash = GameObject.Find("/BottlePrefab");
            Trash.transform.position = new Vector3(x, 1, z);
        }

        if (trashtype == 5)
        {
            Trash = GameObject.Find("/LataPrefab");
            Trash.transform.position = new Vector3(x, 1, z);
        }
        if (trashtype == 6)
        {
            Trash = GameObject.Find("/LechePrefab");
            Trash.transform.position = new Vector3(x, 1, z);
        }

        if (trashtype == 7)
        {
            Trash = GameObject.Find("/PastilleroPrefab");
            Trash.transform.position = new Vector3(x, 1, z);
        }

        if (trashtype == 8)
        {
            Trash = GameObject.Find("/RuedaPrefab");
            Trash.transform.position = new Vector3(x, 1, z);
        }

        if (trashtype == 9)
        {
            Trash = GameObject.Find("/SprayPrefab");
            Trash.transform.position = new Vector3(x, 1, z);
        }

        if (trashtype == 10)
        {
            Trash = GameObject.Find("/VasoPrefab");
            Trash.transform.position = new Vector3(x, 1, z);
        }
        //GameObject a = Instantiate(objectPrefab) as GameObject;
        ////Debug.Log(x);
        //a.transform.position = new Vector3(x, 1,z);
        z += 10;
    }

    IEnumerator generateTrash(){
        while(count<=15){
            yield return new WaitForSeconds(respawnTime);
            spawnTrash();
            Debug.Log("contador: " + count);
            count += 1;
        }
    }
    void Update()
    {

    }
}