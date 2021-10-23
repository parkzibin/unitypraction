using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreController : MonoBehaviour
{
    public float gameScore;
    // Start is called before the first frame update
    void Start()
    {
        gameScore = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        gameScore += 0.01f;
        this.GetComponent<Text>().text = "Score : " + (int)gameScore;
    }
}
