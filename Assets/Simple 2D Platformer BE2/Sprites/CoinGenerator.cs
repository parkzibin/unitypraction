using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public GameObject coinPrefab;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         this.delta += Time.deltaTime;
         if (this.delta > 0.5f)
         {
             this.delta = 0;
             GameObject newCoin = Instantiate(coinPrefab) as GameObject;
             newCoin.transform.position =new Vector3(Random.Range(-2.8f, 2.8f), 6, 0);
         }
    }
}
