using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineObject : MonoBehaviour
{
    public GameObject myPrefab;
    public GameObject instantiatedObject;
    public bool isDropped = false;
    public bool isCombined = false;
    int id;
    // Start is called before the first frame update
    void Start()
    {
        id = GetInstanceID();
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
        if(isDropped == false && isCombined == false)
            transform.position = new Vector2(Xposition, 4.0f);
        if (Input.GetMouseButtonDown(0)){
            isDropped = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == gameObject.tag)
        {
            if(id < other.gameObject.GetComponent<CombineObject>().id){
                return;
            }   
            float x1 = (gameObject.transform.position.x + other.transform.position.x)/2;
            float y1 = (gameObject.transform.position.y + other.transform.position.y)/2;
            instantiatedObject = Instantiate(myPrefab, new Vector2(x1, y1), Quaternion.identity);
            instantiatedObject.GetComponent<CombineObject>().isCombined = true;
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}