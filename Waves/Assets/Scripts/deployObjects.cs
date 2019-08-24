using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployObjects : MonoBehaviour {
    public GameObject objectPrefab, boatPrefab;
    public float respawnTime = 1.0f;
    //private Vector2 screenBounds;
    private int x,count;
    private float z,b;

    // Use this for initialization
    void Start () {
      //  screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(generateTrash());
        z = 190;
        count = 1;
    }
    private void spawnTrash(){
        b=boatPrefab.GetComponent<Transform>().position.z;
        Debug.Log(b);
        GameObject a = Instantiate(objectPrefab) as GameObject;
        x = Random.Range(-22, 120);
        //Debug.Log(x);
        a.transform.position = new Vector3(x, 1,z);
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