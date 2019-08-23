using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployObject : MonoBehaviour {
    public GameObject fishPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    private int x;
    public float speed;

    // Use this for initialization
    void Start () {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }
    private void spawnEnemy(){
        x = Random.Range(0, 2);
        Debug.Log(x);
        GameObject a = Instantiate(fishPrefab) as GameObject;
        if (x == 0) // 0 izquierda, 1 derecha
        {
         //   a.transform.position = new Vector3(Random.Range(-30,40), 0, ,);
        }
        else
        {
            if (x == 1)
            {
                a.transform.Rotate(0, 180, 0);
                a.transform.position = new Vector2(374, Random.Range(450, 550));
                speed = -50;
            }
        }
    }

    IEnumerator asteroidWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
    void Update()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}