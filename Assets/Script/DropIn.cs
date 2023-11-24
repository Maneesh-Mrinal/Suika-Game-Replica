using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropIn : MonoBehaviour
{
    public GameObject[] Items;
    static public bool isSpawned = false;
    int typeNumber = 0;
    GameObject instantiatedObject;
    //GameObject instantiatedObject2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float Xposition =  worldPosition.x;
        //MAX  = Vector3(-2.54881215,-3.38070536,0)
        if(Xposition < -2.54f) 
        {    
            Xposition = -2.54f;
        }
        if(Xposition > 2.52f)
        {
            Xposition = 2.52f;
        }
        SpawnObject(Xposition, typeNumber);
        //instantiatedObject = Instantiate(sprites[typeNumber], new Vector2(Xposition, 4f), Quaternion.identity);
        //instantiatedObject.transform.position = new Vector2(Xposition, 4f);
        if (Input.GetMouseButtonDown(0)){
            isSpawned = false;                
        }
        Debug.Log(worldPosition);
        Debug.Log(isSpawned);
    }
    void SpawnObject(float Xposition , int typeNumber)
    {
        if(!isSpawned)
        {
            Instantiate(Items[Random.Range(0, 5)], new Vector2(Xposition, 4f), Quaternion.identity);
            isSpawned = true;
        }
    }
}
