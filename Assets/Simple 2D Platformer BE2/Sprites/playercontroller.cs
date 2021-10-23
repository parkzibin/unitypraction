using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        this.score = GameObject.Find("Score");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        this.score.GetComponent<scoreController>().gameScore -= 5;
        Destroy(other.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        // 왼쪽으로 이동해라

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localScale = new Vector3(-1, 1, 1);
            transform.Translate(-0.05f, 0, 0);
        }

        // 오른쪽으로 이동해라
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.Translate(0.05f, 0, 0);
        }


    }
}
