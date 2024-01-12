using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour
{
    public bool hasRun = false;
    bool dropCheck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dropCheck = gameObject.GetComponent<CombineObject>().isDropped;
        AddScore();
    }
    public void AddScore()
    {
        if (dropCheck && !hasRun)
        {
            GameObject obj = GameObject.FindGameObjectWithTag("Spawner");
            obj.GetComponent<GameManager>().UpdateScore(gameObject.tag);
            hasRun = true;
        }
    }

}
