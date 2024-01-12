using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float Score = 0;
    public GameObject[] ItemsDropped;
    public TMP_Text scoreCard;
    // Start is called before the first frame update
    void Start()
    {
        scoreCard.text = Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreCard.text = Score.ToString();
    }
    public void UpdateScore(string tagString)
    {
        for(int i = 0; i < ItemsDropped.Length; i++)
        {
            if (ItemsDropped[i].tag == tagString)
                {
                Score = Score + 10 * i;
                scoreCard.text = Score.ToString();
            }
        }
    }
}
