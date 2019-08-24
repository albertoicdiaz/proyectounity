using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployFish : MonoBehaviour {
    public GameObject fishleftPrefab, fishrightPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    private int x, count;
    public float speed;

    // Use this for initialization
    void Start () {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        Debug.Log("alto: " + Screen.height);
        Debug.Log("ancho: " + Screen.width);
        Debug.Log("screenboundsx" + screenBounds.x);
        Debug.Log("screenboundsy" + screenBounds.y);
        count = 0;

        StartCoroutine(asteroidWave());
    }
    private void spawnEnemy(){
        x = Random.Range(0, 6);
        Debug.Log(x);
   
        if (x == 0 || x == 1 || x == 2 || x == 3 || x == 4) // 0 izquierda, 1 derecha
        {
            GameObject a = Instantiate(fishleftPrefab) as GameObject;
            a.transform.position = new Vector2(screenBounds.x, ((screenBounds.y / 2) + Random.Range(-20, 20)));
            //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else
        {
            if (x == 5)
            {
                GameObject a = Instantiate(fishrightPrefab) as GameObject;
                //a.transform.position = new Vector2(374, Random.Range(450, 550));
                a.transform.position = new Vector2(screenBounds.x, ((screenBounds.y / 2) + Random.Range(-20, 20)));
            }
        }

    }

    IEnumerator asteroidWave(){
        while(true){
            count += 1;
            Debug.Log("count" + count);
            if (count >= 15)
            {
                yield return new WaitForSeconds(respawnTime);
                spawnEnemy();
            }
            //else
            //{
                
            //}

        }
    }
}